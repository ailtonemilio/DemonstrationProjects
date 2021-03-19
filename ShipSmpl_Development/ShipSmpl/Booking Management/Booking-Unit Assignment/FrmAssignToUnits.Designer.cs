using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAssignToUnits : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssignToUnits));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties25 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties26 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            Label3 = new Label();
            Label9 = new Label();
            Panel1 = new Panel();
            _dgvSelectedBkg = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvSelectedBkg.SelectionChanged += new EventHandler(dgvSelectedBkg_SelectionChanged);
            BookingNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VWBookingMinibooking = new BindingSource(components);
            _assignBunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _assignBunifuButton1.Click += new EventHandler(assignBunifuButton1_Click);
            _tbSearchUnits = new BunifuTextBox();
            _tbSearchUnits.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            Panel6 = new Panel();
            _btnRemoveMB = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRemoveMB.Click += new EventHandler(btnRemoveMB_Click);
            Panel5 = new Panel();
            dgvUnitsAsnToBks = new Bunifu.UI.WinForms.BunifuDataGridView();
            MiniUnitNumberDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            VWMinibookingMiniUnitAssignmentBindingSource = new BindingSource(components);
            Label5 = new Label();
            Label4 = new Label();
            MiniUnitIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            MiniUnitOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnBilledDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BilledByUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BilledByUnitUnitTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnBilledByUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MULocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommentsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CustomerIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnitSourceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnitNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnitStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnitTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CargoTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            OriginLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarrierIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ETADateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ETALocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastTracedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SequenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TrackDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DemurageDaysDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            InTransitDaysDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BillDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CallDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ArrivalDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AvailableDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ReleaseDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastUpdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ActiveUpdatesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ActiveDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RecordKeyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CargoDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarReleasedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarAvailableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarArrivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarCalledDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ShipperIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GradeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommodityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ShipperCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ShipperNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommodityCodeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommodityNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            GradeCodeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            GradeNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            MiniUnitNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TotalBilledMUDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TotalBilledUSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MiniUnitIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            MiniUnitOrderDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnBilledDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            BilledByUnitDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            BilledByUnitUnitTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnBilledByUnitDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            MULocationDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CommentsDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CustomerIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            UnitSourceIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnitNumberDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            UnitStatusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UnitTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CargoTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            OriginLocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CarrierIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ETADateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ETALocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LastTracedDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LastLocationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SequenceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TrackDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DemurageDaysDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            InTransitDaysDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            BillDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CallDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ArrivalDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            AvailableDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ReleaseDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LastUpdateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ActiveUpdatesDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ActiveDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            RecordKeyDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CargoDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CarReleasedDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CarAvailableDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CarArrivedDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CarCalledDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ShipperIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            GradeIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommodityIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CustomerNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ShipperCodeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ShipperNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CommodityCodeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CommodityNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            GradeCodeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            GradeNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            MiniUnitNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TotalBilledMUDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TotalBilledUSDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            _dgvMiniUnits = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvMiniUnits.CellContentClick += new DataGridViewCellEventHandler(miniUnitsDataGridView_CellContentClick);
            Column2 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            CargoType = new DataGridViewTextBoxColumn();
            UnitTypeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            TotalBilled = new DataGridViewTextBoxColumn();
            CommodityGrade = new DataGridViewTextBoxColumn();
            VWUnitSourceMiniUnitBindingSource = new BindingSource(components);
            Column5 = new DataGridViewCheckBoxColumn();
            ShipperIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            RecordKeyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GradeCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommodityCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MULocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GradeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommodityNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnitNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MiniUnitIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ShapedPanel2 = new CustomizedControlsLibrary.ShapedPanel();
            ShapedPanel1 = new CustomizedControlsLibrary.ShapedPanel();
            tabUnits = new Dotnetrix.Controls.TabControlEX();
            loadingTabPage = new Dotnetrix.Controls.TabPageEX();
            TabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            _tbSearchStorageUnit = new BunifuTextBox();
            _tbSearchStorageUnit.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            _dgvStorageUnits = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvStorageUnits.CellContentClick += new DataGridViewCellEventHandler(miniUnitsDataGridView_CellContentClick);
            Column1 = new DataGridViewCheckBoxColumn();
            StorageLocation = new DataGridViewTextBoxColumn();
            MiniUnitNumber = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            RemainingQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GradeCommodityCode = new DataGridViewTextBoxColumn();
            StorageDate = new DataGridViewTextBoxColumn();
            VWGrainUnitStorageBindingSource = new BindingSource(components);
            _Timer1 = new Timer(components);
            _Timer1.Tick += new EventHandler(timer_Tick);
            TableLayoutPanel2 = new TableLayoutPanel();
            _tbCargoType = new BunifuTextBox();
            _tbCargoType.TextChanged += new EventHandler(tbCargoType_TextChanged);
            _tbType = new BunifuTextBox();
            _tbType.TextChanged += new EventHandler(tbCargoType_TextChanged);
            tbCommodity = new BunifuTextBox();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvSelectedBkg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibooking).BeginInit();
            Panel6.SuspendLayout();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnitsAsnToBks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingMiniUnitAssignmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvMiniUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BunifuDataGridView1).BeginInit();
            ShapedPanel2.SuspendLayout();
            ShapedPanel1.SuspendLayout();
            tabUnits.SuspendLayout();
            loadingTabPage.SuspendLayout();
            TabPageEX2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvStorageUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWGrainUnitStorageBindingSource).BeginInit();
            TableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _cancelButton.AnimationSpeed = 200;
            _cancelButton.AutoGenerateColors = false;
            _cancelButton.BackColor = Color.Transparent;
            _cancelButton.BackColor1 = Color.Gray;
            _cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            _cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cancelButton.ButtonText = "Cancel";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges1;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.White;
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.Gray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.Gray;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(729, 718);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(119, 33);
            _cancelButton.TabIndex = 137;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Iconcolor = Color.Transparent;
            _closeFlatButton.Iconimage = null;
            _closeFlatButton.Iconimage_right = null;
            _closeFlatButton.Iconimage_right_Selected = null;
            _closeFlatButton.Iconimage_Selected = null;
            _closeFlatButton.IconMarginLeft = 0;
            _closeFlatButton.IconMarginRight = 0;
            _closeFlatButton.IconRightVisible = true;
            _closeFlatButton.IconRightZoom = 0d;
            _closeFlatButton.IconVisible = true;
            _closeFlatButton.IconZoom = 90.0d;
            _closeFlatButton.IsTab = false;
            _closeFlatButton.Location = new Point(1434, 0);
            _closeFlatButton.Margin = new Padding(4);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 174;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label8
            // 
            Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Dock = DockStyle.Top;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(0, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(1477, 41);
            Label8.TabIndex = 173;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(48, 91);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(779, 32);
            Label3.TabIndex = 177;
            Label3.Text = "Select the unit sources then click the arrow button to assign them to the selecte" + "d bookings";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(22, 66);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(300, 21);
            Label9.TabIndex = 176;
            Label9.Text = "Choose the Unit Sources to be assigned";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.None;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(_dgvSelectedBkg);
            Panel1.Location = new Point(10, 26);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(193, 451);
            Panel1.TabIndex = 180;
            // 
            // dgvSelectedBkg
            // 
            _dgvSelectedBkg.AllowCustomTheming = true;
            _dgvSelectedBkg.AllowUserToAddRows = false;
            _dgvSelectedBkg.AllowUserToDeleteRows = false;
            _dgvSelectedBkg.AllowUserToOrderColumns = true;
            _dgvSelectedBkg.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvSelectedBkg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvSelectedBkg.AutoGenerateColumns = false;
            _dgvSelectedBkg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvSelectedBkg.BackgroundColor = Color.White;
            _dgvSelectedBkg.BorderStyle = BorderStyle.None;
            _dgvSelectedBkg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvSelectedBkg.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvSelectedBkg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvSelectedBkg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvSelectedBkg.ColumnHeadersHeight = 32;
            _dgvSelectedBkg.Columns.AddRange(new DataGridViewColumn[] { BookingNumberDataGridViewTextBoxColumn });
            _dgvSelectedBkg.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvSelectedBkg.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvSelectedBkg.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvSelectedBkg.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvSelectedBkg.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvSelectedBkg.CurrentTheme.BackColor = Color.Snow;
            _dgvSelectedBkg.CurrentTheme.GridColor = Color.Gray;
            _dgvSelectedBkg.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvSelectedBkg.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvSelectedBkg.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvSelectedBkg.CurrentTheme.Name = null;
            _dgvSelectedBkg.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvSelectedBkg.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvSelectedBkg.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvSelectedBkg.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvSelectedBkg.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvSelectedBkg.DataSource = VWBookingMinibooking;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvSelectedBkg.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvSelectedBkg.Dock = DockStyle.Fill;
            _dgvSelectedBkg.EnableHeadersVisualStyles = false;
            _dgvSelectedBkg.GridColor = Color.Gray;
            _dgvSelectedBkg.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvSelectedBkg.HeaderBgColor = Color.Empty;
            _dgvSelectedBkg.HeaderForeColor = Color.White;
            _dgvSelectedBkg.Location = new Point(0, 0);
            _dgvSelectedBkg.MultiSelect = false;
            _dgvSelectedBkg.Name = "_dgvSelectedBkg";
            _dgvSelectedBkg.ReadOnly = true;
            _dgvSelectedBkg.RowHeadersVisible = false;
            _dgvSelectedBkg.RowHeadersWidth = 51;
            _dgvSelectedBkg.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvSelectedBkg.RowTemplate.Height = 30;
            _dgvSelectedBkg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvSelectedBkg.Size = new Size(191, 449);
            _dgvSelectedBkg.TabIndex = 174;
            _dgvSelectedBkg.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // BookingNumberDataGridViewTextBoxColumn
            // 
            BookingNumberDataGridViewTextBoxColumn.DataPropertyName = "MinibookingNumber";
            BookingNumberDataGridViewTextBoxColumn.HeaderText = "Booking Number";
            BookingNumberDataGridViewTextBoxColumn.Name = "BookingNumberDataGridViewTextBoxColumn";
            BookingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VWBookingMinibooking
            // 
            VWBookingMinibooking.DataSource = typeof(ModelLayer.VW_BookingMinibooking);
            // 
            // assignBunifuButton1
            // 
            _assignBunifuButton1.AllowToggling = false;
            _assignBunifuButton1.Anchor = AnchorStyles.None;
            _assignBunifuButton1.AnimationSpeed = 200;
            _assignBunifuButton1.AutoGenerateColors = false;
            _assignBunifuButton1.BackColor = Color.Transparent;
            _assignBunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _assignBunifuButton1.BackgroundImage = (Image)resources.GetObject("assignBunifuButton1.BackgroundImage");
            _assignBunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _assignBunifuButton1.ButtonText = "";
            _assignBunifuButton1.ButtonTextMarginLeft = 0;
            _assignBunifuButton1.ColorContrastOnClick = 45;
            _assignBunifuButton1.ColorContrastOnHover = 45;
            _assignBunifuButton1.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _assignBunifuButton1.CustomizableEdges = BorderEdges2;
            _assignBunifuButton1.DialogResult = DialogResult.None;
            _assignBunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _assignBunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _assignBunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _assignBunifuButton1.Enabled = false;
            _assignBunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _assignBunifuButton1.Font = new Font("Microsoft Sans Serif", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _assignBunifuButton1.ForeColor = Color.White;
            _assignBunifuButton1.IconLeftCursor = Cursors.Hand;
            _assignBunifuButton1.IconMarginLeft = 8;
            _assignBunifuButton1.IconPadding = 8;
            _assignBunifuButton1.IconRightCursor = Cursors.Hand;
            _assignBunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _assignBunifuButton1.IdleBorderRadius = 30;
            _assignBunifuButton1.IdleBorderThickness = 1;
            _assignBunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _assignBunifuButton1.IdleIconLeftImage = (Image)resources.GetObject("assignBunifuButton1.IdleIconLeftImage");
            _assignBunifuButton1.IdleIconRightImage = null;
            _assignBunifuButton1.IndicateFocus = false;
            _assignBunifuButton1.Location = new Point(954, 414);
            _assignBunifuButton1.Name = "_assignBunifuButton1";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.BorderRadius = 30;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _assignBunifuButton1.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.BorderRadius = 30;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _assignBunifuButton1.OnPressedState = StateProperties4;
            _assignBunifuButton1.Size = new Size(48, 52);
            _assignBunifuButton1.TabIndex = 181;
            _assignBunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _assignBunifuButton1.TextMarginLeft = 0;
            _assignBunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // tbSearchUnits
            // 
            _tbSearchUnits.AcceptsReturn = false;
            _tbSearchUnits.AcceptsTab = false;
            _tbSearchUnits.AnimationSpeed = 200;
            _tbSearchUnits.AutoCompleteMode = AutoCompleteMode.None;
            _tbSearchUnits.AutoCompleteSource = AutoCompleteSource.None;
            _tbSearchUnits.BackColor = Color.Transparent;
            _tbSearchUnits.BackgroundImage = (Image)resources.GetObject("tbSearchUnits.BackgroundImage");
            _tbSearchUnits.BorderColorActive = Color.DodgerBlue;
            _tbSearchUnits.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbSearchUnits.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbSearchUnits.BorderColorIdle = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            _tbSearchUnits.BorderRadius = 1;
            _tbSearchUnits.BorderThickness = 1;
            _tbSearchUnits.CharacterCasing = CharacterCasing.Normal;
            _tbSearchUnits.Cursor = Cursors.IBeam;
            _tbSearchUnits.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _tbSearchUnits.DefaultText = "";
            _tbSearchUnits.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbSearchUnits.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _tbSearchUnits.HideSelection = true;
            _tbSearchUnits.IconLeft = null;
            _tbSearchUnits.IconLeftCursor = Cursors.IBeam;
            _tbSearchUnits.IconPadding = 10;
            _tbSearchUnits.IconRight = null;
            _tbSearchUnits.IconRightCursor = Cursors.IBeam;
            _tbSearchUnits.Lines = new string[0];
            _tbSearchUnits.Location = new Point(631, 4);
            _tbSearchUnits.MaxLength = 32767;
            _tbSearchUnits.MinimumSize = new Size(100, 30);
            _tbSearchUnits.Modified = false;
            _tbSearchUnits.Multiline = false;
            _tbSearchUnits.Name = "_tbSearchUnits";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _tbSearchUnits.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _tbSearchUnits.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _tbSearchUnits.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _tbSearchUnits.OnIdleState = StateProperties8;
            _tbSearchUnits.PasswordChar = '\0';
            _tbSearchUnits.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            _tbSearchUnits.PlaceholderText = "Search unit source...";
            _tbSearchUnits.ReadOnly = false;
            _tbSearchUnits.ScrollBars = ScrollBars.None;
            _tbSearchUnits.SelectedText = "";
            _tbSearchUnits.SelectionLength = 0;
            _tbSearchUnits.SelectionStart = 0;
            _tbSearchUnits.ShortcutsEnabled = true;
            _tbSearchUnits.Size = new Size(257, 30);
            _tbSearchUnits.Style = _Style.Bunifu;
            _tbSearchUnits.TabIndex = 182;
            _tbSearchUnits.TextAlign = HorizontalAlignment.Left;
            _tbSearchUnits.TextMarginBottom = 0;
            _tbSearchUnits.TextMarginLeft = 5;
            _tbSearchUnits.TextMarginTop = 0;
            _tbSearchUnits.TextPlaceholder = "Search unit source...";
            _tbSearchUnits.UseSystemPasswordChar = false;
            _tbSearchUnits.WordWrap = true;
            // 
            // Panel6
            // 
            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(_btnRemoveMB);
            Panel6.Controls.Add(Panel1);
            Panel6.Controls.Add(Panel5);
            Panel6.Controls.Add(Label5);
            Panel6.Controls.Add(Label4);
            Panel6.Location = new Point(1017, 184);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(430, 509);
            Panel6.TabIndex = 192;
            // 
            // btnRemoveMB
            // 
            _btnRemoveMB.AllowToggling = false;
            _btnRemoveMB.Anchor = AnchorStyles.None;
            _btnRemoveMB.AnimationSpeed = 200;
            _btnRemoveMB.AutoGenerateColors = false;
            _btnRemoveMB.BackColor = Color.Transparent;
            _btnRemoveMB.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRemoveMB.BackgroundImage = (Image)resources.GetObject("btnRemoveMB.BackgroundImage");
            _btnRemoveMB.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRemoveMB.ButtonText = "";
            _btnRemoveMB.ButtonTextMarginLeft = 0;
            _btnRemoveMB.ColorContrastOnClick = 45;
            _btnRemoveMB.ColorContrastOnHover = 45;
            _btnRemoveMB.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnRemoveMB.CustomizableEdges = BorderEdges3;
            _btnRemoveMB.DialogResult = DialogResult.None;
            _btnRemoveMB.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnRemoveMB.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRemoveMB.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRemoveMB.Enabled = false;
            _btnRemoveMB.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRemoveMB.Font = new Font("Microsoft Sans Serif", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRemoveMB.ForeColor = Color.White;
            _btnRemoveMB.IconLeftCursor = Cursors.Hand;
            _btnRemoveMB.IconMarginLeft = 4;
            _btnRemoveMB.IconPadding = 4;
            _btnRemoveMB.IconRightCursor = Cursors.Hand;
            _btnRemoveMB.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRemoveMB.IdleBorderRadius = 15;
            _btnRemoveMB.IdleBorderThickness = 1;
            _btnRemoveMB.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRemoveMB.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnRemoveMB.IdleIconRightImage = null;
            _btnRemoveMB.IndicateFocus = false;
            _btnRemoveMB.Location = new Point(205, 78);
            _btnRemoveMB.Name = "_btnRemoveMB";
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.BorderRadius = 15;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnRemoveMB.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.BorderRadius = 15;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnRemoveMB.OnPressedState = StateProperties10;
            _btnRemoveMB.Size = new Size(23, 24);
            _btnRemoveMB.TabIndex = 194;
            _btnRemoveMB.TextAlign = ContentAlignment.MiddleCenter;
            _btnRemoveMB.TextMarginLeft = 0;
            _btnRemoveMB.UseDefaultRadiusAndThickness = true;
            // 
            // Panel5
            // 
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(dgvUnitsAsnToBks);
            Panel5.Location = new Point(234, 25);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(189, 227);
            Panel5.TabIndex = 190;
            // 
            // dgvUnitsAsnToBks
            // 
            dgvUnitsAsnToBks.AllowCustomTheming = true;
            dgvUnitsAsnToBks.AllowUserToAddRows = false;
            dgvUnitsAsnToBks.AllowUserToDeleteRows = false;
            dgvUnitsAsnToBks.AllowUserToOrderColumns = true;
            dgvUnitsAsnToBks.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvUnitsAsnToBks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvUnitsAsnToBks.AutoGenerateColumns = false;
            dgvUnitsAsnToBks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnitsAsnToBks.BackgroundColor = Color.White;
            dgvUnitsAsnToBks.BorderStyle = BorderStyle.None;
            dgvUnitsAsnToBks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnitsAsnToBks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvUnitsAsnToBks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvUnitsAsnToBks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            dgvUnitsAsnToBks.ColumnHeadersHeight = 32;
            dgvUnitsAsnToBks.Columns.AddRange(new DataGridViewColumn[] { MiniUnitNumberDataGridViewTextBoxColumn3 });
            dgvUnitsAsnToBks.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvUnitsAsnToBks.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvUnitsAsnToBks.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvUnitsAsnToBks.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            dgvUnitsAsnToBks.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvUnitsAsnToBks.CurrentTheme.BackColor = Color.Snow;
            dgvUnitsAsnToBks.CurrentTheme.GridColor = Color.Gray;
            dgvUnitsAsnToBks.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvUnitsAsnToBks.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            dgvUnitsAsnToBks.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvUnitsAsnToBks.CurrentTheme.Name = null;
            dgvUnitsAsnToBks.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            dgvUnitsAsnToBks.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvUnitsAsnToBks.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvUnitsAsnToBks.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            dgvUnitsAsnToBks.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dgvUnitsAsnToBks.DataSource = VWMinibookingMiniUnitAssignmentBindingSource;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvUnitsAsnToBks.DefaultCellStyle = DataGridViewCellStyle6;
            dgvUnitsAsnToBks.Dock = DockStyle.Fill;
            dgvUnitsAsnToBks.EnableHeadersVisualStyles = false;
            dgvUnitsAsnToBks.GridColor = Color.Gray;
            dgvUnitsAsnToBks.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvUnitsAsnToBks.HeaderBgColor = Color.Empty;
            dgvUnitsAsnToBks.HeaderForeColor = Color.White;
            dgvUnitsAsnToBks.Location = new Point(0, 0);
            dgvUnitsAsnToBks.MultiSelect = false;
            dgvUnitsAsnToBks.Name = "dgvUnitsAsnToBks";
            dgvUnitsAsnToBks.ReadOnly = true;
            dgvUnitsAsnToBks.RowHeadersVisible = false;
            dgvUnitsAsnToBks.RowHeadersWidth = 51;
            dgvUnitsAsnToBks.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvUnitsAsnToBks.RowTemplate.Height = 30;
            dgvUnitsAsnToBks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnitsAsnToBks.Size = new Size(187, 225);
            dgvUnitsAsnToBks.TabIndex = 173;
            dgvUnitsAsnToBks.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // MiniUnitNumberDataGridViewTextBoxColumn3
            // 
            MiniUnitNumberDataGridViewTextBoxColumn3.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumberDataGridViewTextBoxColumn3.HeaderText = "  Unit Number";
            MiniUnitNumberDataGridViewTextBoxColumn3.Name = "MiniUnitNumberDataGridViewTextBoxColumn3";
            MiniUnitNumberDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // VWMinibookingMiniUnitAssignmentBindingSource
            // 
            VWMinibookingMiniUnitAssignmentBindingSource.DataSource = typeof(ModelLayer.VW_MinibookingMiniUnitAssignment);
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.None;
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label5.Location = new Point(10, 0);
            Label5.Margin = new Padding(0);
            Label5.Name = "Label5";
            Label5.Size = new Size(146, 21);
            Label5.TabIndex = 191;
            Label5.Text = "Selected Bookings";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.None;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label4.Location = new Point(235, 0);
            Label4.Margin = new Padding(0);
            Label4.Name = "Label4";
            Label4.Size = new Size(115, 21);
            Label4.TabIndex = 192;
            Label4.Text = "Units assigned";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MiniUnitIdDataGridViewTextBoxColumn1
            // 
            MiniUnitIdDataGridViewTextBoxColumn1.DataPropertyName = "MiniUnitId";
            MiniUnitIdDataGridViewTextBoxColumn1.HeaderText = "MiniUnitId";
            MiniUnitIdDataGridViewTextBoxColumn1.Name = "MiniUnitIdDataGridViewTextBoxColumn1";
            MiniUnitIdDataGridViewTextBoxColumn1.Width = 17;
            // 
            // MiniUnitOrderDataGridViewTextBoxColumn
            // 
            MiniUnitOrderDataGridViewTextBoxColumn.DataPropertyName = "MiniUnitOrder";
            MiniUnitOrderDataGridViewTextBoxColumn.HeaderText = "MiniUnitOrder";
            MiniUnitOrderDataGridViewTextBoxColumn.Name = "MiniUnitOrderDataGridViewTextBoxColumn";
            MiniUnitOrderDataGridViewTextBoxColumn.Width = 17;
            // 
            // UnBilledDataGridViewTextBoxColumn
            // 
            UnBilledDataGridViewTextBoxColumn.DataPropertyName = "UnBilled";
            UnBilledDataGridViewTextBoxColumn.HeaderText = "UnBilled";
            UnBilledDataGridViewTextBoxColumn.Name = "UnBilledDataGridViewTextBoxColumn";
            UnBilledDataGridViewTextBoxColumn.Width = 17;
            // 
            // BilledByUnitDataGridViewTextBoxColumn
            // 
            BilledByUnitDataGridViewTextBoxColumn.DataPropertyName = "BilledByUnit";
            BilledByUnitDataGridViewTextBoxColumn.HeaderText = "BilledByUnit";
            BilledByUnitDataGridViewTextBoxColumn.Name = "BilledByUnitDataGridViewTextBoxColumn";
            BilledByUnitDataGridViewTextBoxColumn.Width = 17;
            // 
            // BilledByUnitUnitTypeDataGridViewTextBoxColumn
            // 
            BilledByUnitUnitTypeDataGridViewTextBoxColumn.DataPropertyName = "BilledByUnitUnitType";
            BilledByUnitUnitTypeDataGridViewTextBoxColumn.HeaderText = "BilledByUnitUnitType";
            BilledByUnitUnitTypeDataGridViewTextBoxColumn.Name = "BilledByUnitUnitTypeDataGridViewTextBoxColumn";
            BilledByUnitUnitTypeDataGridViewTextBoxColumn.Width = 17;
            // 
            // UnBilledByUnitDataGridViewTextBoxColumn
            // 
            UnBilledByUnitDataGridViewTextBoxColumn.DataPropertyName = "UnBilledByUnit";
            UnBilledByUnitDataGridViewTextBoxColumn.HeaderText = "UnBilledByUnit";
            UnBilledByUnitDataGridViewTextBoxColumn.Name = "UnBilledByUnitDataGridViewTextBoxColumn";
            UnBilledByUnitDataGridViewTextBoxColumn.Width = 17;
            // 
            // UnBilledByUnitUnitTypeDataGridViewTextBoxColumn
            // 
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn.DataPropertyName = "UnBilledByUnitUnitType";
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn.HeaderText = "UnBilledByUnitUnitType";
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn.Name = "UnBilledByUnitUnitTypeDataGridViewTextBoxColumn";
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn.Width = 17;
            // 
            // MULocationDataGridViewTextBoxColumn1
            // 
            MULocationDataGridViewTextBoxColumn1.DataPropertyName = "MULocation";
            MULocationDataGridViewTextBoxColumn1.HeaderText = "MULocation";
            MULocationDataGridViewTextBoxColumn1.Name = "MULocationDataGridViewTextBoxColumn1";
            MULocationDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CommentsDataGridViewTextBoxColumn1
            // 
            CommentsDataGridViewTextBoxColumn1.DataPropertyName = "Comments";
            CommentsDataGridViewTextBoxColumn1.HeaderText = "Comments";
            CommentsDataGridViewTextBoxColumn1.Name = "CommentsDataGridViewTextBoxColumn1";
            CommentsDataGridViewTextBoxColumn1.Width = 18;
            // 
            // CustomerIdDataGridViewTextBoxColumn1
            // 
            CustomerIdDataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            CustomerIdDataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            CustomerIdDataGridViewTextBoxColumn1.Name = "CustomerIdDataGridViewTextBoxColumn1";
            CustomerIdDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnitSourceIdDataGridViewTextBoxColumn
            // 
            UnitSourceIdDataGridViewTextBoxColumn.DataPropertyName = "UnitSourceId";
            UnitSourceIdDataGridViewTextBoxColumn.HeaderText = "UnitSourceId";
            UnitSourceIdDataGridViewTextBoxColumn.Name = "UnitSourceIdDataGridViewTextBoxColumn";
            UnitSourceIdDataGridViewTextBoxColumn.Width = 17;
            // 
            // UnitNumberDataGridViewTextBoxColumn1
            // 
            UnitNumberDataGridViewTextBoxColumn1.DataPropertyName = "UnitNumber";
            UnitNumberDataGridViewTextBoxColumn1.HeaderText = "UnitNumber";
            UnitNumberDataGridViewTextBoxColumn1.Name = "UnitNumberDataGridViewTextBoxColumn1";
            UnitNumberDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnitStatusDataGridViewTextBoxColumn
            // 
            UnitStatusDataGridViewTextBoxColumn.DataPropertyName = "UnitStatus";
            UnitStatusDataGridViewTextBoxColumn.HeaderText = "UnitStatus";
            UnitStatusDataGridViewTextBoxColumn.Name = "UnitStatusDataGridViewTextBoxColumn";
            UnitStatusDataGridViewTextBoxColumn.Width = 17;
            // 
            // UnitTypeDataGridViewTextBoxColumn
            // 
            UnitTypeDataGridViewTextBoxColumn.DataPropertyName = "UnitType";
            UnitTypeDataGridViewTextBoxColumn.HeaderText = "UnitType";
            UnitTypeDataGridViewTextBoxColumn.Name = "UnitTypeDataGridViewTextBoxColumn";
            UnitTypeDataGridViewTextBoxColumn.Width = 17;
            // 
            // CargoTypeDataGridViewTextBoxColumn
            // 
            CargoTypeDataGridViewTextBoxColumn.DataPropertyName = "CargoType";
            CargoTypeDataGridViewTextBoxColumn.HeaderText = "CargoType";
            CargoTypeDataGridViewTextBoxColumn.Name = "CargoTypeDataGridViewTextBoxColumn";
            CargoTypeDataGridViewTextBoxColumn.Width = 17;
            // 
            // OriginLocationDataGridViewTextBoxColumn
            // 
            OriginLocationDataGridViewTextBoxColumn.DataPropertyName = "OriginLocation";
            OriginLocationDataGridViewTextBoxColumn.HeaderText = "OriginLocation";
            OriginLocationDataGridViewTextBoxColumn.Name = "OriginLocationDataGridViewTextBoxColumn";
            OriginLocationDataGridViewTextBoxColumn.Width = 17;
            // 
            // CarrierIdDataGridViewTextBoxColumn
            // 
            CarrierIdDataGridViewTextBoxColumn.DataPropertyName = "CarrierId";
            CarrierIdDataGridViewTextBoxColumn.HeaderText = "CarrierId";
            CarrierIdDataGridViewTextBoxColumn.Name = "CarrierIdDataGridViewTextBoxColumn";
            CarrierIdDataGridViewTextBoxColumn.Width = 17;
            // 
            // ETADateDataGridViewTextBoxColumn
            // 
            ETADateDataGridViewTextBoxColumn.DataPropertyName = "ETADate";
            ETADateDataGridViewTextBoxColumn.HeaderText = "ETADate";
            ETADateDataGridViewTextBoxColumn.Name = "ETADateDataGridViewTextBoxColumn";
            ETADateDataGridViewTextBoxColumn.Width = 17;
            // 
            // ETALocationDataGridViewTextBoxColumn
            // 
            ETALocationDataGridViewTextBoxColumn.DataPropertyName = "ETALocation";
            ETALocationDataGridViewTextBoxColumn.HeaderText = "ETALocation";
            ETALocationDataGridViewTextBoxColumn.Name = "ETALocationDataGridViewTextBoxColumn";
            ETALocationDataGridViewTextBoxColumn.Width = 17;
            // 
            // LastTracedDataGridViewTextBoxColumn
            // 
            LastTracedDataGridViewTextBoxColumn.DataPropertyName = "LastTraced";
            LastTracedDataGridViewTextBoxColumn.HeaderText = "LastTraced";
            LastTracedDataGridViewTextBoxColumn.Name = "LastTracedDataGridViewTextBoxColumn";
            LastTracedDataGridViewTextBoxColumn.Width = 17;
            // 
            // LastLocationDataGridViewTextBoxColumn
            // 
            LastLocationDataGridViewTextBoxColumn.DataPropertyName = "LastLocation";
            LastLocationDataGridViewTextBoxColumn.HeaderText = "LastLocation";
            LastLocationDataGridViewTextBoxColumn.Name = "LastLocationDataGridViewTextBoxColumn";
            LastLocationDataGridViewTextBoxColumn.Width = 17;
            // 
            // SequenceDataGridViewTextBoxColumn
            // 
            SequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            SequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            SequenceDataGridViewTextBoxColumn.Name = "SequenceDataGridViewTextBoxColumn";
            SequenceDataGridViewTextBoxColumn.Width = 17;
            // 
            // TrackDataGridViewTextBoxColumn
            // 
            TrackDataGridViewTextBoxColumn.DataPropertyName = "Track";
            TrackDataGridViewTextBoxColumn.HeaderText = "Track";
            TrackDataGridViewTextBoxColumn.Name = "TrackDataGridViewTextBoxColumn";
            TrackDataGridViewTextBoxColumn.Width = 17;
            // 
            // DemurageDaysDataGridViewTextBoxColumn
            // 
            DemurageDaysDataGridViewTextBoxColumn.DataPropertyName = "DemurageDays";
            DemurageDaysDataGridViewTextBoxColumn.HeaderText = "DemurageDays";
            DemurageDaysDataGridViewTextBoxColumn.Name = "DemurageDaysDataGridViewTextBoxColumn";
            DemurageDaysDataGridViewTextBoxColumn.Width = 17;
            // 
            // InTransitDaysDataGridViewTextBoxColumn
            // 
            InTransitDaysDataGridViewTextBoxColumn.DataPropertyName = "InTransitDays";
            InTransitDaysDataGridViewTextBoxColumn.HeaderText = "InTransitDays";
            InTransitDaysDataGridViewTextBoxColumn.Name = "InTransitDaysDataGridViewTextBoxColumn";
            InTransitDaysDataGridViewTextBoxColumn.Width = 17;
            // 
            // BillDateDataGridViewTextBoxColumn
            // 
            BillDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate";
            BillDateDataGridViewTextBoxColumn.HeaderText = "BillDate";
            BillDateDataGridViewTextBoxColumn.Name = "BillDateDataGridViewTextBoxColumn";
            BillDateDataGridViewTextBoxColumn.Width = 17;
            // 
            // CallDateDataGridViewTextBoxColumn
            // 
            CallDateDataGridViewTextBoxColumn.DataPropertyName = "CallDate";
            CallDateDataGridViewTextBoxColumn.HeaderText = "CallDate";
            CallDateDataGridViewTextBoxColumn.Name = "CallDateDataGridViewTextBoxColumn";
            CallDateDataGridViewTextBoxColumn.Width = 18;
            // 
            // ArrivalDateDataGridViewTextBoxColumn
            // 
            ArrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            ArrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            ArrivalDateDataGridViewTextBoxColumn.Name = "ArrivalDateDataGridViewTextBoxColumn";
            ArrivalDateDataGridViewTextBoxColumn.Width = 17;
            // 
            // AvailableDateDataGridViewTextBoxColumn
            // 
            AvailableDateDataGridViewTextBoxColumn.DataPropertyName = "AvailableDate";
            AvailableDateDataGridViewTextBoxColumn.HeaderText = "AvailableDate";
            AvailableDateDataGridViewTextBoxColumn.Name = "AvailableDateDataGridViewTextBoxColumn";
            AvailableDateDataGridViewTextBoxColumn.Width = 17;
            // 
            // ReleaseDateDataGridViewTextBoxColumn
            // 
            ReleaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            ReleaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            ReleaseDateDataGridViewTextBoxColumn.Name = "ReleaseDateDataGridViewTextBoxColumn";
            ReleaseDateDataGridViewTextBoxColumn.Width = 17;
            // 
            // LastUpdateDataGridViewTextBoxColumn
            // 
            LastUpdateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdate";
            LastUpdateDataGridViewTextBoxColumn.HeaderText = "LastUpdate";
            LastUpdateDataGridViewTextBoxColumn.Name = "LastUpdateDataGridViewTextBoxColumn";
            LastUpdateDataGridViewTextBoxColumn.Width = 17;
            // 
            // ActiveUpdatesDataGridViewTextBoxColumn
            // 
            ActiveUpdatesDataGridViewTextBoxColumn.DataPropertyName = "ActiveUpdates";
            ActiveUpdatesDataGridViewTextBoxColumn.HeaderText = "ActiveUpdates";
            ActiveUpdatesDataGridViewTextBoxColumn.Name = "ActiveUpdatesDataGridViewTextBoxColumn";
            ActiveUpdatesDataGridViewTextBoxColumn.Width = 17;
            // 
            // ActiveDataGridViewTextBoxColumn
            // 
            ActiveDataGridViewTextBoxColumn.DataPropertyName = "Active";
            ActiveDataGridViewTextBoxColumn.HeaderText = "Active";
            ActiveDataGridViewTextBoxColumn.Name = "ActiveDataGridViewTextBoxColumn";
            ActiveDataGridViewTextBoxColumn.Width = 17;
            // 
            // RecordKeyDataGridViewTextBoxColumn1
            // 
            RecordKeyDataGridViewTextBoxColumn1.DataPropertyName = "RecordKey";
            RecordKeyDataGridViewTextBoxColumn1.HeaderText = "RecordKey";
            RecordKeyDataGridViewTextBoxColumn1.Name = "RecordKeyDataGridViewTextBoxColumn1";
            RecordKeyDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CargoDescriptionDataGridViewTextBoxColumn
            // 
            CargoDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CargoDescription";
            CargoDescriptionDataGridViewTextBoxColumn.HeaderText = "CargoDescription";
            CargoDescriptionDataGridViewTextBoxColumn.Name = "CargoDescriptionDataGridViewTextBoxColumn";
            CargoDescriptionDataGridViewTextBoxColumn.Width = 17;
            // 
            // CarReleasedDataGridViewTextBoxColumn
            // 
            CarReleasedDataGridViewTextBoxColumn.DataPropertyName = "CarReleased";
            CarReleasedDataGridViewTextBoxColumn.HeaderText = "CarReleased";
            CarReleasedDataGridViewTextBoxColumn.Name = "CarReleasedDataGridViewTextBoxColumn";
            CarReleasedDataGridViewTextBoxColumn.Width = 17;
            // 
            // CarAvailableDataGridViewTextBoxColumn
            // 
            CarAvailableDataGridViewTextBoxColumn.DataPropertyName = "CarAvailable";
            CarAvailableDataGridViewTextBoxColumn.HeaderText = "CarAvailable";
            CarAvailableDataGridViewTextBoxColumn.Name = "CarAvailableDataGridViewTextBoxColumn";
            CarAvailableDataGridViewTextBoxColumn.Width = 17;
            // 
            // CarArrivedDataGridViewTextBoxColumn
            // 
            CarArrivedDataGridViewTextBoxColumn.DataPropertyName = "CarArrived";
            CarArrivedDataGridViewTextBoxColumn.HeaderText = "CarArrived";
            CarArrivedDataGridViewTextBoxColumn.Name = "CarArrivedDataGridViewTextBoxColumn";
            CarArrivedDataGridViewTextBoxColumn.Width = 17;
            // 
            // CarCalledDataGridViewTextBoxColumn
            // 
            CarCalledDataGridViewTextBoxColumn.DataPropertyName = "CarCalled";
            CarCalledDataGridViewTextBoxColumn.HeaderText = "CarCalled";
            CarCalledDataGridViewTextBoxColumn.Name = "CarCalledDataGridViewTextBoxColumn";
            CarCalledDataGridViewTextBoxColumn.Width = 17;
            // 
            // ShipperIdDataGridViewTextBoxColumn
            // 
            ShipperIdDataGridViewTextBoxColumn.DataPropertyName = "ShipperId";
            ShipperIdDataGridViewTextBoxColumn.HeaderText = "ShipperId";
            ShipperIdDataGridViewTextBoxColumn.Name = "ShipperIdDataGridViewTextBoxColumn";
            ShipperIdDataGridViewTextBoxColumn.Width = 17;
            // 
            // GradeIdDataGridViewTextBoxColumn
            // 
            GradeIdDataGridViewTextBoxColumn.DataPropertyName = "GradeId";
            GradeIdDataGridViewTextBoxColumn.HeaderText = "GradeId";
            GradeIdDataGridViewTextBoxColumn.Name = "GradeIdDataGridViewTextBoxColumn";
            GradeIdDataGridViewTextBoxColumn.Width = 17;
            // 
            // CommodityIdDataGridViewTextBoxColumn
            // 
            CommodityIdDataGridViewTextBoxColumn.DataPropertyName = "CommodityId";
            CommodityIdDataGridViewTextBoxColumn.HeaderText = "CommodityId";
            CommodityIdDataGridViewTextBoxColumn.Name = "CommodityIdDataGridViewTextBoxColumn";
            CommodityIdDataGridViewTextBoxColumn.Width = 17;
            // 
            // CustomerNameDataGridViewTextBoxColumn1
            // 
            CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1";
            CustomerNameDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ShipperCodeDataGridViewTextBoxColumn
            // 
            ShipperCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipperCode";
            ShipperCodeDataGridViewTextBoxColumn.HeaderText = "ShipperCode";
            ShipperCodeDataGridViewTextBoxColumn.Name = "ShipperCodeDataGridViewTextBoxColumn";
            ShipperCodeDataGridViewTextBoxColumn.Width = 18;
            // 
            // ShipperNameDataGridViewTextBoxColumn
            // 
            ShipperNameDataGridViewTextBoxColumn.DataPropertyName = "ShipperName";
            ShipperNameDataGridViewTextBoxColumn.HeaderText = "ShipperName";
            ShipperNameDataGridViewTextBoxColumn.Name = "ShipperNameDataGridViewTextBoxColumn";
            ShipperNameDataGridViewTextBoxColumn.Width = 17;
            // 
            // CommodityCodeDataGridViewTextBoxColumn1
            // 
            CommodityCodeDataGridViewTextBoxColumn1.DataPropertyName = "CommodityCode";
            CommodityCodeDataGridViewTextBoxColumn1.HeaderText = "CommodityCode";
            CommodityCodeDataGridViewTextBoxColumn1.Name = "CommodityCodeDataGridViewTextBoxColumn1";
            CommodityCodeDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CommodityNameDataGridViewTextBoxColumn1
            // 
            CommodityNameDataGridViewTextBoxColumn1.DataPropertyName = "CommodityName";
            CommodityNameDataGridViewTextBoxColumn1.HeaderText = "CommodityName";
            CommodityNameDataGridViewTextBoxColumn1.Name = "CommodityNameDataGridViewTextBoxColumn1";
            CommodityNameDataGridViewTextBoxColumn1.Width = 17;
            // 
            // GradeCodeDataGridViewTextBoxColumn1
            // 
            GradeCodeDataGridViewTextBoxColumn1.DataPropertyName = "GradeCode";
            GradeCodeDataGridViewTextBoxColumn1.HeaderText = "GradeCode";
            GradeCodeDataGridViewTextBoxColumn1.Name = "GradeCodeDataGridViewTextBoxColumn1";
            GradeCodeDataGridViewTextBoxColumn1.Width = 17;
            // 
            // GradeNameDataGridViewTextBoxColumn1
            // 
            GradeNameDataGridViewTextBoxColumn1.DataPropertyName = "GradeName";
            GradeNameDataGridViewTextBoxColumn1.HeaderText = "GradeName";
            GradeNameDataGridViewTextBoxColumn1.Name = "GradeNameDataGridViewTextBoxColumn1";
            GradeNameDataGridViewTextBoxColumn1.Width = 17;
            // 
            // MiniUnitNumberDataGridViewTextBoxColumn
            // 
            MiniUnitNumberDataGridViewTextBoxColumn.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumberDataGridViewTextBoxColumn.HeaderText = "MiniUnitNumber";
            MiniUnitNumberDataGridViewTextBoxColumn.Name = "MiniUnitNumberDataGridViewTextBoxColumn";
            MiniUnitNumberDataGridViewTextBoxColumn.Width = 17;
            // 
            // TotalBilledMUDataGridViewTextBoxColumn
            // 
            TotalBilledMUDataGridViewTextBoxColumn.DataPropertyName = "TotalBilledMU";
            TotalBilledMUDataGridViewTextBoxColumn.HeaderText = "TotalBilledMU";
            TotalBilledMUDataGridViewTextBoxColumn.Name = "TotalBilledMUDataGridViewTextBoxColumn";
            TotalBilledMUDataGridViewTextBoxColumn.Width = 17;
            // 
            // TotalBilledUSDataGridViewTextBoxColumn
            // 
            TotalBilledUSDataGridViewTextBoxColumn.DataPropertyName = "TotalBilledUS";
            TotalBilledUSDataGridViewTextBoxColumn.HeaderText = "TotalBilledUS";
            TotalBilledUSDataGridViewTextBoxColumn.Name = "TotalBilledUSDataGridViewTextBoxColumn";
            TotalBilledUSDataGridViewTextBoxColumn.Width = 17;
            // 
            // MiniUnitIdDataGridViewTextBoxColumn2
            // 
            MiniUnitIdDataGridViewTextBoxColumn2.DataPropertyName = "MiniUnitId";
            MiniUnitIdDataGridViewTextBoxColumn2.HeaderText = "MiniUnitId";
            MiniUnitIdDataGridViewTextBoxColumn2.Name = "MiniUnitIdDataGridViewTextBoxColumn2";
            MiniUnitIdDataGridViewTextBoxColumn2.Width = 17;
            // 
            // MiniUnitOrderDataGridViewTextBoxColumn1
            // 
            MiniUnitOrderDataGridViewTextBoxColumn1.DataPropertyName = "MiniUnitOrder";
            MiniUnitOrderDataGridViewTextBoxColumn1.HeaderText = "MiniUnitOrder";
            MiniUnitOrderDataGridViewTextBoxColumn1.Name = "MiniUnitOrderDataGridViewTextBoxColumn1";
            MiniUnitOrderDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnBilledDataGridViewTextBoxColumn1
            // 
            UnBilledDataGridViewTextBoxColumn1.DataPropertyName = "UnBilled";
            UnBilledDataGridViewTextBoxColumn1.HeaderText = "UnBilled";
            UnBilledDataGridViewTextBoxColumn1.Name = "UnBilledDataGridViewTextBoxColumn1";
            UnBilledDataGridViewTextBoxColumn1.Width = 17;
            // 
            // BilledByUnitDataGridViewTextBoxColumn1
            // 
            BilledByUnitDataGridViewTextBoxColumn1.DataPropertyName = "BilledByUnit";
            BilledByUnitDataGridViewTextBoxColumn1.HeaderText = "BilledByUnit";
            BilledByUnitDataGridViewTextBoxColumn1.Name = "BilledByUnitDataGridViewTextBoxColumn1";
            BilledByUnitDataGridViewTextBoxColumn1.Width = 17;
            // 
            // BilledByUnitUnitTypeDataGridViewTextBoxColumn1
            // 
            BilledByUnitUnitTypeDataGridViewTextBoxColumn1.DataPropertyName = "BilledByUnitUnitType";
            BilledByUnitUnitTypeDataGridViewTextBoxColumn1.HeaderText = "BilledByUnitUnitType";
            BilledByUnitUnitTypeDataGridViewTextBoxColumn1.Name = "BilledByUnitUnitTypeDataGridViewTextBoxColumn1";
            BilledByUnitUnitTypeDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnBilledByUnitDataGridViewTextBoxColumn1
            // 
            UnBilledByUnitDataGridViewTextBoxColumn1.DataPropertyName = "UnBilledByUnit";
            UnBilledByUnitDataGridViewTextBoxColumn1.HeaderText = "UnBilledByUnit";
            UnBilledByUnitDataGridViewTextBoxColumn1.Name = "UnBilledByUnitDataGridViewTextBoxColumn1";
            UnBilledByUnitDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1
            // 
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1.DataPropertyName = "UnBilledByUnitUnitType";
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1.HeaderText = "UnBilledByUnitUnitType";
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1.Name = "UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1";
            UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1.Width = 17;
            // 
            // MULocationDataGridViewTextBoxColumn2
            // 
            MULocationDataGridViewTextBoxColumn2.DataPropertyName = "MULocation";
            MULocationDataGridViewTextBoxColumn2.HeaderText = "MULocation";
            MULocationDataGridViewTextBoxColumn2.Name = "MULocationDataGridViewTextBoxColumn2";
            MULocationDataGridViewTextBoxColumn2.Width = 17;
            // 
            // CommentsDataGridViewTextBoxColumn2
            // 
            CommentsDataGridViewTextBoxColumn2.DataPropertyName = "Comments";
            CommentsDataGridViewTextBoxColumn2.HeaderText = "Comments";
            CommentsDataGridViewTextBoxColumn2.Name = "CommentsDataGridViewTextBoxColumn2";
            CommentsDataGridViewTextBoxColumn2.Width = 18;
            // 
            // CustomerIdDataGridViewTextBoxColumn2
            // 
            CustomerIdDataGridViewTextBoxColumn2.DataPropertyName = "CustomerId";
            CustomerIdDataGridViewTextBoxColumn2.HeaderText = "CustomerId";
            CustomerIdDataGridViewTextBoxColumn2.Name = "CustomerIdDataGridViewTextBoxColumn2";
            CustomerIdDataGridViewTextBoxColumn2.Width = 17;
            // 
            // UnitSourceIdDataGridViewTextBoxColumn1
            // 
            UnitSourceIdDataGridViewTextBoxColumn1.DataPropertyName = "UnitSourceId";
            UnitSourceIdDataGridViewTextBoxColumn1.HeaderText = "UnitSourceId";
            UnitSourceIdDataGridViewTextBoxColumn1.Name = "UnitSourceIdDataGridViewTextBoxColumn1";
            UnitSourceIdDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnitNumberDataGridViewTextBoxColumn2
            // 
            UnitNumberDataGridViewTextBoxColumn2.DataPropertyName = "UnitNumber";
            UnitNumberDataGridViewTextBoxColumn2.HeaderText = "UnitNumber";
            UnitNumberDataGridViewTextBoxColumn2.Name = "UnitNumberDataGridViewTextBoxColumn2";
            UnitNumberDataGridViewTextBoxColumn2.Width = 17;
            // 
            // UnitStatusDataGridViewTextBoxColumn1
            // 
            UnitStatusDataGridViewTextBoxColumn1.DataPropertyName = "UnitStatus";
            UnitStatusDataGridViewTextBoxColumn1.HeaderText = "UnitStatus";
            UnitStatusDataGridViewTextBoxColumn1.Name = "UnitStatusDataGridViewTextBoxColumn1";
            UnitStatusDataGridViewTextBoxColumn1.Width = 17;
            // 
            // UnitTypeDataGridViewTextBoxColumn1
            // 
            UnitTypeDataGridViewTextBoxColumn1.DataPropertyName = "UnitType";
            UnitTypeDataGridViewTextBoxColumn1.HeaderText = "UnitType";
            UnitTypeDataGridViewTextBoxColumn1.Name = "UnitTypeDataGridViewTextBoxColumn1";
            UnitTypeDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CargoTypeDataGridViewTextBoxColumn1
            // 
            CargoTypeDataGridViewTextBoxColumn1.DataPropertyName = "CargoType";
            CargoTypeDataGridViewTextBoxColumn1.HeaderText = "CargoType";
            CargoTypeDataGridViewTextBoxColumn1.Name = "CargoTypeDataGridViewTextBoxColumn1";
            CargoTypeDataGridViewTextBoxColumn1.Width = 17;
            // 
            // OriginLocationDataGridViewTextBoxColumn1
            // 
            OriginLocationDataGridViewTextBoxColumn1.DataPropertyName = "OriginLocation";
            OriginLocationDataGridViewTextBoxColumn1.HeaderText = "OriginLocation";
            OriginLocationDataGridViewTextBoxColumn1.Name = "OriginLocationDataGridViewTextBoxColumn1";
            OriginLocationDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CarrierIdDataGridViewTextBoxColumn1
            // 
            CarrierIdDataGridViewTextBoxColumn1.DataPropertyName = "CarrierId";
            CarrierIdDataGridViewTextBoxColumn1.HeaderText = "CarrierId";
            CarrierIdDataGridViewTextBoxColumn1.Name = "CarrierIdDataGridViewTextBoxColumn1";
            CarrierIdDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ETADateDataGridViewTextBoxColumn1
            // 
            ETADateDataGridViewTextBoxColumn1.DataPropertyName = "ETADate";
            ETADateDataGridViewTextBoxColumn1.HeaderText = "ETADate";
            ETADateDataGridViewTextBoxColumn1.Name = "ETADateDataGridViewTextBoxColumn1";
            ETADateDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ETALocationDataGridViewTextBoxColumn1
            // 
            ETALocationDataGridViewTextBoxColumn1.DataPropertyName = "ETALocation";
            ETALocationDataGridViewTextBoxColumn1.HeaderText = "ETALocation";
            ETALocationDataGridViewTextBoxColumn1.Name = "ETALocationDataGridViewTextBoxColumn1";
            ETALocationDataGridViewTextBoxColumn1.Width = 17;
            // 
            // LastTracedDataGridViewTextBoxColumn1
            // 
            LastTracedDataGridViewTextBoxColumn1.DataPropertyName = "LastTraced";
            LastTracedDataGridViewTextBoxColumn1.HeaderText = "LastTraced";
            LastTracedDataGridViewTextBoxColumn1.Name = "LastTracedDataGridViewTextBoxColumn1";
            LastTracedDataGridViewTextBoxColumn1.Width = 17;
            // 
            // LastLocationDataGridViewTextBoxColumn1
            // 
            LastLocationDataGridViewTextBoxColumn1.DataPropertyName = "LastLocation";
            LastLocationDataGridViewTextBoxColumn1.HeaderText = "LastLocation";
            LastLocationDataGridViewTextBoxColumn1.Name = "LastLocationDataGridViewTextBoxColumn1";
            LastLocationDataGridViewTextBoxColumn1.Width = 17;
            // 
            // SequenceDataGridViewTextBoxColumn1
            // 
            SequenceDataGridViewTextBoxColumn1.DataPropertyName = "Sequence";
            SequenceDataGridViewTextBoxColumn1.HeaderText = "Sequence";
            SequenceDataGridViewTextBoxColumn1.Name = "SequenceDataGridViewTextBoxColumn1";
            SequenceDataGridViewTextBoxColumn1.Width = 17;
            // 
            // TrackDataGridViewTextBoxColumn1
            // 
            TrackDataGridViewTextBoxColumn1.DataPropertyName = "Track";
            TrackDataGridViewTextBoxColumn1.HeaderText = "Track";
            TrackDataGridViewTextBoxColumn1.Name = "TrackDataGridViewTextBoxColumn1";
            TrackDataGridViewTextBoxColumn1.Width = 17;
            // 
            // DemurageDaysDataGridViewTextBoxColumn1
            // 
            DemurageDaysDataGridViewTextBoxColumn1.DataPropertyName = "DemurageDays";
            DemurageDaysDataGridViewTextBoxColumn1.HeaderText = "DemurageDays";
            DemurageDaysDataGridViewTextBoxColumn1.Name = "DemurageDaysDataGridViewTextBoxColumn1";
            DemurageDaysDataGridViewTextBoxColumn1.Width = 17;
            // 
            // InTransitDaysDataGridViewTextBoxColumn1
            // 
            InTransitDaysDataGridViewTextBoxColumn1.DataPropertyName = "InTransitDays";
            InTransitDaysDataGridViewTextBoxColumn1.HeaderText = "InTransitDays";
            InTransitDaysDataGridViewTextBoxColumn1.Name = "InTransitDaysDataGridViewTextBoxColumn1";
            InTransitDaysDataGridViewTextBoxColumn1.Width = 17;
            // 
            // BillDateDataGridViewTextBoxColumn1
            // 
            BillDateDataGridViewTextBoxColumn1.DataPropertyName = "BillDate";
            BillDateDataGridViewTextBoxColumn1.HeaderText = "BillDate";
            BillDateDataGridViewTextBoxColumn1.Name = "BillDateDataGridViewTextBoxColumn1";
            BillDateDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CallDateDataGridViewTextBoxColumn1
            // 
            CallDateDataGridViewTextBoxColumn1.DataPropertyName = "CallDate";
            CallDateDataGridViewTextBoxColumn1.HeaderText = "CallDate";
            CallDateDataGridViewTextBoxColumn1.Name = "CallDateDataGridViewTextBoxColumn1";
            CallDateDataGridViewTextBoxColumn1.Width = 18;
            // 
            // ArrivalDateDataGridViewTextBoxColumn1
            // 
            ArrivalDateDataGridViewTextBoxColumn1.DataPropertyName = "ArrivalDate";
            ArrivalDateDataGridViewTextBoxColumn1.HeaderText = "ArrivalDate";
            ArrivalDateDataGridViewTextBoxColumn1.Name = "ArrivalDateDataGridViewTextBoxColumn1";
            ArrivalDateDataGridViewTextBoxColumn1.Width = 17;
            // 
            // AvailableDateDataGridViewTextBoxColumn1
            // 
            AvailableDateDataGridViewTextBoxColumn1.DataPropertyName = "AvailableDate";
            AvailableDateDataGridViewTextBoxColumn1.HeaderText = "AvailableDate";
            AvailableDateDataGridViewTextBoxColumn1.Name = "AvailableDateDataGridViewTextBoxColumn1";
            AvailableDateDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ReleaseDateDataGridViewTextBoxColumn1
            // 
            ReleaseDateDataGridViewTextBoxColumn1.DataPropertyName = "ReleaseDate";
            ReleaseDateDataGridViewTextBoxColumn1.HeaderText = "ReleaseDate";
            ReleaseDateDataGridViewTextBoxColumn1.Name = "ReleaseDateDataGridViewTextBoxColumn1";
            ReleaseDateDataGridViewTextBoxColumn1.Width = 17;
            // 
            // LastUpdateDataGridViewTextBoxColumn1
            // 
            LastUpdateDataGridViewTextBoxColumn1.DataPropertyName = "LastUpdate";
            LastUpdateDataGridViewTextBoxColumn1.HeaderText = "LastUpdate";
            LastUpdateDataGridViewTextBoxColumn1.Name = "LastUpdateDataGridViewTextBoxColumn1";
            LastUpdateDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ActiveUpdatesDataGridViewTextBoxColumn1
            // 
            ActiveUpdatesDataGridViewTextBoxColumn1.DataPropertyName = "ActiveUpdates";
            ActiveUpdatesDataGridViewTextBoxColumn1.HeaderText = "ActiveUpdates";
            ActiveUpdatesDataGridViewTextBoxColumn1.Name = "ActiveUpdatesDataGridViewTextBoxColumn1";
            ActiveUpdatesDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ActiveDataGridViewTextBoxColumn1
            // 
            ActiveDataGridViewTextBoxColumn1.DataPropertyName = "Active";
            ActiveDataGridViewTextBoxColumn1.HeaderText = "Active";
            ActiveDataGridViewTextBoxColumn1.Name = "ActiveDataGridViewTextBoxColumn1";
            ActiveDataGridViewTextBoxColumn1.Width = 17;
            // 
            // RecordKeyDataGridViewTextBoxColumn2
            // 
            RecordKeyDataGridViewTextBoxColumn2.DataPropertyName = "RecordKey";
            RecordKeyDataGridViewTextBoxColumn2.HeaderText = "RecordKey";
            RecordKeyDataGridViewTextBoxColumn2.Name = "RecordKeyDataGridViewTextBoxColumn2";
            RecordKeyDataGridViewTextBoxColumn2.Width = 17;
            // 
            // CargoDescriptionDataGridViewTextBoxColumn1
            // 
            CargoDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "CargoDescription";
            CargoDescriptionDataGridViewTextBoxColumn1.HeaderText = "CargoDescription";
            CargoDescriptionDataGridViewTextBoxColumn1.Name = "CargoDescriptionDataGridViewTextBoxColumn1";
            CargoDescriptionDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CarReleasedDataGridViewTextBoxColumn1
            // 
            CarReleasedDataGridViewTextBoxColumn1.DataPropertyName = "CarReleased";
            CarReleasedDataGridViewTextBoxColumn1.HeaderText = "CarReleased";
            CarReleasedDataGridViewTextBoxColumn1.Name = "CarReleasedDataGridViewTextBoxColumn1";
            CarReleasedDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CarAvailableDataGridViewTextBoxColumn1
            // 
            CarAvailableDataGridViewTextBoxColumn1.DataPropertyName = "CarAvailable";
            CarAvailableDataGridViewTextBoxColumn1.HeaderText = "CarAvailable";
            CarAvailableDataGridViewTextBoxColumn1.Name = "CarAvailableDataGridViewTextBoxColumn1";
            CarAvailableDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CarArrivedDataGridViewTextBoxColumn1
            // 
            CarArrivedDataGridViewTextBoxColumn1.DataPropertyName = "CarArrived";
            CarArrivedDataGridViewTextBoxColumn1.HeaderText = "CarArrived";
            CarArrivedDataGridViewTextBoxColumn1.Name = "CarArrivedDataGridViewTextBoxColumn1";
            CarArrivedDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CarCalledDataGridViewTextBoxColumn1
            // 
            CarCalledDataGridViewTextBoxColumn1.DataPropertyName = "CarCalled";
            CarCalledDataGridViewTextBoxColumn1.HeaderText = "CarCalled";
            CarCalledDataGridViewTextBoxColumn1.Name = "CarCalledDataGridViewTextBoxColumn1";
            CarCalledDataGridViewTextBoxColumn1.Width = 17;
            // 
            // ShipperIdDataGridViewTextBoxColumn2
            // 
            ShipperIdDataGridViewTextBoxColumn2.DataPropertyName = "ShipperId";
            ShipperIdDataGridViewTextBoxColumn2.HeaderText = "ShipperId";
            ShipperIdDataGridViewTextBoxColumn2.Name = "ShipperIdDataGridViewTextBoxColumn2";
            ShipperIdDataGridViewTextBoxColumn2.Width = 17;
            // 
            // GradeIdDataGridViewTextBoxColumn1
            // 
            GradeIdDataGridViewTextBoxColumn1.DataPropertyName = "GradeId";
            GradeIdDataGridViewTextBoxColumn1.HeaderText = "GradeId";
            GradeIdDataGridViewTextBoxColumn1.Name = "GradeIdDataGridViewTextBoxColumn1";
            GradeIdDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CommodityIdDataGridViewTextBoxColumn1
            // 
            CommodityIdDataGridViewTextBoxColumn1.DataPropertyName = "CommodityId";
            CommodityIdDataGridViewTextBoxColumn1.HeaderText = "CommodityId";
            CommodityIdDataGridViewTextBoxColumn1.Name = "CommodityIdDataGridViewTextBoxColumn1";
            CommodityIdDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CustomerNameDataGridViewTextBoxColumn2
            // 
            CustomerNameDataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn2.HeaderText = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn2.Name = "CustomerNameDataGridViewTextBoxColumn2";
            CustomerNameDataGridViewTextBoxColumn2.Width = 17;
            // 
            // ShipperCodeDataGridViewTextBoxColumn1
            // 
            ShipperCodeDataGridViewTextBoxColumn1.DataPropertyName = "ShipperCode";
            ShipperCodeDataGridViewTextBoxColumn1.HeaderText = "ShipperCode";
            ShipperCodeDataGridViewTextBoxColumn1.Name = "ShipperCodeDataGridViewTextBoxColumn1";
            ShipperCodeDataGridViewTextBoxColumn1.Width = 18;
            // 
            // ShipperNameDataGridViewTextBoxColumn1
            // 
            ShipperNameDataGridViewTextBoxColumn1.DataPropertyName = "ShipperName";
            ShipperNameDataGridViewTextBoxColumn1.HeaderText = "ShipperName";
            ShipperNameDataGridViewTextBoxColumn1.Name = "ShipperNameDataGridViewTextBoxColumn1";
            ShipperNameDataGridViewTextBoxColumn1.Width = 17;
            // 
            // CommodityCodeDataGridViewTextBoxColumn2
            // 
            CommodityCodeDataGridViewTextBoxColumn2.DataPropertyName = "CommodityCode";
            CommodityCodeDataGridViewTextBoxColumn2.HeaderText = "CommodityCode";
            CommodityCodeDataGridViewTextBoxColumn2.Name = "CommodityCodeDataGridViewTextBoxColumn2";
            CommodityCodeDataGridViewTextBoxColumn2.Width = 17;
            // 
            // CommodityNameDataGridViewTextBoxColumn2
            // 
            CommodityNameDataGridViewTextBoxColumn2.DataPropertyName = "CommodityName";
            CommodityNameDataGridViewTextBoxColumn2.HeaderText = "CommodityName";
            CommodityNameDataGridViewTextBoxColumn2.Name = "CommodityNameDataGridViewTextBoxColumn2";
            CommodityNameDataGridViewTextBoxColumn2.Width = 17;
            // 
            // GradeCodeDataGridViewTextBoxColumn2
            // 
            GradeCodeDataGridViewTextBoxColumn2.DataPropertyName = "GradeCode";
            GradeCodeDataGridViewTextBoxColumn2.HeaderText = "GradeCode";
            GradeCodeDataGridViewTextBoxColumn2.Name = "GradeCodeDataGridViewTextBoxColumn2";
            GradeCodeDataGridViewTextBoxColumn2.Width = 17;
            // 
            // GradeNameDataGridViewTextBoxColumn2
            // 
            GradeNameDataGridViewTextBoxColumn2.DataPropertyName = "GradeName";
            GradeNameDataGridViewTextBoxColumn2.HeaderText = "GradeName";
            GradeNameDataGridViewTextBoxColumn2.Name = "GradeNameDataGridViewTextBoxColumn2";
            GradeNameDataGridViewTextBoxColumn2.Width = 17;
            // 
            // MiniUnitNumberDataGridViewTextBoxColumn1
            // 
            MiniUnitNumberDataGridViewTextBoxColumn1.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumberDataGridViewTextBoxColumn1.HeaderText = "MiniUnitNumber";
            MiniUnitNumberDataGridViewTextBoxColumn1.Name = "MiniUnitNumberDataGridViewTextBoxColumn1";
            MiniUnitNumberDataGridViewTextBoxColumn1.Width = 17;
            // 
            // TotalBilledMUDataGridViewTextBoxColumn1
            // 
            TotalBilledMUDataGridViewTextBoxColumn1.DataPropertyName = "TotalBilledMU";
            TotalBilledMUDataGridViewTextBoxColumn1.HeaderText = "TotalBilledMU";
            TotalBilledMUDataGridViewTextBoxColumn1.Name = "TotalBilledMUDataGridViewTextBoxColumn1";
            TotalBilledMUDataGridViewTextBoxColumn1.Width = 17;
            // 
            // TotalBilledUSDataGridViewTextBoxColumn1
            // 
            TotalBilledUSDataGridViewTextBoxColumn1.DataPropertyName = "TotalBilledUS";
            TotalBilledUSDataGridViewTextBoxColumn1.HeaderText = "TotalBilledUS";
            TotalBilledUSDataGridViewTextBoxColumn1.Name = "TotalBilledUSDataGridViewTextBoxColumn1";
            TotalBilledUSDataGridViewTextBoxColumn1.Width = 17;
            // 
            // dgvMiniUnits
            // 
            _dgvMiniUnits.AllowCustomTheming = true;
            _dgvMiniUnits.AllowUserToAddRows = false;
            _dgvMiniUnits.AllowUserToDeleteRows = false;
            _dgvMiniUnits.AllowUserToOrderColumns = true;
            _dgvMiniUnits.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(248)), Conversions.ToInteger(Conversions.ToByte(251)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle7.ForeColor = Color.Black;
            DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            _dgvMiniUnits.AutoGenerateColumns = false;
            _dgvMiniUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvMiniUnits.BackgroundColor = Color.White;
            _dgvMiniUnits.BorderStyle = BorderStyle.None;
            _dgvMiniUnits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvMiniUnits.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvMiniUnits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle8.BackColor = Color.Gray;
            DataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle8.ForeColor = Color.White;
            DataGridViewCellStyle8.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _dgvMiniUnits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _dgvMiniUnits.ColumnHeadersHeight = 40;
            _dgvMiniUnits.Columns.AddRange(new DataGridViewColumn[] { Column2, DataGridViewTextBoxColumn3, CargoType, UnitTypeDataGridViewTextBoxColumn2, TotalBilled, CommodityGrade });
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(248)), Conversions.ToInteger(Conversions.ToByte(251)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvMiniUnits.CurrentTheme.BackColor = Color.White;
            _dgvMiniUnits.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(221)), Conversions.ToInteger(Conversions.ToByte(238)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvMiniUnits.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            _dgvMiniUnits.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvMiniUnits.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvMiniUnits.CurrentTheme.Name = null;
            _dgvMiniUnits.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvMiniUnits.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniUnits.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvMiniUnits.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvMiniUnits.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvMiniUnits.DataSource = VWUnitSourceMiniUnitBindingSource;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.White;
            DataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle9.ForeColor = Color.Black;
            DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle9.SelectionForeColor = Color.Black;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            _dgvMiniUnits.DefaultCellStyle = DataGridViewCellStyle9;
            _dgvMiniUnits.Dock = DockStyle.Bottom;
            _dgvMiniUnits.EnableHeadersVisualStyles = false;
            _dgvMiniUnits.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(221)), Conversions.ToInteger(Conversions.ToByte(238)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvMiniUnits.HeaderBackColor = Color.Gray;
            _dgvMiniUnits.HeaderBgColor = Color.Empty;
            _dgvMiniUnits.HeaderForeColor = Color.White;
            _dgvMiniUnits.Location = new Point(0, 37);
            _dgvMiniUnits.MultiSelect = false;
            _dgvMiniUnits.Name = "_dgvMiniUnits";
            _dgvMiniUnits.ReadOnly = true;
            _dgvMiniUnits.RowHeadersVisible = false;
            _dgvMiniUnits.RowHeadersWidth = 51;
            _dgvMiniUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            _dgvMiniUnits.RowTemplate.Height = 30;
            _dgvMiniUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvMiniUnits.Size = new Size(897, 449);
            _dgvMiniUnits.TabIndex = 57;
            _dgvMiniUnits.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column2
            // 
            Column2.FillWeight = 28.33302f;
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "MiniunitNumber";
            DataGridViewTextBoxColumn3.HeaderText = "Unit Number";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // CargoType
            // 
            CargoType.DataPropertyName = "CargoType";
            CargoType.HeaderText = "Cargo Type";
            CargoType.Name = "CargoType";
            CargoType.ReadOnly = true;
            // 
            // UnitTypeDataGridViewTextBoxColumn2
            // 
            UnitTypeDataGridViewTextBoxColumn2.DataPropertyName = "UnitType";
            UnitTypeDataGridViewTextBoxColumn2.FillWeight = 98.89507f;
            UnitTypeDataGridViewTextBoxColumn2.HeaderText = "Type";
            UnitTypeDataGridViewTextBoxColumn2.Name = "UnitTypeDataGridViewTextBoxColumn2";
            UnitTypeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TotalBilled
            // 
            TotalBilled.DataPropertyName = "TotalBilled";
            TotalBilled.HeaderText = "Quantity";
            TotalBilled.Name = "TotalBilled";
            TotalBilled.ReadOnly = true;
            // 
            // CommodityGrade
            // 
            CommodityGrade.DataPropertyName = "CommodityGrade";
            CommodityGrade.FillWeight = 98.89507f;
            CommodityGrade.HeaderText = "Commodity";
            CommodityGrade.Name = "CommodityGrade";
            CommodityGrade.ReadOnly = true;
            // 
            // VWUnitSourceMiniUnitBindingSource
            // 
            VWUnitSourceMiniUnitBindingSource.DataSource = typeof(ModelLayer.VW_UnitSourceMiniUnit);
            // 
            // Column5
            // 
            Column5.FillWeight = 26.30957f;
            Column5.HeaderText = "";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // ShipperIdDataGridViewTextBoxColumn1
            // 
            ShipperIdDataGridViewTextBoxColumn1.DataPropertyName = "CargoType";
            ShipperIdDataGridViewTextBoxColumn1.HeaderText = "Cargo Type";
            ShipperIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ShipperIdDataGridViewTextBoxColumn1.Name = "ShipperIdDataGridViewTextBoxColumn1";
            ShipperIdDataGridViewTextBoxColumn1.ReadOnly = true;
            ShipperIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // RecordKeyDataGridViewTextBoxColumn
            // 
            RecordKeyDataGridViewTextBoxColumn.DataPropertyName = "RecordKey";
            RecordKeyDataGridViewTextBoxColumn.HeaderText = "RailListId";
            RecordKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            RecordKeyDataGridViewTextBoxColumn.Name = "RecordKeyDataGridViewTextBoxColumn";
            RecordKeyDataGridViewTextBoxColumn.ReadOnly = true;
            RecordKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // CustomerIdDataGridViewTextBoxColumn
            // 
            CustomerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            CustomerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            CustomerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            CustomerIdDataGridViewTextBoxColumn.Name = "CustomerIdDataGridViewTextBoxColumn";
            CustomerIdDataGridViewTextBoxColumn.ReadOnly = true;
            CustomerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // GradeCodeDataGridViewTextBoxColumn
            // 
            GradeCodeDataGridViewTextBoxColumn.DataPropertyName = "GradeCode";
            GradeCodeDataGridViewTextBoxColumn.HeaderText = "GradeCode";
            GradeCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            GradeCodeDataGridViewTextBoxColumn.Name = "GradeCodeDataGridViewTextBoxColumn";
            GradeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            GradeCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // CommodityCodeDataGridViewTextBoxColumn
            // 
            CommodityCodeDataGridViewTextBoxColumn.DataPropertyName = "CommodityCode";
            CommodityCodeDataGridViewTextBoxColumn.HeaderText = "CommodityCode";
            CommodityCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            CommodityCodeDataGridViewTextBoxColumn.Name = "CommodityCodeDataGridViewTextBoxColumn";
            CommodityCodeDataGridViewTextBoxColumn.ReadOnly = true;
            CommodityCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // CommentsDataGridViewTextBoxColumn
            // 
            CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            CommentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            CommentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn";
            CommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MULocationDataGridViewTextBoxColumn
            // 
            MULocationDataGridViewTextBoxColumn.DataPropertyName = "MULocation";
            MULocationDataGridViewTextBoxColumn.HeaderText = "MULocation";
            MULocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            MULocationDataGridViewTextBoxColumn.Name = "MULocationDataGridViewTextBoxColumn";
            MULocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GradeNameDataGridViewTextBoxColumn
            // 
            GradeNameDataGridViewTextBoxColumn.DataPropertyName = "GradeName";
            GradeNameDataGridViewTextBoxColumn.HeaderText = "Grade";
            GradeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            GradeNameDataGridViewTextBoxColumn.Name = "GradeNameDataGridViewTextBoxColumn";
            GradeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CommodityNameDataGridViewTextBoxColumn
            // 
            CommodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
            CommodityNameDataGridViewTextBoxColumn.HeaderText = "Commodity";
            CommodityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            CommodityNameDataGridViewTextBoxColumn.Name = "CommodityNameDataGridViewTextBoxColumn";
            CommodityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerNameDataGridViewTextBoxColumn
            // 
            CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer";
            CustomerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn";
            CustomerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UnitNumberDataGridViewTextBoxColumn
            // 
            UnitNumberDataGridViewTextBoxColumn.DataPropertyName = "UnitNumber";
            UnitNumberDataGridViewTextBoxColumn.HeaderText = "Unit Number";
            UnitNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            UnitNumberDataGridViewTextBoxColumn.Name = "UnitNumberDataGridViewTextBoxColumn";
            UnitNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MiniUnitIdDataGridViewTextBoxColumn
            // 
            MiniUnitIdDataGridViewTextBoxColumn.DataPropertyName = "MiniUnitId";
            MiniUnitIdDataGridViewTextBoxColumn.HeaderText = "MiniUnitId";
            MiniUnitIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            MiniUnitIdDataGridViewTextBoxColumn.Name = "MiniUnitIdDataGridViewTextBoxColumn";
            MiniUnitIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BunifuDataGridView1
            // 
            BunifuDataGridView1.AllowCustomTheming = true;
            BunifuDataGridView1.AllowUserToAddRows = false;
            BunifuDataGridView1.AllowUserToDeleteRows = false;
            BunifuDataGridView1.AllowUserToOrderColumns = true;
            BunifuDataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle10.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(248)), Conversions.ToInteger(Conversions.ToByte(251)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle10.ForeColor = Color.Black;
            DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10;
            BunifuDataGridView1.AutoGenerateColumns = false;
            BunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BunifuDataGridView1.BackgroundColor = Color.White;
            BunifuDataGridView1.BorderStyle = BorderStyle.None;
            BunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BunifuDataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            BunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = Color.Gray;
            DataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle11.ForeColor = Color.White;
            DataGridViewCellStyle11.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11;
            BunifuDataGridView1.ColumnHeadersHeight = 30;
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(248)), Conversions.ToInteger(Conversions.ToByte(251)), Conversions.ToInteger(Conversions.ToByte(255)));
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            BunifuDataGridView1.CurrentTheme.BackColor = Color.White;
            BunifuDataGridView1.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(221)), Conversions.ToInteger(Conversions.ToByte(238)), Conversions.ToInteger(Conversions.ToByte(255)));
            BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            BunifuDataGridView1.CurrentTheme.Name = null;
            BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.White;
            BunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            BunifuDataGridView1.DataSource = VWUnitSourceMiniUnitBindingSource;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.White;
            DataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle12.ForeColor = Color.Black;
            DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle12.SelectionForeColor = Color.Black;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle12;
            BunifuDataGridView1.Dock = DockStyle.Fill;
            BunifuDataGridView1.EnableHeadersVisualStyles = false;
            BunifuDataGridView1.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(221)), Conversions.ToInteger(Conversions.ToByte(238)), Conversions.ToInteger(Conversions.ToByte(255)));
            BunifuDataGridView1.HeaderBackColor = Color.Gray;
            BunifuDataGridView1.HeaderBgColor = Color.Empty;
            BunifuDataGridView1.HeaderForeColor = Color.White;
            BunifuDataGridView1.Location = new Point(0, 0);
            BunifuDataGridView1.MultiSelect = false;
            BunifuDataGridView1.Name = "BunifuDataGridView1";
            BunifuDataGridView1.ReadOnly = true;
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle13.BackColor = SystemColors.Control;
            DataGridViewCellStyle13.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            BunifuDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle13;
            BunifuDataGridView1.RowHeadersVisible = false;
            BunifuDataGridView1.RowHeadersWidth = 51;
            BunifuDataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            BunifuDataGridView1.RowTemplate.Height = 30;
            BunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BunifuDataGridView1.Size = new Size(887, 472);
            BunifuDataGridView1.TabIndex = 58;
            BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            DataGridViewCheckBoxColumn1.FillWeight = 26.30957f;
            DataGridViewCheckBoxColumn1.HeaderText = "";
            DataGridViewCheckBoxColumn1.MinimumWidth = 6;
            DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            DataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn16
            // 
            DataGridViewTextBoxColumn16.DataPropertyName = "CargoType";
            DataGridViewTextBoxColumn16.HeaderText = "Cargo Type";
            DataGridViewTextBoxColumn16.MinimumWidth = 6;
            DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            DataGridViewTextBoxColumn16.ReadOnly = true;
            DataGridViewTextBoxColumn16.Visible = false;
            // 
            // DataGridViewTextBoxColumn15
            // 
            DataGridViewTextBoxColumn15.DataPropertyName = "RecordKey";
            DataGridViewTextBoxColumn15.HeaderText = "RailListId";
            DataGridViewTextBoxColumn15.MinimumWidth = 6;
            DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            DataGridViewTextBoxColumn15.ReadOnly = true;
            DataGridViewTextBoxColumn15.Visible = false;
            // 
            // DataGridViewTextBoxColumn13
            // 
            DataGridViewTextBoxColumn13.DataPropertyName = "CustomerId";
            DataGridViewTextBoxColumn13.HeaderText = "CustomerId";
            DataGridViewTextBoxColumn13.MinimumWidth = 6;
            DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            DataGridViewTextBoxColumn13.ReadOnly = true;
            DataGridViewTextBoxColumn13.Visible = false;
            // 
            // DataGridViewTextBoxColumn12
            // 
            DataGridViewTextBoxColumn12.DataPropertyName = "GradeCode";
            DataGridViewTextBoxColumn12.HeaderText = "GradeCode";
            DataGridViewTextBoxColumn12.MinimumWidth = 6;
            DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            DataGridViewTextBoxColumn12.ReadOnly = true;
            DataGridViewTextBoxColumn12.Visible = false;
            // 
            // DataGridViewTextBoxColumn11
            // 
            DataGridViewTextBoxColumn11.DataPropertyName = "CommodityCode";
            DataGridViewTextBoxColumn11.HeaderText = "CommodityCode";
            DataGridViewTextBoxColumn11.MinimumWidth = 6;
            DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            DataGridViewTextBoxColumn11.ReadOnly = true;
            DataGridViewTextBoxColumn11.Visible = false;
            // 
            // DataGridViewTextBoxColumn10
            // 
            DataGridViewTextBoxColumn10.DataPropertyName = "Comments";
            DataGridViewTextBoxColumn10.HeaderText = "Comments";
            DataGridViewTextBoxColumn10.MinimumWidth = 6;
            DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            DataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn9
            // 
            DataGridViewTextBoxColumn9.DataPropertyName = "MULocation";
            DataGridViewTextBoxColumn9.HeaderText = "MULocation";
            DataGridViewTextBoxColumn9.MinimumWidth = 6;
            DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            DataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "GradeName";
            DataGridViewTextBoxColumn8.HeaderText = "Grade";
            DataGridViewTextBoxColumn8.MinimumWidth = 6;
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "CommodityName";
            DataGridViewTextBoxColumn7.HeaderText = "Commodity";
            DataGridViewTextBoxColumn7.MinimumWidth = 6;
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "CustomerName";
            DataGridViewTextBoxColumn6.HeaderText = "Customer";
            DataGridViewTextBoxColumn6.MinimumWidth = 6;
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "UnitNumber";
            DataGridViewTextBoxColumn5.HeaderText = "Unit Number";
            DataGridViewTextBoxColumn5.MinimumWidth = 6;
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "MiniUnitId";
            DataGridViewTextBoxColumn1.HeaderText = "MiniUnitId";
            DataGridViewTextBoxColumn1.MinimumWidth = 6;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ShapedPanel2
            // 
            ShapedPanel2.BackColor = SystemColors.ControlLight;
            ShapedPanel2.BorderColor = Color.Gray;
            ShapedPanel2.Controls.Add(ShapedPanel1);
            ShapedPanel2.Edge = 15;
            ShapedPanel2.Location = new Point(26, 154);
            ShapedPanel2.Name = "ShapedPanel2";
            ShapedPanel2.Padding = new Padding(1);
            ShapedPanel2.Size = new Size(907, 523);
            ShapedPanel2.TabIndex = 193;
            // 
            // ShapedPanel1
            // 
            ShapedPanel1.BorderColor = Color.White;
            ShapedPanel1.Controls.Add(tabUnits);
            ShapedPanel1.Dock = DockStyle.Fill;
            ShapedPanel1.Edge = 15;
            ShapedPanel1.Location = new Point(1, 1);
            ShapedPanel1.Margin = new Padding(0);
            ShapedPanel1.Name = "ShapedPanel1";
            ShapedPanel1.Size = new Size(905, 521);
            ShapedPanel1.TabIndex = 90;
            // 
            // tabUnits
            // 
            tabUnits.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab;
            tabUnits.BackColor = Color.Gray;
            tabUnits.Controls.Add(loadingTabPage);
            tabUnits.Controls.Add(TabPageEX2);
            tabUnits.Dock = DockStyle.Fill;
            tabUnits.FlatBorderColor = Color.Gray;
            tabUnits.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tabUnits.ForeColor = Color.White;
            tabUnits.Location = new Point(0, 0);
            tabUnits.Margin = new Padding(0);
            tabUnits.Name = "tabUnits";
            tabUnits.Padding = new Point(20, 6);
            tabUnits.SelectedIndex = 0;
            tabUnits.SelectedTabColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            tabUnits.Size = new Size(905, 521);
            tabUnits.TabColor = Color.Gray;
            tabUnits.TabIndex = 2;
            tabUnits.UseVisualStyles = false;
            // 
            // loadingTabPage
            // 
            loadingTabPage.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            loadingTabPage.Controls.Add(TableLayoutPanel2);
            loadingTabPage.Controls.Add(_dgvMiniUnits);
            loadingTabPage.Controls.Add(_tbSearchUnits);
            loadingTabPage.Location = new Point(4, 31);
            loadingTabPage.Name = "loadingTabPage";
            loadingTabPage.Padding = new Padding(0, 4, 0, 0);
            loadingTabPage.Size = new Size(897, 486);
            loadingTabPage.TabIndex = 1;
            loadingTabPage.Text = "From Unit Source";
            // 
            // TabPageEX2
            // 
            TabPageEX2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TabPageEX2.Controls.Add(_tbSearchStorageUnit);
            TabPageEX2.Controls.Add(_dgvStorageUnits);
            TabPageEX2.Location = new Point(4, 31);
            TabPageEX2.Name = "TabPageEX2";
            TabPageEX2.Padding = new Padding(0, 4, 0, 0);
            TabPageEX2.Size = new Size(897, 486);
            TabPageEX2.TabIndex = 2;
            TabPageEX2.Text = "From Storage";
            // 
            // tbSearchStorageUnit
            // 
            _tbSearchStorageUnit.AcceptsReturn = false;
            _tbSearchStorageUnit.AcceptsTab = false;
            _tbSearchStorageUnit.AnimationSpeed = 200;
            _tbSearchStorageUnit.AutoCompleteMode = AutoCompleteMode.None;
            _tbSearchStorageUnit.AutoCompleteSource = AutoCompleteSource.None;
            _tbSearchStorageUnit.BackColor = Color.Transparent;
            _tbSearchStorageUnit.BackgroundImage = (Image)resources.GetObject("tbSearchStorageUnit.BackgroundImage");
            _tbSearchStorageUnit.BorderColorActive = Color.DodgerBlue;
            _tbSearchStorageUnit.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbSearchStorageUnit.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbSearchStorageUnit.BorderColorIdle = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            _tbSearchStorageUnit.BorderRadius = 1;
            _tbSearchStorageUnit.BorderThickness = 1;
            _tbSearchStorageUnit.CharacterCasing = CharacterCasing.Normal;
            _tbSearchStorageUnit.Cursor = Cursors.IBeam;
            _tbSearchStorageUnit.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _tbSearchStorageUnit.DefaultText = "";
            _tbSearchStorageUnit.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbSearchStorageUnit.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _tbSearchStorageUnit.HideSelection = true;
            _tbSearchStorageUnit.IconLeft = null;
            _tbSearchStorageUnit.IconLeftCursor = Cursors.IBeam;
            _tbSearchStorageUnit.IconPadding = 10;
            _tbSearchStorageUnit.IconRight = null;
            _tbSearchStorageUnit.IconRightCursor = Cursors.IBeam;
            _tbSearchStorageUnit.Lines = new string[0];
            _tbSearchStorageUnit.Location = new Point(606, 4);
            _tbSearchStorageUnit.MaxLength = 32767;
            _tbSearchStorageUnit.MinimumSize = new Size(100, 30);
            _tbSearchStorageUnit.Modified = false;
            _tbSearchStorageUnit.Multiline = false;
            _tbSearchStorageUnit.Name = "_tbSearchStorageUnit";
            StateProperties23.BorderColor = Color.DodgerBlue;
            StateProperties23.FillColor = Color.Empty;
            StateProperties23.ForeColor = Color.Empty;
            StateProperties23.PlaceholderForeColor = Color.Empty;
            _tbSearchStorageUnit.OnActiveState = StateProperties23;
            StateProperties24.BorderColor = Color.Empty;
            StateProperties24.FillColor = Color.White;
            StateProperties24.ForeColor = Color.Empty;
            StateProperties24.PlaceholderForeColor = Color.Silver;
            _tbSearchStorageUnit.OnDisabledState = StateProperties24;
            StateProperties25.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties25.FillColor = Color.Empty;
            StateProperties25.ForeColor = Color.Empty;
            StateProperties25.PlaceholderForeColor = Color.Empty;
            _tbSearchStorageUnit.OnHoverState = StateProperties25;
            StateProperties26.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties26.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties26.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties26.PlaceholderForeColor = Color.Empty;
            _tbSearchStorageUnit.OnIdleState = StateProperties26;
            _tbSearchStorageUnit.PasswordChar = '\0';
            _tbSearchStorageUnit.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            _tbSearchStorageUnit.PlaceholderText = "Search unit source...";
            _tbSearchStorageUnit.ReadOnly = false;
            _tbSearchStorageUnit.ScrollBars = ScrollBars.None;
            _tbSearchStorageUnit.SelectedText = "";
            _tbSearchStorageUnit.SelectionLength = 0;
            _tbSearchStorageUnit.SelectionStart = 0;
            _tbSearchStorageUnit.ShortcutsEnabled = true;
            _tbSearchStorageUnit.Size = new Size(257, 30);
            _tbSearchStorageUnit.Style = _Style.Bunifu;
            _tbSearchStorageUnit.TabIndex = 183;
            _tbSearchStorageUnit.TextAlign = HorizontalAlignment.Left;
            _tbSearchStorageUnit.TextMarginBottom = 0;
            _tbSearchStorageUnit.TextMarginLeft = 5;
            _tbSearchStorageUnit.TextMarginTop = 0;
            _tbSearchStorageUnit.TextPlaceholder = "Search unit source...";
            _tbSearchStorageUnit.UseSystemPasswordChar = false;
            _tbSearchStorageUnit.WordWrap = true;
            // 
            // dgvStorageUnits
            // 
            _dgvStorageUnits.AllowCustomTheming = true;
            _dgvStorageUnits.AllowUserToAddRows = false;
            _dgvStorageUnits.AllowUserToDeleteRows = false;
            _dgvStorageUnits.AllowUserToOrderColumns = true;
            _dgvStorageUnits.AllowUserToResizeRows = false;
            DataGridViewCellStyle14.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(248)), Conversions.ToInteger(Conversions.ToByte(251)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle14.ForeColor = Color.Black;
            DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvStorageUnits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14;
            _dgvStorageUnits.AutoGenerateColumns = false;
            _dgvStorageUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvStorageUnits.BackgroundColor = Color.White;
            _dgvStorageUnits.BorderStyle = BorderStyle.None;
            _dgvStorageUnits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvStorageUnits.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvStorageUnits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle15.BackColor = Color.Gray;
            DataGridViewCellStyle15.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle15.ForeColor = Color.White;
            DataGridViewCellStyle15.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            _dgvStorageUnits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15;
            _dgvStorageUnits.ColumnHeadersHeight = 30;
            _dgvStorageUnits.Columns.AddRange(new DataGridViewColumn[] { Column1, StorageLocation, MiniUnitNumber, DataGridViewTextBoxColumn2, RemainingQuantityDataGridViewTextBoxColumn, GradeCommodityCode, StorageDate });
            _dgvStorageUnits.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(248)), Conversions.ToInteger(Conversions.ToByte(251)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvStorageUnits.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvStorageUnits.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvStorageUnits.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvStorageUnits.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvStorageUnits.CurrentTheme.BackColor = Color.White;
            _dgvStorageUnits.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(221)), Conversions.ToInteger(Conversions.ToByte(238)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvStorageUnits.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            _dgvStorageUnits.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvStorageUnits.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvStorageUnits.CurrentTheme.Name = null;
            _dgvStorageUnits.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvStorageUnits.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvStorageUnits.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvStorageUnits.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvStorageUnits.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvStorageUnits.DataSource = VWGrainUnitStorageBindingSource;
            DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle16.BackColor = Color.White;
            DataGridViewCellStyle16.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle16.ForeColor = Color.Black;
            DataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(232)), Conversions.ToInteger(Conversions.ToByte(255)));
            DataGridViewCellStyle16.SelectionForeColor = Color.Black;
            DataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            _dgvStorageUnits.DefaultCellStyle = DataGridViewCellStyle16;
            _dgvStorageUnits.Dock = DockStyle.Bottom;
            _dgvStorageUnits.EnableHeadersVisualStyles = false;
            _dgvStorageUnits.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(221)), Conversions.ToInteger(Conversions.ToByte(238)), Conversions.ToInteger(Conversions.ToByte(255)));
            _dgvStorageUnits.HeaderBackColor = Color.Gray;
            _dgvStorageUnits.HeaderBgColor = Color.Empty;
            _dgvStorageUnits.HeaderForeColor = Color.White;
            _dgvStorageUnits.Location = new Point(0, 39);
            _dgvStorageUnits.MultiSelect = false;
            _dgvStorageUnits.Name = "_dgvStorageUnits";
            _dgvStorageUnits.ReadOnly = true;
            _dgvStorageUnits.RowHeadersVisible = false;
            _dgvStorageUnits.RowHeadersWidth = 51;
            _dgvStorageUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            _dgvStorageUnits.RowTemplate.Height = 30;
            _dgvStorageUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvStorageUnits.Size = new Size(897, 447);
            _dgvStorageUnits.TabIndex = 58;
            _dgvStorageUnits.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.FillWeight = 19.44693f;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // StorageLocation
            // 
            StorageLocation.DataPropertyName = "StorageLocation";
            StorageLocation.FillWeight = 90.8853f;
            StorageLocation.HeaderText = "Storage Name";
            StorageLocation.Name = "StorageLocation";
            StorageLocation.ReadOnly = true;
            // 
            // MiniUnitNumber
            // 
            MiniUnitNumber.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumber.FillWeight = 115.2507f;
            MiniUnitNumber.HeaderText = "Original Unit Source";
            MiniUnitNumber.Name = "MiniUnitNumber";
            MiniUnitNumber.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "CargoType";
            DataGridViewTextBoxColumn2.HeaderText = "Cargo Type";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // RemainingQuantityDataGridViewTextBoxColumn
            // 
            RemainingQuantityDataGridViewTextBoxColumn.DataPropertyName = "RemainingQuantity";
            RemainingQuantityDataGridViewTextBoxColumn.FillWeight = 55.28852f;
            RemainingQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            RemainingQuantityDataGridViewTextBoxColumn.Name = "RemainingQuantityDataGridViewTextBoxColumn";
            RemainingQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GradeCommodityCode
            // 
            GradeCommodityCode.DataPropertyName = "GradeCommodityCode";
            GradeCommodityCode.FillWeight = 73.52469f;
            GradeCommodityCode.HeaderText = "Commodity";
            GradeCommodityCode.Name = "GradeCommodityCode";
            GradeCommodityCode.ReadOnly = true;
            // 
            // StorageDate
            // 
            StorageDate.DataPropertyName = "StorageDate";
            StorageDate.HeaderText = "Storage Date";
            StorageDate.Name = "StorageDate";
            StorageDate.ReadOnly = true;
            // 
            // VWGrainUnitStorageBindingSource
            // 
            VWGrainUnitStorageBindingSource.DataSource = typeof(ModelLayer.VW_GrainUnitStorage);
            // 
            // Timer1
            // 
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.BackColor = Color.Gray;
            TableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            TableLayoutPanel2.ColumnCount = 4;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.14749f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.85251f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165.0f));
            TableLayoutPanel2.Controls.Add(_tbCargoType, 0, 0);
            TableLayoutPanel2.Controls.Add(_tbType, 1, 0);
            TableLayoutPanel2.Controls.Add(tbCommodity, 3, 0);
            TableLayoutPanel2.Location = new Point(220, 60);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel2.Size = new Size(674, 17);
            TableLayoutPanel2.TabIndex = 194;
            // 
            // tbCargoType
            // 
            _tbCargoType.AcceptsReturn = false;
            _tbCargoType.AcceptsTab = false;
            _tbCargoType.AnimationSpeed = 200;
            _tbCargoType.AutoCompleteMode = AutoCompleteMode.None;
            _tbCargoType.AutoCompleteSource = AutoCompleteSource.None;
            _tbCargoType.BackColor = Color.Transparent;
            _tbCargoType.BackgroundImage = (Image)resources.GetObject("tbCargoType.BackgroundImage");
            _tbCargoType.BorderColorActive = Color.DodgerBlue;
            _tbCargoType.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbCargoType.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbCargoType.BorderColorIdle = Color.Transparent;
            _tbCargoType.BorderRadius = 2;
            _tbCargoType.BorderThickness = 0;
            _tbCargoType.CharacterCasing = CharacterCasing.Upper;
            _tbCargoType.Cursor = Cursors.IBeam;
            _tbCargoType.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _tbCargoType.DefaultText = "";
            _tbCargoType.Dock = DockStyle.Fill;
            _tbCargoType.FillColor = Color.White;
            _tbCargoType.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _tbCargoType.HideSelection = true;
            _tbCargoType.IconLeft = null;
            _tbCargoType.IconLeftCursor = Cursors.IBeam;
            _tbCargoType.IconPadding = 10;
            _tbCargoType.IconRight = null;
            _tbCargoType.IconRightCursor = Cursors.IBeam;
            _tbCargoType.Lines = new string[0];
            _tbCargoType.Location = new Point(0, 0);
            _tbCargoType.Margin = new Padding(0);
            _tbCargoType.MaxLength = 32767;
            _tbCargoType.MinimumSize = new Size(30, 15);
            _tbCargoType.Modified = false;
            _tbCargoType.Multiline = false;
            _tbCargoType.Name = "_tbCargoType";
            StateProperties11.BorderColor = Color.DodgerBlue;
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            _tbCargoType.OnActiveState = StateProperties11;
            StateProperties12.BorderColor = Color.Empty;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Empty;
            StateProperties12.PlaceholderForeColor = Color.Silver;
            _tbCargoType.OnDisabledState = StateProperties12;
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            _tbCargoType.OnHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.Transparent;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties14.PlaceholderForeColor = Color.Empty;
            _tbCargoType.OnIdleState = StateProperties14;
            _tbCargoType.PasswordChar = '\0';
            _tbCargoType.PlaceholderForeColor = Color.Silver;
            _tbCargoType.PlaceholderText = "CARGO TYPE";
            _tbCargoType.ReadOnly = false;
            _tbCargoType.ScrollBars = ScrollBars.None;
            _tbCargoType.SelectedText = "";
            _tbCargoType.SelectionLength = 0;
            _tbCargoType.SelectionStart = 0;
            _tbCargoType.ShortcutsEnabled = true;
            _tbCargoType.Size = new Size(170, 17);
            _tbCargoType.Style = _Style.Bunifu;
            _tbCargoType.TabIndex = 88;
            _tbCargoType.TextAlign = HorizontalAlignment.Left;
            _tbCargoType.TextMarginBottom = 0;
            _tbCargoType.TextMarginLeft = 5;
            _tbCargoType.TextMarginTop = 0;
            _tbCargoType.TextPlaceholder = "CARGO TYPE";
            _tbCargoType.UseSystemPasswordChar = false;
            _tbCargoType.WordWrap = true;
            // 
            // tbType
            // 
            _tbType.AcceptsReturn = false;
            _tbType.AcceptsTab = false;
            _tbType.AnimationSpeed = 200;
            _tbType.AutoCompleteMode = AutoCompleteMode.None;
            _tbType.AutoCompleteSource = AutoCompleteSource.None;
            _tbType.BackColor = Color.Transparent;
            _tbType.BackgroundImage = (Image)resources.GetObject("tbType.BackgroundImage");
            _tbType.BorderColorActive = Color.DodgerBlue;
            _tbType.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbType.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbType.BorderColorIdle = Color.Transparent;
            _tbType.BorderRadius = 2;
            _tbType.BorderThickness = 0;
            _tbType.CharacterCasing = CharacterCasing.Upper;
            _tbType.Cursor = Cursors.IBeam;
            _tbType.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _tbType.DefaultText = "";
            _tbType.Dock = DockStyle.Fill;
            _tbType.FillColor = Color.White;
            _tbType.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _tbType.HideSelection = true;
            _tbType.IconLeft = null;
            _tbType.IconLeftCursor = Cursors.IBeam;
            _tbType.IconPadding = 10;
            _tbType.IconRight = null;
            _tbType.IconRightCursor = Cursors.IBeam;
            _tbType.Lines = new string[0];
            _tbType.Location = new Point(170, 0);
            _tbType.Margin = new Padding(0);
            _tbType.MaxLength = 32767;
            _tbType.MinimumSize = new Size(30, 15);
            _tbType.Modified = false;
            _tbType.Multiline = false;
            _tbType.Name = "_tbType";
            StateProperties15.BorderColor = Color.DodgerBlue;
            StateProperties15.FillColor = Color.Empty;
            StateProperties15.ForeColor = Color.Empty;
            StateProperties15.PlaceholderForeColor = Color.Empty;
            _tbType.OnActiveState = StateProperties15;
            StateProperties16.BorderColor = Color.Empty;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.Empty;
            StateProperties16.PlaceholderForeColor = Color.Silver;
            _tbType.OnDisabledState = StateProperties16;
            StateProperties17.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties17.FillColor = Color.Empty;
            StateProperties17.ForeColor = Color.Empty;
            StateProperties17.PlaceholderForeColor = Color.Empty;
            _tbType.OnHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.Transparent;
            StateProperties18.FillColor = Color.White;
            StateProperties18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties18.PlaceholderForeColor = Color.Empty;
            _tbType.OnIdleState = StateProperties18;
            _tbType.PasswordChar = '\0';
            _tbType.PlaceholderForeColor = Color.Silver;
            _tbType.PlaceholderText = "TYPE";
            _tbType.ReadOnly = false;
            _tbType.ScrollBars = ScrollBars.None;
            _tbType.SelectedText = "";
            _tbType.SelectionLength = 0;
            _tbType.SelectionStart = 0;
            _tbType.ShortcutsEnabled = true;
            _tbType.Size = new Size(169, 17);
            _tbType.Style = _Style.Bunifu;
            _tbType.TabIndex = 86;
            _tbType.TextAlign = HorizontalAlignment.Left;
            _tbType.TextMarginBottom = 0;
            _tbType.TextMarginLeft = 5;
            _tbType.TextMarginTop = 0;
            _tbType.TextPlaceholder = "TYPE";
            _tbType.UseSystemPasswordChar = false;
            _tbType.WordWrap = true;
            // 
            // tbCommodity
            // 
            tbCommodity.AcceptsReturn = false;
            tbCommodity.AcceptsTab = false;
            tbCommodity.AnimationSpeed = 200;
            tbCommodity.AutoCompleteMode = AutoCompleteMode.None;
            tbCommodity.AutoCompleteSource = AutoCompleteSource.None;
            tbCommodity.BackColor = Color.Transparent;
            tbCommodity.BackgroundImage = (Image)resources.GetObject("tbCommodity.BackgroundImage");
            tbCommodity.BorderColorActive = Color.DodgerBlue;
            tbCommodity.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbCommodity.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCommodity.BorderColorIdle = Color.Transparent;
            tbCommodity.BorderRadius = 2;
            tbCommodity.BorderThickness = 0;
            tbCommodity.CharacterCasing = CharacterCasing.Upper;
            tbCommodity.Cursor = Cursors.IBeam;
            tbCommodity.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            tbCommodity.DefaultText = "";
            tbCommodity.Dock = DockStyle.Fill;
            tbCommodity.FillColor = Color.White;
            tbCommodity.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            tbCommodity.HideSelection = true;
            tbCommodity.IconLeft = null;
            tbCommodity.IconLeftCursor = Cursors.IBeam;
            tbCommodity.IconPadding = 10;
            tbCommodity.IconRight = null;
            tbCommodity.IconRightCursor = Cursors.IBeam;
            tbCommodity.Lines = new string[0];
            tbCommodity.Location = new Point(508, 0);
            tbCommodity.Margin = new Padding(0);
            tbCommodity.MaxLength = 32767;
            tbCommodity.MinimumSize = new Size(30, 15);
            tbCommodity.Modified = false;
            tbCommodity.Multiline = false;
            tbCommodity.Name = "tbCommodity";
            StateProperties19.BorderColor = Color.DodgerBlue;
            StateProperties19.FillColor = Color.Empty;
            StateProperties19.ForeColor = Color.Empty;
            StateProperties19.PlaceholderForeColor = Color.Empty;
            tbCommodity.OnActiveState = StateProperties19;
            StateProperties20.BorderColor = Color.Empty;
            StateProperties20.FillColor = Color.White;
            StateProperties20.ForeColor = Color.Empty;
            StateProperties20.PlaceholderForeColor = Color.Silver;
            tbCommodity.OnDisabledState = StateProperties20;
            StateProperties21.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties21.FillColor = Color.Empty;
            StateProperties21.ForeColor = Color.Empty;
            StateProperties21.PlaceholderForeColor = Color.Empty;
            tbCommodity.OnHoverState = StateProperties21;
            StateProperties22.BorderColor = Color.Transparent;
            StateProperties22.FillColor = Color.White;
            StateProperties22.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties22.PlaceholderForeColor = Color.Empty;
            tbCommodity.OnIdleState = StateProperties22;
            tbCommodity.PasswordChar = '\0';
            tbCommodity.PlaceholderForeColor = Color.Silver;
            tbCommodity.PlaceholderText = "FORWARDER";
            tbCommodity.ReadOnly = false;
            tbCommodity.ScrollBars = ScrollBars.None;
            tbCommodity.SelectedText = "";
            tbCommodity.SelectionLength = 0;
            tbCommodity.SelectionStart = 0;
            tbCommodity.ShortcutsEnabled = true;
            tbCommodity.Size = new Size(166, 17);
            tbCommodity.Style = _Style.Bunifu;
            tbCommodity.TabIndex = 85;
            tbCommodity.TextAlign = HorizontalAlignment.Left;
            tbCommodity.TextMarginBottom = 0;
            tbCommodity.TextMarginLeft = 5;
            tbCommodity.TextMarginTop = 0;
            tbCommodity.TextPlaceholder = "FORWARDER";
            tbCommodity.UseSystemPasswordChar = false;
            tbCommodity.WordWrap = true;
            // 
            // FrmAssignToUnits
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 777);
            Controls.Add(ShapedPanel2);
            Controls.Add(Panel6);
            Controls.Add(_cancelButton);
            Controls.Add(_assignBunifuButton1);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            Controls.Add(Label3);
            Controls.Add(Label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAssignToUnits";
            Text = "FrmAssignToUnits";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvSelectedBkg).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibooking).EndInit();
            Panel6.ResumeLayout(false);
            Panel6.PerformLayout();
            Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnitsAsnToBks).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingMiniUnitAssignmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvMiniUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BunifuDataGridView1).EndInit();
            ShapedPanel2.ResumeLayout(false);
            ShapedPanel1.ResumeLayout(false);
            tabUnits.ResumeLayout(false);
            loadingTabPage.ResumeLayout(false);
            TabPageEX2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvStorageUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWGrainUnitStorageBindingSource).EndInit();
            TableLayoutPanel2.ResumeLayout(false);
            Load += new EventHandler(FrmAssignToUnits_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _cancelButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cancelButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cancelButton != null)
                {
                    _cancelButton.Click -= cancelButton_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += cancelButton_Click;
                }
            }
        }

        private Bunifu.Framework.UI.BunifuFlatButton _closeFlatButton;

        internal Bunifu.Framework.UI.BunifuFlatButton closeFlatButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeFlatButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click -= closeFlatButton_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeFlatButton_Click;
                }
            }
        }

        internal Label Label8;
        internal Label Label3;
        internal Label Label9;
        internal Panel Panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _assignBunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton assignBunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _assignBunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_assignBunifuButton1 != null)
                {
                    _assignBunifuButton1.Click -= assignBunifuButton1_Click;
                }

                _assignBunifuButton1 = value;
                if (_assignBunifuButton1 != null)
                {
                    _assignBunifuButton1.Click += assignBunifuButton1_Click;
                }
            }
        }

        private BunifuTextBox _tbSearchUnits;

        internal BunifuTextBox tbSearchUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbSearchUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSearchUnits != null)
                {
                    _tbSearchUnits.TextChanged -= searchBunifuTextBox1_TextChanged;
                }

                _tbSearchUnits = value;
                if (_tbSearchUnits != null)
                {
                    _tbSearchUnits.TextChanged += searchBunifuTextBox1_TextChanged;
                }
            }
        }

        internal Panel Panel6;
        internal Panel Panel5;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvUnitsAsnToBks;
        internal Label Label5;
        internal Label Label4;
        internal BindingSource VWUnitSourceMiniUnitBindingSource;
        internal DataGridViewTextBoxColumn TotalBilledDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvMiniUnits;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvMiniUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvMiniUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvMiniUnits != null)
                {
                    _dgvMiniUnits.CellContentClick -= miniUnitsDataGridView_CellContentClick;
                }

                _dgvMiniUnits = value;
                if (_dgvMiniUnits != null)
                {
                    _dgvMiniUnits.CellContentClick += miniUnitsDataGridView_CellContentClick;
                }
            }
        }

        internal DataGridViewTextBoxColumn MiniUnitIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn MiniUnitOrderDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn UnBilledDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BilledByUnitDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BilledByUnitUnitTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn UnBilledByUnitDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn UnBilledByUnitUnitTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MULocationDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommentsDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CustomerIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnitSourceIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn UnitNumberDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnitStatusDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn UnitTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CargoTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn OriginLocationDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarrierIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ETADateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ETALocationDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LastTracedDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LastLocationDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn SequenceDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TrackDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DemurageDaysDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn InTransitDaysDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BillDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CallDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ArrivalDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn AvailableDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ReleaseDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LastUpdateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ActiveUpdatesDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ActiveDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn RecordKeyDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CargoDescriptionDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarReleasedDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarAvailableDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarArrivedDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarCalledDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ShipperIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GradeIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommodityIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ShipperCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ShipperNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommodityCodeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommodityNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn GradeCodeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn GradeNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn MiniUnitNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TotalBilledMUDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TotalBilledUSDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MiniUnitIdDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn MiniUnitOrderDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnBilledDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn BilledByUnitDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn BilledByUnitUnitTypeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnBilledByUnitDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnBilledByUnitUnitTypeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn MULocationDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn CommentsDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn CustomerIdDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn UnitSourceIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnitNumberDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn UnitStatusDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn UnitTypeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CargoTypeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn OriginLocationDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CarrierIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ETADateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ETALocationDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn LastTracedDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn LastLocationDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn SequenceDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn TrackDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DemurageDaysDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn InTransitDaysDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn BillDateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CallDateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ArrivalDateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn AvailableDateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ReleaseDateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn LastUpdateDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ActiveUpdatesDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ActiveDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn RecordKeyDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn CargoDescriptionDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CarReleasedDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CarAvailableDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CarArrivedDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CarCalledDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ShipperIdDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn GradeIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommodityIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn ShipperCodeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ShipperNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommodityCodeDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn CommodityNameDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn GradeCodeDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn GradeNameDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn MiniUnitNumberDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn TotalBilledMUDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn TotalBilledUSDataGridViewTextBoxColumn1;
        internal DataGridViewCheckBoxColumn Column5;
        internal DataGridViewTextBoxColumn ShipperIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn RecordKeyDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CustomerIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GradeCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommodityCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommentsDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MULocationDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GradeNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommodityNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn UnitNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MiniUnitIdDataGridViewTextBoxColumn;
        public Bunifu.UI.WinForms.BunifuDataGridView BunifuDataGridView1;
        internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel2;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel1;
        internal Dotnetrix.Controls.TabControlEX tabUnits;
        internal Dotnetrix.Controls.TabPageEX loadingTabPage;
        internal Dotnetrix.Controls.TabPageEX TabPageEX2;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvStorageUnits;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvStorageUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvStorageUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvStorageUnits != null)
                {
                    _dgvStorageUnits.CellContentClick -= miniUnitsDataGridView_CellContentClick;
                }

                _dgvStorageUnits = value;
                if (_dgvStorageUnits != null)
                {
                    _dgvStorageUnits.CellContentClick += miniUnitsDataGridView_CellContentClick;
                }
            }
        }

        internal DataGridViewTextBoxColumn TotalBilledMUDataGridViewTextBoxColumn2;
        private BunifuTextBox _tbSearchStorageUnit;

        internal BunifuTextBox tbSearchStorageUnit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbSearchStorageUnit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSearchStorageUnit != null)
                {
                    _tbSearchStorageUnit.TextChanged -= searchBunifuTextBox1_TextChanged;
                }

                _tbSearchStorageUnit = value;
                if (_tbSearchStorageUnit != null)
                {
                    _tbSearchStorageUnit.TextChanged += searchBunifuTextBox1_TextChanged;
                }
            }
        }

        internal BindingSource VWBookingMinibooking;
        internal DataGridViewTextBoxColumn CommodityGradeDataGridViewTextBoxColumn;
        internal BindingSource VWGrainUnitStorageBindingSource;
        internal BindingSource VWMinibookingMiniUnitAssignmentBindingSource;
        internal DataGridViewTextBoxColumn MiniUnitNumberDataGridViewTextBoxColumn3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRemoveMB;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRemoveMB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRemoveMB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRemoveMB != null)
                {
                    _btnRemoveMB.Click -= btnRemoveMB_Click;
                }

                _btnRemoveMB = value;
                if (_btnRemoveMB != null)
                {
                    _btnRemoveMB.Click += btnRemoveMB_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _dgvSelectedBkg;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvSelectedBkg
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvSelectedBkg;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvSelectedBkg != null)
                {
                    _dgvSelectedBkg.SelectionChanged -= dgvSelectedBkg_SelectionChanged;
                }

                _dgvSelectedBkg = value;
                if (_dgvSelectedBkg != null)
                {
                    _dgvSelectedBkg.SelectionChanged += dgvSelectedBkg_SelectionChanged;
                }
            }
        }

        internal DataGridViewCheckBoxColumn Column1;
        internal DataGridViewTextBoxColumn StorageLocation;
        internal DataGridViewTextBoxColumn MiniUnitNumber;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn RemainingQuantityDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GradeCommodityCode;
        internal DataGridViewTextBoxColumn StorageDate;
        internal DataGridViewTextBoxColumn MiniUnitNumberDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn BookingNumberDataGridViewTextBoxColumn;
        private Timer _Timer1;

        internal Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= timer_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += timer_Tick;
                }
            }
        }

        internal DataGridViewCheckBoxColumn Column2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn CargoType;
        internal DataGridViewTextBoxColumn UnitTypeDataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn TotalBilled;
        internal DataGridViewTextBoxColumn CommodityGrade;
        internal TableLayoutPanel TableLayoutPanel2;
        private BunifuTextBox _tbCargoType;

        internal BunifuTextBox tbCargoType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbCargoType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbCargoType != null)
                {
                    _tbCargoType.TextChanged -= tbCargoType_TextChanged;
                }

                _tbCargoType = value;
                if (_tbCargoType != null)
                {
                    _tbCargoType.TextChanged += tbCargoType_TextChanged;
                }
            }
        }

        private BunifuTextBox _tbType;

        internal BunifuTextBox tbType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbType != null)
                {
                    _tbType.TextChanged -= tbCargoType_TextChanged;
                }

                _tbType = value;
                if (_tbType != null)
                {
                    _tbType.TextChanged += tbCargoType_TextChanged;
                }
            }
        }

        internal BunifuTextBox tbCommodity;
    }
}