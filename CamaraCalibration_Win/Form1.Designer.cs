using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CamaraCalibration_Win
{
    partial class Form1 :MaterialForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        /// 
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AppTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.CameraCalibrationPage = new System.Windows.Forms.TabPage();
            this.Calibration_btnBeginToCalibration = new MaterialSkin.Controls.MaterialButton();
            this.Calibration_btnCreateDescrFile = new MaterialSkin.Controls.MaterialButton();
            this.Calibration_btnSelectDescrFile = new MaterialSkin.Controls.MaterialButton();
            this.Calibration_txtDesrFileAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.hSmartWindowControl = new HalconDotNet.HSmartWindowControl();
            this.Calibration_labCalibrationParam = new MaterialSkin.Controls.MaterialLabel();
            this.Calibration_txtPlateThick = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_txtFocalLength = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_txtSinglePixelHeight = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_txtSinglePixelWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.PositionGuidancePage = new System.Windows.Forms.TabPage();
            this.PositionGuaidance_btnCreateData = new MaterialSkin.Controls.MaterialButton();
            this.PositionGuaidance_btnInputData = new MaterialSkin.Controls.MaterialButton();
            this.PositionGuaidance_btnStop = new MaterialSkin.Controls.MaterialButton();
            this.PositionGuaidance_btnBegin = new MaterialSkin.Controls.MaterialButton();
            this.PositionGuaidance_txtMutiLineOutPut = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PositionGuaidance_btnLinkModbusTcp = new MaterialSkin.Controls.MaterialButton();
            this.PositionGuaidance_txtPort = new MaterialSkin.Controls.MaterialTextBox();
            this.PositionGuidance_txtIPAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.MultipointCalibrationPage = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MultiPoint_btnCapture = new MaterialSkin.Controls.MaterialButton();
            this.MultiPoint9_btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.MultiPoint9_txtX9 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX8 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX7 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX6 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX5 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX4 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX3 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX2 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtX1 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY9 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY8 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY7 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY6 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY5 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY4 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY3 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY2 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint9_txtY1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MultiPoint12_btnCapture = new MaterialSkin.Controls.MaterialButton();
            this.MultiPoint12_btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.MultiPoint12_txtX12 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY12 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.MultiPoint12_txtX11 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY11 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.MultiPoint12_txtX10 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY10 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.MultiPoint12_txtX9 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX8 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX7 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX6 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX5 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX4 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX3 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX2 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtX1 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY9 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY8 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY7 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY6 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY5 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY4 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY3 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY2 = new MaterialSkin.Controls.MaterialTextBox();
            this.MultiPoint12_txtY1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.hSmartWindowControl2 = new HalconDotNet.HSmartWindowControl();
            this.DistortionCorrectionPage = new System.Windows.Forms.TabPage();
            this.hSmartWindowControl3 = new HalconDotNet.HSmartWindowControl();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Distortion_labCameraDataState = new MaterialSkin.Controls.MaterialLabel();
            this.CreateDescrFilePage = new System.Windows.Forms.TabPage();
            this.Calibration_btnBack = new MaterialSkin.Controls.MaterialButton();
            this.hSmartWindowControl4 = new HalconDotNet.HSmartWindowControl();
            this.Calibration_btnCreateDescrFile_Finsh = new MaterialSkin.Controls.MaterialButton();
            this.Calibration_btnSaveDescrFileAddress = new MaterialSkin.Controls.MaterialButton();
            this.Calibration_SaveDescrFileAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_labFileParam = new MaterialSkin.Controls.MaterialLabel();
            this.Calibration_txtCenterLengthRate = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_txtCenterLength = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_ClomnPointNum = new MaterialSkin.Controls.MaterialTextBox();
            this.Calibration_txtRowPointNum = new MaterialSkin.Controls.MaterialTextBox();
            this.CamaraParamPage = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CameraParam_btnSaveData = new MaterialSkin.Controls.MaterialButton();
            this.CameraParam_txtImageHight = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtKappa = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtImageWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtFocalLength = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtCenterY = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtSiglePixelHight = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtCenterX = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtSiglePixelWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CameraParam_btnSavePose = new MaterialSkin.Controls.MaterialButton();
            this.CameraParam_ZSpin = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_Z = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_YSpin = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtY = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_XSpin = new MaterialSkin.Controls.MaterialTextBox();
            this.CameraParam_txtX = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.CalibratingPage = new System.Windows.Forms.TabPage();
            this.Calibrating_labImageState = new MaterialSkin.Controls.MaterialLabel();
            this.Calibrating_btnFinish = new MaterialSkin.Controls.MaterialButton();
            this.Calibrating_ClearImage = new MaterialSkin.Controls.MaterialButton();
            this.Calibrating_labCountofImage = new MaterialSkin.Controls.MaterialLabel();
            this.Calibrating_btnCapture = new MaterialSkin.Controls.MaterialButton();
            this.hSmartWindowControl5 = new HalconDotNet.HSmartWindowControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCloseCamera = new MaterialSkin.Controls.MaterialButton();
            this.btn_OpenCamera = new MaterialSkin.Controls.MaterialButton();
            this.AppTabControl.SuspendLayout();
            this.CameraCalibrationPage.SuspendLayout();
            this.PositionGuidancePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MultipointCalibrationPage.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DistortionCorrectionPage.SuspendLayout();
            this.CreateDescrFilePage.SuspendLayout();
            this.CamaraParamPage.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.CalibratingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTabControl
            // 
            this.AppTabControl.Controls.Add(this.CameraCalibrationPage);
            this.AppTabControl.Controls.Add(this.PositionGuidancePage);
            this.AppTabControl.Controls.Add(this.MultipointCalibrationPage);
            this.AppTabControl.Controls.Add(this.DistortionCorrectionPage);
            this.AppTabControl.Controls.Add(this.CreateDescrFilePage);
            this.AppTabControl.Controls.Add(this.CamaraParamPage);
            this.AppTabControl.Controls.Add(this.CalibratingPage);
            this.AppTabControl.Depth = 0;
            this.AppTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabControl.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AppTabControl.ImageList = this.imageList1;
            this.AppTabControl.Location = new System.Drawing.Point(4, 90);
            this.AppTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.AppTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.AppTabControl.Multiline = true;
            this.AppTabControl.Name = "AppTabControl";
            this.AppTabControl.SelectedIndex = 0;
            this.AppTabControl.Size = new System.Drawing.Size(1625, 827);
            this.AppTabControl.TabIndex = 0;
            // 
            // CameraCalibrationPage
            // 
            this.CameraCalibrationPage.Controls.Add(this.Calibration_btnBeginToCalibration);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_btnCreateDescrFile);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_btnSelectDescrFile);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_txtDesrFileAddress);
            this.CameraCalibrationPage.Controls.Add(this.hSmartWindowControl);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_labCalibrationParam);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_txtPlateThick);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_txtFocalLength);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_txtSinglePixelHeight);
            this.CameraCalibrationPage.Controls.Add(this.Calibration_txtSinglePixelWidth);
            this.CameraCalibrationPage.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CameraCalibrationPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CameraCalibrationPage.ImageKey = "photo_camera_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.CameraCalibrationPage.Location = new System.Drawing.Point(4, 39);
            this.CameraCalibrationPage.Margin = new System.Windows.Forms.Padding(4);
            this.CameraCalibrationPage.Name = "CameraCalibrationPage";
            this.CameraCalibrationPage.Padding = new System.Windows.Forms.Padding(4);
            this.CameraCalibrationPage.Size = new System.Drawing.Size(1617, 784);
            this.CameraCalibrationPage.TabIndex = 0;
            this.CameraCalibrationPage.Text = "相机标定";
            this.CameraCalibrationPage.UseVisualStyleBackColor = true;
            // 
            // Calibration_btnBeginToCalibration
            // 
            this.Calibration_btnBeginToCalibration.AutoSize = false;
            this.Calibration_btnBeginToCalibration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibration_btnBeginToCalibration.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibration_btnBeginToCalibration.Depth = 0;
            this.Calibration_btnBeginToCalibration.HighEmphasis = true;
            this.Calibration_btnBeginToCalibration.Icon = null;
            this.Calibration_btnBeginToCalibration.Location = new System.Drawing.Point(19, 744);
            this.Calibration_btnBeginToCalibration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibration_btnBeginToCalibration.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_btnBeginToCalibration.Name = "Calibration_btnBeginToCalibration";
            this.Calibration_btnBeginToCalibration.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibration_btnBeginToCalibration.Size = new System.Drawing.Size(345, 36);
            this.Calibration_btnBeginToCalibration.TabIndex = 11;
            this.Calibration_btnBeginToCalibration.Text = "开始";
            this.Calibration_btnBeginToCalibration.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibration_btnBeginToCalibration.UseAccentColor = false;
            this.Calibration_btnBeginToCalibration.UseVisualStyleBackColor = true;
            // 
            // Calibration_btnCreateDescrFile
            // 
            this.Calibration_btnCreateDescrFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibration_btnCreateDescrFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibration_btnCreateDescrFile.Depth = 0;
            this.Calibration_btnCreateDescrFile.HighEmphasis = true;
            this.Calibration_btnCreateDescrFile.Icon = null;
            this.Calibration_btnCreateDescrFile.Location = new System.Drawing.Point(300, 360);
            this.Calibration_btnCreateDescrFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibration_btnCreateDescrFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_btnCreateDescrFile.Name = "Calibration_btnCreateDescrFile";
            this.Calibration_btnCreateDescrFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibration_btnCreateDescrFile.Size = new System.Drawing.Size(64, 36);
            this.Calibration_btnCreateDescrFile.TabIndex = 10;
            this.Calibration_btnCreateDescrFile.Text = "生成";
            this.Calibration_btnCreateDescrFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibration_btnCreateDescrFile.UseAccentColor = false;
            this.Calibration_btnCreateDescrFile.UseVisualStyleBackColor = true;
            this.Calibration_btnCreateDescrFile.Click += new System.EventHandler(this.btnCreateDescrFile_Click);
            // 
            // Calibration_btnSelectDescrFile
            // 
            this.Calibration_btnSelectDescrFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibration_btnSelectDescrFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibration_btnSelectDescrFile.Depth = 0;
            this.Calibration_btnSelectDescrFile.HighEmphasis = true;
            this.Calibration_btnSelectDescrFile.Icon = null;
            this.Calibration_btnSelectDescrFile.Location = new System.Drawing.Point(228, 360);
            this.Calibration_btnSelectDescrFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibration_btnSelectDescrFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_btnSelectDescrFile.Name = "Calibration_btnSelectDescrFile";
            this.Calibration_btnSelectDescrFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibration_btnSelectDescrFile.Size = new System.Drawing.Size(64, 36);
            this.Calibration_btnSelectDescrFile.TabIndex = 9;
            this.Calibration_btnSelectDescrFile.Text = "选择";
            this.Calibration_btnSelectDescrFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibration_btnSelectDescrFile.UseAccentColor = false;
            this.Calibration_btnSelectDescrFile.UseVisualStyleBackColor = true;
            // 
            // Calibration_txtDesrFileAddress
            // 
            this.Calibration_txtDesrFileAddress.AnimateReadOnly = false;
            this.Calibration_txtDesrFileAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtDesrFileAddress.Depth = 0;
            this.Calibration_txtDesrFileAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtDesrFileAddress.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtDesrFileAddress.Hint = "描述文件地址";
            this.Calibration_txtDesrFileAddress.LeadingIcon = null;
            this.Calibration_txtDesrFileAddress.Location = new System.Drawing.Point(19, 346);
            this.Calibration_txtDesrFileAddress.MaxLength = 50;
            this.Calibration_txtDesrFileAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtDesrFileAddress.Multiline = false;
            this.Calibration_txtDesrFileAddress.Name = "Calibration_txtDesrFileAddress";
            this.Calibration_txtDesrFileAddress.Size = new System.Drawing.Size(202, 50);
            this.Calibration_txtDesrFileAddress.TabIndex = 8;
            this.Calibration_txtDesrFileAddress.Text = "";
            this.Calibration_txtDesrFileAddress.TrailingIcon = null;
            // 
            // hSmartWindowControl
            // 
            this.hSmartWindowControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hSmartWindowControl.HDoubleClickToFitContent = true;
            this.hSmartWindowControl.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl.HKeepAspectRatio = true;
            this.hSmartWindowControl.HMoveContent = true;
            this.hSmartWindowControl.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl.Location = new System.Drawing.Point(405, 22);
            this.hSmartWindowControl.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl.Name = "hSmartWindowControl";
            this.hSmartWindowControl.Size = new System.Drawing.Size(1145, 776);
            this.hSmartWindowControl.TabIndex = 7;
            this.hSmartWindowControl.WindowSize = new System.Drawing.Size(1145, 776);
            // 
            // Calibration_labCalibrationParam
            // 
            this.Calibration_labCalibrationParam.AutoSize = true;
            this.Calibration_labCalibrationParam.BackColor = System.Drawing.Color.White;
            this.Calibration_labCalibrationParam.Depth = 0;
            this.Calibration_labCalibrationParam.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_labCalibrationParam.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.Calibration_labCalibrationParam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calibration_labCalibrationParam.Location = new System.Drawing.Point(123, 18);
            this.Calibration_labCalibrationParam.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_labCalibrationParam.Name = "Calibration_labCalibrationParam";
            this.Calibration_labCalibrationParam.Size = new System.Drawing.Size(241, 72);
            this.Calibration_labCalibrationParam.TabIndex = 6;
            this.Calibration_labCalibrationParam.Text = "标定参数";
            this.Calibration_labCalibrationParam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Calibration_txtPlateThick
            // 
            this.Calibration_txtPlateThick.AnimateReadOnly = false;
            this.Calibration_txtPlateThick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtPlateThick.Depth = 0;
            this.Calibration_txtPlateThick.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtPlateThick.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtPlateThick.Hint = "厚度";
            this.Calibration_txtPlateThick.LeadingIcon = null;
            this.Calibration_txtPlateThick.Location = new System.Drawing.Point(19, 290);
            this.Calibration_txtPlateThick.MaxLength = 50;
            this.Calibration_txtPlateThick.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtPlateThick.Multiline = false;
            this.Calibration_txtPlateThick.Name = "Calibration_txtPlateThick";
            this.Calibration_txtPlateThick.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtPlateThick.TabIndex = 4;
            this.Calibration_txtPlateThick.Text = "";
            this.Calibration_txtPlateThick.TrailingIcon = null;
            // 
            // Calibration_txtFocalLength
            // 
            this.Calibration_txtFocalLength.AnimateReadOnly = false;
            this.Calibration_txtFocalLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtFocalLength.Depth = 0;
            this.Calibration_txtFocalLength.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtFocalLength.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtFocalLength.Hint = "焦距(mm)";
            this.Calibration_txtFocalLength.LeadingIcon = null;
            this.Calibration_txtFocalLength.Location = new System.Drawing.Point(19, 234);
            this.Calibration_txtFocalLength.MaxLength = 50;
            this.Calibration_txtFocalLength.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtFocalLength.Multiline = false;
            this.Calibration_txtFocalLength.Name = "Calibration_txtFocalLength";
            this.Calibration_txtFocalLength.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtFocalLength.TabIndex = 2;
            this.Calibration_txtFocalLength.Text = "";
            this.Calibration_txtFocalLength.TrailingIcon = null;
            // 
            // Calibration_txtSinglePixelHeight
            // 
            this.Calibration_txtSinglePixelHeight.AnimateReadOnly = false;
            this.Calibration_txtSinglePixelHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtSinglePixelHeight.Depth = 0;
            this.Calibration_txtSinglePixelHeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtSinglePixelHeight.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtSinglePixelHeight.Hint = "单个像素高度(um)";
            this.Calibration_txtSinglePixelHeight.LeadingIcon = null;
            this.Calibration_txtSinglePixelHeight.Location = new System.Drawing.Point(19, 178);
            this.Calibration_txtSinglePixelHeight.MaxLength = 50;
            this.Calibration_txtSinglePixelHeight.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtSinglePixelHeight.Multiline = false;
            this.Calibration_txtSinglePixelHeight.Name = "Calibration_txtSinglePixelHeight";
            this.Calibration_txtSinglePixelHeight.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtSinglePixelHeight.TabIndex = 1;
            this.Calibration_txtSinglePixelHeight.Text = "";
            this.Calibration_txtSinglePixelHeight.TrailingIcon = null;
            // 
            // Calibration_txtSinglePixelWidth
            // 
            this.Calibration_txtSinglePixelWidth.AnimateReadOnly = false;
            this.Calibration_txtSinglePixelWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtSinglePixelWidth.Depth = 0;
            this.Calibration_txtSinglePixelWidth.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtSinglePixelWidth.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtSinglePixelWidth.Hint = "单个像素宽度(um)";
            this.Calibration_txtSinglePixelWidth.LeadingIcon = null;
            this.Calibration_txtSinglePixelWidth.Location = new System.Drawing.Point(19, 122);
            this.Calibration_txtSinglePixelWidth.MaxLength = 50;
            this.Calibration_txtSinglePixelWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtSinglePixelWidth.Multiline = false;
            this.Calibration_txtSinglePixelWidth.Name = "Calibration_txtSinglePixelWidth";
            this.Calibration_txtSinglePixelWidth.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtSinglePixelWidth.TabIndex = 0;
            this.Calibration_txtSinglePixelWidth.Text = "";
            this.Calibration_txtSinglePixelWidth.TrailingIcon = null;
            // 
            // PositionGuidancePage
            // 
            this.PositionGuidancePage.Controls.Add(this.PositionGuaidance_btnCreateData);
            this.PositionGuidancePage.Controls.Add(this.PositionGuaidance_btnInputData);
            this.PositionGuidancePage.Controls.Add(this.PositionGuaidance_btnStop);
            this.PositionGuidancePage.Controls.Add(this.PositionGuaidance_btnBegin);
            this.PositionGuidancePage.Controls.Add(this.PositionGuaidance_txtMutiLineOutPut);
            this.PositionGuidancePage.Controls.Add(this.hSmartWindowControl1);
            this.PositionGuidancePage.Controls.Add(this.groupBox1);
            this.PositionGuidancePage.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PositionGuidancePage.ImageKey = "control_camera_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.PositionGuidancePage.Location = new System.Drawing.Point(4, 39);
            this.PositionGuidancePage.Margin = new System.Windows.Forms.Padding(4);
            this.PositionGuidancePage.Name = "PositionGuidancePage";
            this.PositionGuidancePage.Padding = new System.Windows.Forms.Padding(4);
            this.PositionGuidancePage.Size = new System.Drawing.Size(1617, 784);
            this.PositionGuidancePage.TabIndex = 1;
            this.PositionGuidancePage.Text = "定位引导";
            this.PositionGuidancePage.UseVisualStyleBackColor = true;
            // 
            // PositionGuaidance_btnCreateData
            // 
            this.PositionGuaidance_btnCreateData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PositionGuaidance_btnCreateData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PositionGuaidance_btnCreateData.Depth = 0;
            this.PositionGuaidance_btnCreateData.HighEmphasis = true;
            this.PositionGuaidance_btnCreateData.Icon = null;
            this.PositionGuaidance_btnCreateData.Location = new System.Drawing.Point(758, 674);
            this.PositionGuaidance_btnCreateData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionGuaidance_btnCreateData.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionGuaidance_btnCreateData.Name = "PositionGuaidance_btnCreateData";
            this.PositionGuaidance_btnCreateData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PositionGuaidance_btnCreateData.Size = new System.Drawing.Size(148, 36);
            this.PositionGuaidance_btnCreateData.TabIndex = 6;
            this.PositionGuaidance_btnCreateData.Text = "生成图像映射数据";
            this.PositionGuaidance_btnCreateData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PositionGuaidance_btnCreateData.UseAccentColor = false;
            this.PositionGuaidance_btnCreateData.UseVisualStyleBackColor = true;
            // 
            // PositionGuaidance_btnInputData
            // 
            this.PositionGuaidance_btnInputData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PositionGuaidance_btnInputData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PositionGuaidance_btnInputData.Depth = 0;
            this.PositionGuaidance_btnInputData.HighEmphasis = true;
            this.PositionGuaidance_btnInputData.Icon = null;
            this.PositionGuaidance_btnInputData.Location = new System.Drawing.Point(602, 674);
            this.PositionGuaidance_btnInputData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionGuaidance_btnInputData.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionGuaidance_btnInputData.Name = "PositionGuaidance_btnInputData";
            this.PositionGuaidance_btnInputData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PositionGuaidance_btnInputData.Size = new System.Drawing.Size(148, 36);
            this.PositionGuaidance_btnInputData.TabIndex = 5;
            this.PositionGuaidance_btnInputData.Text = "导入图像映射数据";
            this.PositionGuaidance_btnInputData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PositionGuaidance_btnInputData.UseAccentColor = false;
            this.PositionGuaidance_btnInputData.UseVisualStyleBackColor = true;
            // 
            // PositionGuaidance_btnStop
            // 
            this.PositionGuaidance_btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PositionGuaidance_btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PositionGuaidance_btnStop.Depth = 0;
            this.PositionGuaidance_btnStop.HighEmphasis = true;
            this.PositionGuaidance_btnStop.Icon = null;
            this.PositionGuaidance_btnStop.Location = new System.Drawing.Point(530, 674);
            this.PositionGuaidance_btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionGuaidance_btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionGuaidance_btnStop.Name = "PositionGuaidance_btnStop";
            this.PositionGuaidance_btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PositionGuaidance_btnStop.Size = new System.Drawing.Size(64, 36);
            this.PositionGuaidance_btnStop.TabIndex = 4;
            this.PositionGuaidance_btnStop.Text = "停止";
            this.PositionGuaidance_btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PositionGuaidance_btnStop.UseAccentColor = false;
            this.PositionGuaidance_btnStop.UseVisualStyleBackColor = true;
            // 
            // PositionGuaidance_btnBegin
            // 
            this.PositionGuaidance_btnBegin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PositionGuaidance_btnBegin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PositionGuaidance_btnBegin.Depth = 0;
            this.PositionGuaidance_btnBegin.HighEmphasis = true;
            this.PositionGuaidance_btnBegin.Icon = null;
            this.PositionGuaidance_btnBegin.Location = new System.Drawing.Point(459, 674);
            this.PositionGuaidance_btnBegin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionGuaidance_btnBegin.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionGuaidance_btnBegin.Name = "PositionGuaidance_btnBegin";
            this.PositionGuaidance_btnBegin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PositionGuaidance_btnBegin.Size = new System.Drawing.Size(64, 36);
            this.PositionGuaidance_btnBegin.TabIndex = 3;
            this.PositionGuaidance_btnBegin.Text = "开始";
            this.PositionGuaidance_btnBegin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PositionGuaidance_btnBegin.UseAccentColor = false;
            this.PositionGuaidance_btnBegin.UseVisualStyleBackColor = true;
            // 
            // PositionGuaidance_txtMutiLineOutPut
            // 
            this.PositionGuaidance_txtMutiLineOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PositionGuaidance_txtMutiLineOutPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionGuaidance_txtMutiLineOutPut.Depth = 0;
            this.PositionGuaidance_txtMutiLineOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PositionGuaidance_txtMutiLineOutPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PositionGuaidance_txtMutiLineOutPut.Location = new System.Drawing.Point(1365, 110);
            this.PositionGuaidance_txtMutiLineOutPut.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionGuaidance_txtMutiLineOutPut.Name = "PositionGuaidance_txtMutiLineOutPut";
            this.PositionGuaidance_txtMutiLineOutPut.ReadOnly = true;
            this.PositionGuaidance_txtMutiLineOutPut.Size = new System.Drawing.Size(245, 529);
            this.PositionGuaidance_txtMutiLineOutPut.TabIndex = 2;
            this.PositionGuaidance_txtMutiLineOutPut.Text = "";
            // 
            // hSmartWindowControl1
            // 
            this.hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl1.HDoubleClickToFitContent = true;
            this.hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl1.HKeepAspectRatio = true;
            this.hSmartWindowControl1.HMoveContent = true;
            this.hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl1.Location = new System.Drawing.Point(25, 139);
            this.hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl1.Name = "hSmartWindowControl1";
            this.hSmartWindowControl1.Size = new System.Drawing.Size(1323, 529);
            this.hSmartWindowControl1.TabIndex = 1;
            this.hSmartWindowControl1.WindowSize = new System.Drawing.Size(1323, 529);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PositionGuaidance_btnLinkModbusTcp);
            this.groupBox1.Controls.Add(this.PositionGuaidance_txtPort);
            this.groupBox1.Controls.Add(this.PositionGuidance_txtIPAddress);
            this.groupBox1.Location = new System.Drawing.Point(7, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1602, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modbus Tcp";
            // 
            // PositionGuaidance_btnLinkModbusTcp
            // 
            this.PositionGuaidance_btnLinkModbusTcp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PositionGuaidance_btnLinkModbusTcp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PositionGuaidance_btnLinkModbusTcp.Depth = 0;
            this.PositionGuaidance_btnLinkModbusTcp.HighEmphasis = true;
            this.PositionGuaidance_btnLinkModbusTcp.Icon = null;
            this.PositionGuaidance_btnLinkModbusTcp.Location = new System.Drawing.Point(437, 37);
            this.PositionGuaidance_btnLinkModbusTcp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionGuaidance_btnLinkModbusTcp.MouseState = MaterialSkin.MouseState.HOVER;
            this.PositionGuaidance_btnLinkModbusTcp.Name = "PositionGuaidance_btnLinkModbusTcp";
            this.PositionGuaidance_btnLinkModbusTcp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PositionGuaidance_btnLinkModbusTcp.Size = new System.Drawing.Size(64, 36);
            this.PositionGuaidance_btnLinkModbusTcp.TabIndex = 2;
            this.PositionGuaidance_btnLinkModbusTcp.Text = "连接";
            this.PositionGuaidance_btnLinkModbusTcp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PositionGuaidance_btnLinkModbusTcp.UseAccentColor = false;
            this.PositionGuaidance_btnLinkModbusTcp.UseVisualStyleBackColor = true;
            // 
            // PositionGuaidance_txtPort
            // 
            this.PositionGuaidance_txtPort.AnimateReadOnly = false;
            this.PositionGuaidance_txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionGuaidance_txtPort.Depth = 0;
            this.PositionGuaidance_txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PositionGuaidance_txtPort.LeadingIcon = null;
            this.PositionGuaidance_txtPort.Location = new System.Drawing.Point(216, 23);
            this.PositionGuaidance_txtPort.MaxLength = 50;
            this.PositionGuaidance_txtPort.MouseState = MaterialSkin.MouseState.OUT;
            this.PositionGuaidance_txtPort.Multiline = false;
            this.PositionGuaidance_txtPort.Name = "PositionGuaidance_txtPort";
            this.PositionGuaidance_txtPort.Size = new System.Drawing.Size(214, 50);
            this.PositionGuaidance_txtPort.TabIndex = 1;
            this.PositionGuaidance_txtPort.Text = "Port";
            this.PositionGuaidance_txtPort.TrailingIcon = null;
            // 
            // PositionGuidance_txtIPAddress
            // 
            this.PositionGuidance_txtIPAddress.AnimateReadOnly = false;
            this.PositionGuidance_txtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionGuidance_txtIPAddress.Depth = 0;
            this.PositionGuidance_txtIPAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PositionGuidance_txtIPAddress.Hint = "IP Address";
            this.PositionGuidance_txtIPAddress.LeadingIcon = null;
            this.PositionGuidance_txtIPAddress.Location = new System.Drawing.Point(18, 23);
            this.PositionGuidance_txtIPAddress.MaxLength = 50;
            this.PositionGuidance_txtIPAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.PositionGuidance_txtIPAddress.Multiline = false;
            this.PositionGuidance_txtIPAddress.Name = "PositionGuidance_txtIPAddress";
            this.PositionGuidance_txtIPAddress.Size = new System.Drawing.Size(192, 50);
            this.PositionGuidance_txtIPAddress.TabIndex = 0;
            this.PositionGuidance_txtIPAddress.Text = "";
            this.PositionGuidance_txtIPAddress.TrailingIcon = null;
            // 
            // MultipointCalibrationPage
            // 
            this.MultipointCalibrationPage.Controls.Add(this.materialTabSelector1);
            this.MultipointCalibrationPage.Controls.Add(this.materialTabControl1);
            this.MultipointCalibrationPage.Controls.Add(this.hSmartWindowControl2);
            this.MultipointCalibrationPage.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MultipointCalibrationPage.ImageKey = "radio_button_checked_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.MultipointCalibrationPage.Location = new System.Drawing.Point(4, 39);
            this.MultipointCalibrationPage.Margin = new System.Windows.Forms.Padding(4);
            this.MultipointCalibrationPage.Name = "MultipointCalibrationPage";
            this.MultipointCalibrationPage.Size = new System.Drawing.Size(1617, 784);
            this.MultipointCalibrationPage.TabIndex = 2;
            this.MultipointCalibrationPage.Text = "多点标定";
            this.MultipointCalibrationPage.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(1191, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(426, 48);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(1191, 50);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(437, 731);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MultiPoint_btnCapture);
            this.tabPage1.Controls.Add(this.MultiPoint9_btnCreate);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX9);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX8);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX7);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX6);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX5);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX4);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX3);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX2);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtX1);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY9);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY8);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY7);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY6);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY5);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY4);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY3);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY2);
            this.tabPage1.Controls.Add(this.MultiPoint9_txtY1);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialLabel8);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "9点标定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MultiPoint_btnCapture
            // 
            this.MultiPoint_btnCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MultiPoint_btnCapture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MultiPoint_btnCapture.Depth = 0;
            this.MultiPoint_btnCapture.HighEmphasis = true;
            this.MultiPoint_btnCapture.Icon = null;
            this.MultiPoint_btnCapture.Location = new System.Drawing.Point(144, 625);
            this.MultiPoint_btnCapture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MultiPoint_btnCapture.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiPoint_btnCapture.Name = "MultiPoint_btnCapture";
            this.MultiPoint_btnCapture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MultiPoint_btnCapture.Size = new System.Drawing.Size(64, 36);
            this.MultiPoint_btnCapture.TabIndex = 13;
            this.MultiPoint_btnCapture.Text = "采集";
            this.MultiPoint_btnCapture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MultiPoint_btnCapture.UseAccentColor = false;
            this.MultiPoint_btnCapture.UseVisualStyleBackColor = true;
            // 
            // MultiPoint9_btnCreat
            // 
            this.MultiPoint9_btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MultiPoint9_btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MultiPoint9_btnCreate.Depth = 0;
            this.MultiPoint9_btnCreate.HighEmphasis = true;
            this.MultiPoint9_btnCreate.Icon = null;
            this.MultiPoint9_btnCreate.Location = new System.Drawing.Point(217, 625);
            this.MultiPoint9_btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MultiPoint9_btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiPoint9_btnCreate.Name = "MultiPoint9_btnCreat";
            this.MultiPoint9_btnCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MultiPoint9_btnCreate.Size = new System.Drawing.Size(64, 36);
            this.MultiPoint9_btnCreate.TabIndex = 12;
            this.MultiPoint9_btnCreate.Text = "生成";
            this.MultiPoint9_btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MultiPoint9_btnCreate.UseAccentColor = false;
            this.MultiPoint9_btnCreate.UseVisualStyleBackColor = true;
            // 
            // MultiPoint9_txtX9
            // 
            this.MultiPoint9_txtX9.AnimateReadOnly = false;
            this.MultiPoint9_txtX9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX9.Depth = 0;
            this.MultiPoint9_txtX9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX9.Hint = "X";
            this.MultiPoint9_txtX9.LeadingIcon = null;
            this.MultiPoint9_txtX9.Location = new System.Drawing.Point(102, 454);
            this.MultiPoint9_txtX9.MaxLength = 50;
            this.MultiPoint9_txtX9.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX9.Multiline = false;
            this.MultiPoint9_txtX9.Name = "MultiPoint9_txtX9";
            this.MultiPoint9_txtX9.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX9.TabIndex = 11;
            this.MultiPoint9_txtX9.Text = "";
            this.MultiPoint9_txtX9.TrailingIcon = null;
            // 
            // MultiPoint9_txtX8
            // 
            this.MultiPoint9_txtX8.AnimateReadOnly = false;
            this.MultiPoint9_txtX8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX8.Depth = 0;
            this.MultiPoint9_txtX8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX8.Hint = "X";
            this.MultiPoint9_txtX8.LeadingIcon = null;
            this.MultiPoint9_txtX8.Location = new System.Drawing.Point(102, 398);
            this.MultiPoint9_txtX8.MaxLength = 50;
            this.MultiPoint9_txtX8.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX8.Multiline = false;
            this.MultiPoint9_txtX8.Name = "MultiPoint9_txtX8";
            this.MultiPoint9_txtX8.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX8.TabIndex = 11;
            this.MultiPoint9_txtX8.Text = "";
            this.MultiPoint9_txtX8.TrailingIcon = null;
            // 
            // MultiPoint9_txtX7
            // 
            this.MultiPoint9_txtX7.AnimateReadOnly = false;
            this.MultiPoint9_txtX7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX7.Depth = 0;
            this.MultiPoint9_txtX7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX7.Hint = "X";
            this.MultiPoint9_txtX7.LeadingIcon = null;
            this.MultiPoint9_txtX7.Location = new System.Drawing.Point(102, 342);
            this.MultiPoint9_txtX7.MaxLength = 50;
            this.MultiPoint9_txtX7.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX7.Multiline = false;
            this.MultiPoint9_txtX7.Name = "MultiPoint9_txtX7";
            this.MultiPoint9_txtX7.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX7.TabIndex = 11;
            this.MultiPoint9_txtX7.Text = "";
            this.MultiPoint9_txtX7.TrailingIcon = null;
            // 
            // MultiPoint9_txtX6
            // 
            this.MultiPoint9_txtX6.AnimateReadOnly = false;
            this.MultiPoint9_txtX6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX6.Depth = 0;
            this.MultiPoint9_txtX6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX6.Hint = "X";
            this.MultiPoint9_txtX6.LeadingIcon = null;
            this.MultiPoint9_txtX6.Location = new System.Drawing.Point(102, 286);
            this.MultiPoint9_txtX6.MaxLength = 50;
            this.MultiPoint9_txtX6.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX6.Multiline = false;
            this.MultiPoint9_txtX6.Name = "MultiPoint9_txtX6";
            this.MultiPoint9_txtX6.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX6.TabIndex = 11;
            this.MultiPoint9_txtX6.Text = "";
            this.MultiPoint9_txtX6.TrailingIcon = null;
            // 
            // MultiPoint9_txtX5
            // 
            this.MultiPoint9_txtX5.AnimateReadOnly = false;
            this.MultiPoint9_txtX5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX5.Depth = 0;
            this.MultiPoint9_txtX5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX5.Hint = "X";
            this.MultiPoint9_txtX5.LeadingIcon = null;
            this.MultiPoint9_txtX5.Location = new System.Drawing.Point(102, 230);
            this.MultiPoint9_txtX5.MaxLength = 50;
            this.MultiPoint9_txtX5.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX5.Multiline = false;
            this.MultiPoint9_txtX5.Name = "MultiPoint9_txtX5";
            this.MultiPoint9_txtX5.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX5.TabIndex = 11;
            this.MultiPoint9_txtX5.Text = "";
            this.MultiPoint9_txtX5.TrailingIcon = null;
            // 
            // MultiPoint9_txtX4
            // 
            this.MultiPoint9_txtX4.AnimateReadOnly = false;
            this.MultiPoint9_txtX4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX4.Depth = 0;
            this.MultiPoint9_txtX4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX4.Hint = "X";
            this.MultiPoint9_txtX4.LeadingIcon = null;
            this.MultiPoint9_txtX4.Location = new System.Drawing.Point(102, 174);
            this.MultiPoint9_txtX4.MaxLength = 50;
            this.MultiPoint9_txtX4.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX4.Multiline = false;
            this.MultiPoint9_txtX4.Name = "MultiPoint9_txtX4";
            this.MultiPoint9_txtX4.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX4.TabIndex = 11;
            this.MultiPoint9_txtX4.Text = "";
            this.MultiPoint9_txtX4.TrailingIcon = null;
            // 
            // MultiPoint9_txtX3
            // 
            this.MultiPoint9_txtX3.AnimateReadOnly = false;
            this.MultiPoint9_txtX3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX3.Depth = 0;
            this.MultiPoint9_txtX3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX3.Hint = "X";
            this.MultiPoint9_txtX3.LeadingIcon = null;
            this.MultiPoint9_txtX3.Location = new System.Drawing.Point(102, 118);
            this.MultiPoint9_txtX3.MaxLength = 50;
            this.MultiPoint9_txtX3.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX3.Multiline = false;
            this.MultiPoint9_txtX3.Name = "MultiPoint9_txtX3";
            this.MultiPoint9_txtX3.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX3.TabIndex = 11;
            this.MultiPoint9_txtX3.Text = "";
            this.MultiPoint9_txtX3.TrailingIcon = null;
            // 
            // MultiPoint9_txtX2
            // 
            this.MultiPoint9_txtX2.AnimateReadOnly = false;
            this.MultiPoint9_txtX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX2.Depth = 0;
            this.MultiPoint9_txtX2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX2.Hint = "X";
            this.MultiPoint9_txtX2.LeadingIcon = null;
            this.MultiPoint9_txtX2.Location = new System.Drawing.Point(102, 62);
            this.MultiPoint9_txtX2.MaxLength = 50;
            this.MultiPoint9_txtX2.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX2.Multiline = false;
            this.MultiPoint9_txtX2.Name = "MultiPoint9_txtX2";
            this.MultiPoint9_txtX2.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX2.TabIndex = 11;
            this.MultiPoint9_txtX2.Text = "";
            this.MultiPoint9_txtX2.TrailingIcon = null;
            // 
            // MultiPoint9_txtX1
            // 
            this.MultiPoint9_txtX1.AnimateReadOnly = false;
            this.MultiPoint9_txtX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtX1.Depth = 0;
            this.MultiPoint9_txtX1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtX1.Hint = "X";
            this.MultiPoint9_txtX1.LeadingIcon = null;
            this.MultiPoint9_txtX1.Location = new System.Drawing.Point(102, 6);
            this.MultiPoint9_txtX1.MaxLength = 50;
            this.MultiPoint9_txtX1.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtX1.Multiline = false;
            this.MultiPoint9_txtX1.Name = "MultiPoint9_txtX1";
            this.MultiPoint9_txtX1.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtX1.TabIndex = 11;
            this.MultiPoint9_txtX1.Text = "";
            this.MultiPoint9_txtX1.TrailingIcon = null;
            // 
            // MultiPoint9_txtY9
            // 
            this.MultiPoint9_txtY9.AnimateReadOnly = false;
            this.MultiPoint9_txtY9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY9.Depth = 0;
            this.MultiPoint9_txtY9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY9.Hint = "Y";
            this.MultiPoint9_txtY9.LeadingIcon = null;
            this.MultiPoint9_txtY9.Location = new System.Drawing.Point(217, 454);
            this.MultiPoint9_txtY9.MaxLength = 50;
            this.MultiPoint9_txtY9.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY9.Multiline = false;
            this.MultiPoint9_txtY9.Name = "MultiPoint9_txtY9";
            this.MultiPoint9_txtY9.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY9.TabIndex = 10;
            this.MultiPoint9_txtY9.Text = "";
            this.MultiPoint9_txtY9.TrailingIcon = null;
            // 
            // MultiPoint9_txtY8
            // 
            this.MultiPoint9_txtY8.AnimateReadOnly = false;
            this.MultiPoint9_txtY8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY8.Depth = 0;
            this.MultiPoint9_txtY8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY8.Hint = "Y";
            this.MultiPoint9_txtY8.LeadingIcon = null;
            this.MultiPoint9_txtY8.Location = new System.Drawing.Point(217, 398);
            this.MultiPoint9_txtY8.MaxLength = 50;
            this.MultiPoint9_txtY8.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY8.Multiline = false;
            this.MultiPoint9_txtY8.Name = "MultiPoint9_txtY8";
            this.MultiPoint9_txtY8.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY8.TabIndex = 10;
            this.MultiPoint9_txtY8.Text = "";
            this.MultiPoint9_txtY8.TrailingIcon = null;
            // 
            // MultiPoint9_txtY7
            // 
            this.MultiPoint9_txtY7.AnimateReadOnly = false;
            this.MultiPoint9_txtY7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY7.Depth = 0;
            this.MultiPoint9_txtY7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY7.Hint = "Y";
            this.MultiPoint9_txtY7.LeadingIcon = null;
            this.MultiPoint9_txtY7.Location = new System.Drawing.Point(217, 342);
            this.MultiPoint9_txtY7.MaxLength = 50;
            this.MultiPoint9_txtY7.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY7.Multiline = false;
            this.MultiPoint9_txtY7.Name = "MultiPoint9_txtY7";
            this.MultiPoint9_txtY7.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY7.TabIndex = 10;
            this.MultiPoint9_txtY7.Text = "";
            this.MultiPoint9_txtY7.TrailingIcon = null;
            // 
            // MultiPoint9_txtY6
            // 
            this.MultiPoint9_txtY6.AnimateReadOnly = false;
            this.MultiPoint9_txtY6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY6.Depth = 0;
            this.MultiPoint9_txtY6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY6.Hint = "Y";
            this.MultiPoint9_txtY6.LeadingIcon = null;
            this.MultiPoint9_txtY6.Location = new System.Drawing.Point(217, 286);
            this.MultiPoint9_txtY6.MaxLength = 50;
            this.MultiPoint9_txtY6.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY6.Multiline = false;
            this.MultiPoint9_txtY6.Name = "MultiPoint9_txtY6";
            this.MultiPoint9_txtY6.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY6.TabIndex = 10;
            this.MultiPoint9_txtY6.Text = "";
            this.MultiPoint9_txtY6.TrailingIcon = null;
            // 
            // MultiPoint9_txtY5
            // 
            this.MultiPoint9_txtY5.AnimateReadOnly = false;
            this.MultiPoint9_txtY5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY5.Depth = 0;
            this.MultiPoint9_txtY5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY5.Hint = "Y";
            this.MultiPoint9_txtY5.LeadingIcon = null;
            this.MultiPoint9_txtY5.Location = new System.Drawing.Point(217, 230);
            this.MultiPoint9_txtY5.MaxLength = 50;
            this.MultiPoint9_txtY5.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY5.Multiline = false;
            this.MultiPoint9_txtY5.Name = "MultiPoint9_txtY5";
            this.MultiPoint9_txtY5.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY5.TabIndex = 10;
            this.MultiPoint9_txtY5.Text = "";
            this.MultiPoint9_txtY5.TrailingIcon = null;
            // 
            // MultiPoint9_txtY4
            // 
            this.MultiPoint9_txtY4.AnimateReadOnly = false;
            this.MultiPoint9_txtY4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY4.Depth = 0;
            this.MultiPoint9_txtY4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY4.Hint = "Y";
            this.MultiPoint9_txtY4.LeadingIcon = null;
            this.MultiPoint9_txtY4.Location = new System.Drawing.Point(217, 174);
            this.MultiPoint9_txtY4.MaxLength = 50;
            this.MultiPoint9_txtY4.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY4.Multiline = false;
            this.MultiPoint9_txtY4.Name = "MultiPoint9_txtY4";
            this.MultiPoint9_txtY4.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY4.TabIndex = 10;
            this.MultiPoint9_txtY4.Text = "";
            this.MultiPoint9_txtY4.TrailingIcon = null;
            // 
            // MultiPoint9_txtY3
            // 
            this.MultiPoint9_txtY3.AnimateReadOnly = false;
            this.MultiPoint9_txtY3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY3.Depth = 0;
            this.MultiPoint9_txtY3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY3.Hint = "Y";
            this.MultiPoint9_txtY3.LeadingIcon = null;
            this.MultiPoint9_txtY3.Location = new System.Drawing.Point(217, 118);
            this.MultiPoint9_txtY3.MaxLength = 50;
            this.MultiPoint9_txtY3.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY3.Multiline = false;
            this.MultiPoint9_txtY3.Name = "MultiPoint9_txtY3";
            this.MultiPoint9_txtY3.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY3.TabIndex = 10;
            this.MultiPoint9_txtY3.Text = "";
            this.MultiPoint9_txtY3.TrailingIcon = null;
            // 
            // MultiPoint9_txtY2
            // 
            this.MultiPoint9_txtY2.AnimateReadOnly = false;
            this.MultiPoint9_txtY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY2.Depth = 0;
            this.MultiPoint9_txtY2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY2.Hint = "Y";
            this.MultiPoint9_txtY2.LeadingIcon = null;
            this.MultiPoint9_txtY2.Location = new System.Drawing.Point(217, 62);
            this.MultiPoint9_txtY2.MaxLength = 50;
            this.MultiPoint9_txtY2.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY2.Multiline = false;
            this.MultiPoint9_txtY2.Name = "MultiPoint9_txtY2";
            this.MultiPoint9_txtY2.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY2.TabIndex = 10;
            this.MultiPoint9_txtY2.Text = "";
            this.MultiPoint9_txtY2.TrailingIcon = null;
            // 
            // MultiPoint9_txtY1
            // 
            this.MultiPoint9_txtY1.AnimateReadOnly = false;
            this.MultiPoint9_txtY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint9_txtY1.Depth = 0;
            this.MultiPoint9_txtY1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint9_txtY1.Hint = "Y";
            this.MultiPoint9_txtY1.LeadingIcon = null;
            this.MultiPoint9_txtY1.Location = new System.Drawing.Point(217, 6);
            this.MultiPoint9_txtY1.MaxLength = 50;
            this.MultiPoint9_txtY1.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint9_txtY1.Multiline = false;
            this.MultiPoint9_txtY1.Name = "MultiPoint9_txtY1";
            this.MultiPoint9_txtY1.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint9_txtY1.TabIndex = 10;
            this.MultiPoint9_txtY1.Text = "";
            this.MultiPoint9_txtY1.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.White;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel9.ForeColor = System.Drawing.Color.Black;
            this.materialLabel9.Location = new System.Drawing.Point(49, 487);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(47, 17);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Point9:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.White;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel8.ForeColor = System.Drawing.Color.Black;
            this.materialLabel8.Location = new System.Drawing.Point(49, 431);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(47, 17);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Point8:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.White;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel7.ForeColor = System.Drawing.Color.Black;
            this.materialLabel7.Location = new System.Drawing.Point(49, 375);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(47, 17);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Point7:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.White;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel6.ForeColor = System.Drawing.Color.Black;
            this.materialLabel6.Location = new System.Drawing.Point(49, 319);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 17);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Point6:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel5.ForeColor = System.Drawing.Color.Black;
            this.materialLabel5.Location = new System.Drawing.Point(49, 263);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 17);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Point5:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.ForeColor = System.Drawing.Color.Black;
            this.materialLabel4.Location = new System.Drawing.Point(49, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 17);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Point4:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.ForeColor = System.Drawing.Color.Black;
            this.materialLabel3.Location = new System.Drawing.Point(49, 151);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 17);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Point3:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.ForeColor = System.Drawing.Color.Black;
            this.materialLabel2.Location = new System.Drawing.Point(49, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 17);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Point2:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(49, 39);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 17);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Point1:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MultiPoint12_btnCapture);
            this.tabPage2.Controls.Add(this.MultiPoint12_btnCreate);
            this.tabPage2.Controls.Add(this.materialLabel21);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX12);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY12);
            this.tabPage2.Controls.Add(this.materialLabel20);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX11);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY11);
            this.tabPage2.Controls.Add(this.materialLabel19);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX10);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY10);
            this.tabPage2.Controls.Add(this.materialLabel18);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX9);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX8);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX7);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX6);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX5);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX4);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX3);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX2);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtX1);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY9);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY8);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY7);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY6);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY5);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY4);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY3);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY2);
            this.tabPage2.Controls.Add(this.MultiPoint12_txtY1);
            this.tabPage2.Controls.Add(this.materialLabel10);
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.materialLabel12);
            this.tabPage2.Controls.Add(this.materialLabel13);
            this.tabPage2.Controls.Add(this.materialLabel14);
            this.tabPage2.Controls.Add(this.materialLabel15);
            this.tabPage2.Controls.Add(this.materialLabel16);
            this.tabPage2.Controls.Add(this.materialLabel17);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "12点标定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MultiPoint12_btnCapture
            // 
            this.MultiPoint12_btnCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MultiPoint12_btnCapture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MultiPoint12_btnCapture.Depth = 0;
            this.MultiPoint12_btnCapture.HighEmphasis = true;
            this.MultiPoint12_btnCapture.Icon = null;
            this.MultiPoint12_btnCapture.Location = new System.Drawing.Point(103, 681);
            this.MultiPoint12_btnCapture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MultiPoint12_btnCapture.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiPoint12_btnCapture.Name = "MultiPoint12_btnCapture";
            this.MultiPoint12_btnCapture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MultiPoint12_btnCapture.Size = new System.Drawing.Size(64, 36);
            this.MultiPoint12_btnCapture.TabIndex = 49;
            this.MultiPoint12_btnCapture.Text = "采集";
            this.MultiPoint12_btnCapture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MultiPoint12_btnCapture.UseAccentColor = false;
            this.MultiPoint12_btnCapture.UseVisualStyleBackColor = true;
            // 
            // MultiPoint12_btnCreate
            // 
            this.MultiPoint12_btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MultiPoint12_btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MultiPoint12_btnCreate.Depth = 0;
            this.MultiPoint12_btnCreate.HighEmphasis = true;
            this.MultiPoint12_btnCreate.Icon = null;
            this.MultiPoint12_btnCreate.Location = new System.Drawing.Point(175, 681);
            this.MultiPoint12_btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MultiPoint12_btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiPoint12_btnCreate.Name = "MultiPoint12_btnCreate";
            this.MultiPoint12_btnCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MultiPoint12_btnCreate.Size = new System.Drawing.Size(64, 36);
            this.MultiPoint12_btnCreate.TabIndex = 48;
            this.MultiPoint12_btnCreate.Text = "生成";
            this.MultiPoint12_btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MultiPoint12_btnCreate.UseAccentColor = false;
            this.MultiPoint12_btnCreate.UseVisualStyleBackColor = true;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.BackColor = System.Drawing.Color.White;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel21.ForeColor = System.Drawing.Color.Black;
            this.materialLabel21.Location = new System.Drawing.Point(49, 655);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(55, 17);
            this.materialLabel21.TabIndex = 47;
            this.materialLabel21.Text = "Point12:";
            // 
            // MultiPoint12_txtX12
            // 
            this.MultiPoint12_txtX12.AnimateReadOnly = false;
            this.MultiPoint12_txtX12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX12.Depth = 0;
            this.MultiPoint12_txtX12.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX12.Hint = "X";
            this.MultiPoint12_txtX12.LeadingIcon = null;
            this.MultiPoint12_txtX12.Location = new System.Drawing.Point(102, 622);
            this.MultiPoint12_txtX12.MaxLength = 50;
            this.MultiPoint12_txtX12.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX12.Multiline = false;
            this.MultiPoint12_txtX12.Name = "MultiPoint12_txtX12";
            this.MultiPoint12_txtX12.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX12.TabIndex = 46;
            this.MultiPoint12_txtX12.Text = "";
            this.MultiPoint12_txtX12.TrailingIcon = null;
            // 
            // MultiPoint12_txtY12
            // 
            this.MultiPoint12_txtY12.AnimateReadOnly = false;
            this.MultiPoint12_txtY12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY12.Depth = 0;
            this.MultiPoint12_txtY12.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY12.Hint = "Y";
            this.MultiPoint12_txtY12.LeadingIcon = null;
            this.MultiPoint12_txtY12.Location = new System.Drawing.Point(217, 622);
            this.MultiPoint12_txtY12.MaxLength = 50;
            this.MultiPoint12_txtY12.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY12.Multiline = false;
            this.MultiPoint12_txtY12.Name = "MultiPoint12_txtY12";
            this.MultiPoint12_txtY12.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY12.TabIndex = 45;
            this.MultiPoint12_txtY12.Text = "";
            this.MultiPoint12_txtY12.TrailingIcon = null;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.BackColor = System.Drawing.Color.White;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel20.ForeColor = System.Drawing.Color.Black;
            this.materialLabel20.Location = new System.Drawing.Point(49, 599);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(55, 17);
            this.materialLabel20.TabIndex = 44;
            this.materialLabel20.Text = "Point11:";
            // 
            // MultiPoint12_txtX11
            // 
            this.MultiPoint12_txtX11.AnimateReadOnly = false;
            this.MultiPoint12_txtX11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX11.Depth = 0;
            this.MultiPoint12_txtX11.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX11.Hint = "X";
            this.MultiPoint12_txtX11.LeadingIcon = null;
            this.MultiPoint12_txtX11.Location = new System.Drawing.Point(102, 566);
            this.MultiPoint12_txtX11.MaxLength = 50;
            this.MultiPoint12_txtX11.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX11.Multiline = false;
            this.MultiPoint12_txtX11.Name = "MultiPoint12_txtX11";
            this.MultiPoint12_txtX11.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX11.TabIndex = 43;
            this.MultiPoint12_txtX11.Text = "";
            this.MultiPoint12_txtX11.TrailingIcon = null;
            // 
            // MultiPoint12_txtY11
            // 
            this.MultiPoint12_txtY11.AnimateReadOnly = false;
            this.MultiPoint12_txtY11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY11.Depth = 0;
            this.MultiPoint12_txtY11.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY11.Hint = "Y";
            this.MultiPoint12_txtY11.LeadingIcon = null;
            this.MultiPoint12_txtY11.Location = new System.Drawing.Point(217, 566);
            this.MultiPoint12_txtY11.MaxLength = 50;
            this.MultiPoint12_txtY11.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY11.Multiline = false;
            this.MultiPoint12_txtY11.Name = "MultiPoint12_txtY11";
            this.MultiPoint12_txtY11.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY11.TabIndex = 42;
            this.MultiPoint12_txtY11.Text = "";
            this.MultiPoint12_txtY11.TrailingIcon = null;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.BackColor = System.Drawing.Color.White;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel19.ForeColor = System.Drawing.Color.Black;
            this.materialLabel19.Location = new System.Drawing.Point(49, 543);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(55, 17);
            this.materialLabel19.TabIndex = 41;
            this.materialLabel19.Text = "Point10:";
            // 
            // MultiPoint12_txtX10
            // 
            this.MultiPoint12_txtX10.AnimateReadOnly = false;
            this.MultiPoint12_txtX10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX10.Depth = 0;
            this.MultiPoint12_txtX10.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX10.Hint = "X";
            this.MultiPoint12_txtX10.LeadingIcon = null;
            this.MultiPoint12_txtX10.Location = new System.Drawing.Point(102, 510);
            this.MultiPoint12_txtX10.MaxLength = 50;
            this.MultiPoint12_txtX10.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX10.Multiline = false;
            this.MultiPoint12_txtX10.Name = "MultiPoint12_txtX10";
            this.MultiPoint12_txtX10.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX10.TabIndex = 40;
            this.MultiPoint12_txtX10.Text = "";
            this.MultiPoint12_txtX10.TrailingIcon = null;
            // 
            // MultiPoint12_txtY10
            // 
            this.MultiPoint12_txtY10.AnimateReadOnly = false;
            this.MultiPoint12_txtY10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY10.Depth = 0;
            this.MultiPoint12_txtY10.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY10.Hint = "Y";
            this.MultiPoint12_txtY10.LeadingIcon = null;
            this.MultiPoint12_txtY10.Location = new System.Drawing.Point(217, 510);
            this.MultiPoint12_txtY10.MaxLength = 50;
            this.MultiPoint12_txtY10.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY10.Multiline = false;
            this.MultiPoint12_txtY10.Name = "MultiPoint12_txtY10";
            this.MultiPoint12_txtY10.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY10.TabIndex = 39;
            this.MultiPoint12_txtY10.Text = "";
            this.MultiPoint12_txtY10.TrailingIcon = null;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.BackColor = System.Drawing.Color.White;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel18.ForeColor = System.Drawing.Color.Black;
            this.materialLabel18.Location = new System.Drawing.Point(49, 487);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(47, 17);
            this.materialLabel18.TabIndex = 38;
            this.materialLabel18.Text = "Point9:";
            // 
            // MultiPoint12_txtX9
            // 
            this.MultiPoint12_txtX9.AnimateReadOnly = false;
            this.MultiPoint12_txtX9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX9.Depth = 0;
            this.MultiPoint12_txtX9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX9.Hint = "X";
            this.MultiPoint12_txtX9.LeadingIcon = null;
            this.MultiPoint12_txtX9.Location = new System.Drawing.Point(102, 454);
            this.MultiPoint12_txtX9.MaxLength = 50;
            this.MultiPoint12_txtX9.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX9.Multiline = false;
            this.MultiPoint12_txtX9.Name = "MultiPoint12_txtX9";
            this.MultiPoint12_txtX9.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX9.TabIndex = 37;
            this.MultiPoint12_txtX9.Text = "";
            this.MultiPoint12_txtX9.TrailingIcon = null;
            // 
            // MultiPoint12_txtX8
            // 
            this.MultiPoint12_txtX8.AnimateReadOnly = false;
            this.MultiPoint12_txtX8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX8.Depth = 0;
            this.MultiPoint12_txtX8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX8.Hint = "X";
            this.MultiPoint12_txtX8.LeadingIcon = null;
            this.MultiPoint12_txtX8.Location = new System.Drawing.Point(102, 398);
            this.MultiPoint12_txtX8.MaxLength = 50;
            this.MultiPoint12_txtX8.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX8.Multiline = false;
            this.MultiPoint12_txtX8.Name = "MultiPoint12_txtX8";
            this.MultiPoint12_txtX8.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX8.TabIndex = 36;
            this.MultiPoint12_txtX8.Text = "";
            this.MultiPoint12_txtX8.TrailingIcon = null;
            // 
            // MultiPoint12_txtX7
            // 
            this.MultiPoint12_txtX7.AnimateReadOnly = false;
            this.MultiPoint12_txtX7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX7.Depth = 0;
            this.MultiPoint12_txtX7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX7.Hint = "X";
            this.MultiPoint12_txtX7.LeadingIcon = null;
            this.MultiPoint12_txtX7.Location = new System.Drawing.Point(102, 342);
            this.MultiPoint12_txtX7.MaxLength = 50;
            this.MultiPoint12_txtX7.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX7.Multiline = false;
            this.MultiPoint12_txtX7.Name = "MultiPoint12_txtX7";
            this.MultiPoint12_txtX7.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX7.TabIndex = 35;
            this.MultiPoint12_txtX7.Text = "";
            this.MultiPoint12_txtX7.TrailingIcon = null;
            // 
            // MultiPoint12_txtX6
            // 
            this.MultiPoint12_txtX6.AnimateReadOnly = false;
            this.MultiPoint12_txtX6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX6.Depth = 0;
            this.MultiPoint12_txtX6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX6.Hint = "X";
            this.MultiPoint12_txtX6.LeadingIcon = null;
            this.MultiPoint12_txtX6.Location = new System.Drawing.Point(102, 286);
            this.MultiPoint12_txtX6.MaxLength = 50;
            this.MultiPoint12_txtX6.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX6.Multiline = false;
            this.MultiPoint12_txtX6.Name = "MultiPoint12_txtX6";
            this.MultiPoint12_txtX6.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX6.TabIndex = 34;
            this.MultiPoint12_txtX6.Text = "";
            this.MultiPoint12_txtX6.TrailingIcon = null;
            // 
            // MultiPoint12_txtX5
            // 
            this.MultiPoint12_txtX5.AnimateReadOnly = false;
            this.MultiPoint12_txtX5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX5.Depth = 0;
            this.MultiPoint12_txtX5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX5.Hint = "X";
            this.MultiPoint12_txtX5.LeadingIcon = null;
            this.MultiPoint12_txtX5.Location = new System.Drawing.Point(102, 230);
            this.MultiPoint12_txtX5.MaxLength = 50;
            this.MultiPoint12_txtX5.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX5.Multiline = false;
            this.MultiPoint12_txtX5.Name = "MultiPoint12_txtX5";
            this.MultiPoint12_txtX5.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX5.TabIndex = 33;
            this.MultiPoint12_txtX5.Text = "";
            this.MultiPoint12_txtX5.TrailingIcon = null;
            // 
            // MultiPoint12_txtX4
            // 
            this.MultiPoint12_txtX4.AnimateReadOnly = false;
            this.MultiPoint12_txtX4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX4.Depth = 0;
            this.MultiPoint12_txtX4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX4.Hint = "X";
            this.MultiPoint12_txtX4.LeadingIcon = null;
            this.MultiPoint12_txtX4.Location = new System.Drawing.Point(102, 174);
            this.MultiPoint12_txtX4.MaxLength = 50;
            this.MultiPoint12_txtX4.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX4.Multiline = false;
            this.MultiPoint12_txtX4.Name = "MultiPoint12_txtX4";
            this.MultiPoint12_txtX4.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX4.TabIndex = 32;
            this.MultiPoint12_txtX4.Text = "";
            this.MultiPoint12_txtX4.TrailingIcon = null;
            // 
            // MultiPoint12_txtX3
            // 
            this.MultiPoint12_txtX3.AnimateReadOnly = false;
            this.MultiPoint12_txtX3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX3.Depth = 0;
            this.MultiPoint12_txtX3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX3.Hint = "X";
            this.MultiPoint12_txtX3.LeadingIcon = null;
            this.MultiPoint12_txtX3.Location = new System.Drawing.Point(102, 118);
            this.MultiPoint12_txtX3.MaxLength = 50;
            this.MultiPoint12_txtX3.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX3.Multiline = false;
            this.MultiPoint12_txtX3.Name = "MultiPoint12_txtX3";
            this.MultiPoint12_txtX3.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX3.TabIndex = 31;
            this.MultiPoint12_txtX3.Text = "";
            this.MultiPoint12_txtX3.TrailingIcon = null;
            // 
            // MultiPoint12_txtX2
            // 
            this.MultiPoint12_txtX2.AnimateReadOnly = false;
            this.MultiPoint12_txtX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX2.Depth = 0;
            this.MultiPoint12_txtX2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX2.Hint = "X";
            this.MultiPoint12_txtX2.LeadingIcon = null;
            this.MultiPoint12_txtX2.Location = new System.Drawing.Point(102, 62);
            this.MultiPoint12_txtX2.MaxLength = 50;
            this.MultiPoint12_txtX2.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX2.Multiline = false;
            this.MultiPoint12_txtX2.Name = "MultiPoint12_txtX2";
            this.MultiPoint12_txtX2.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX2.TabIndex = 30;
            this.MultiPoint12_txtX2.Text = "";
            this.MultiPoint12_txtX2.TrailingIcon = null;
            // 
            // MultiPoint12_txtX1
            // 
            this.MultiPoint12_txtX1.AnimateReadOnly = false;
            this.MultiPoint12_txtX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtX1.Depth = 0;
            this.MultiPoint12_txtX1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtX1.Hint = "X";
            this.MultiPoint12_txtX1.LeadingIcon = null;
            this.MultiPoint12_txtX1.Location = new System.Drawing.Point(102, 6);
            this.MultiPoint12_txtX1.MaxLength = 50;
            this.MultiPoint12_txtX1.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtX1.Multiline = false;
            this.MultiPoint12_txtX1.Name = "MultiPoint12_txtX1";
            this.MultiPoint12_txtX1.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtX1.TabIndex = 29;
            this.MultiPoint12_txtX1.Text = "";
            this.MultiPoint12_txtX1.TrailingIcon = null;
            // 
            // MultiPoint12_txtY9
            // 
            this.MultiPoint12_txtY9.AnimateReadOnly = false;
            this.MultiPoint12_txtY9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY9.Depth = 0;
            this.MultiPoint12_txtY9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY9.Hint = "Y";
            this.MultiPoint12_txtY9.LeadingIcon = null;
            this.MultiPoint12_txtY9.Location = new System.Drawing.Point(217, 454);
            this.MultiPoint12_txtY9.MaxLength = 50;
            this.MultiPoint12_txtY9.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY9.Multiline = false;
            this.MultiPoint12_txtY9.Name = "MultiPoint12_txtY9";
            this.MultiPoint12_txtY9.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY9.TabIndex = 27;
            this.MultiPoint12_txtY9.Text = "";
            this.MultiPoint12_txtY9.TrailingIcon = null;
            // 
            // MultiPoint12_txtY8
            // 
            this.MultiPoint12_txtY8.AnimateReadOnly = false;
            this.MultiPoint12_txtY8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY8.Depth = 0;
            this.MultiPoint12_txtY8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY8.Hint = "Y";
            this.MultiPoint12_txtY8.LeadingIcon = null;
            this.MultiPoint12_txtY8.Location = new System.Drawing.Point(217, 398);
            this.MultiPoint12_txtY8.MaxLength = 50;
            this.MultiPoint12_txtY8.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY8.Multiline = false;
            this.MultiPoint12_txtY8.Name = "MultiPoint12_txtY8";
            this.MultiPoint12_txtY8.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY8.TabIndex = 26;
            this.MultiPoint12_txtY8.Text = "";
            this.MultiPoint12_txtY8.TrailingIcon = null;
            // 
            // MultiPoint12_txtY7
            // 
            this.MultiPoint12_txtY7.AnimateReadOnly = false;
            this.MultiPoint12_txtY7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY7.Depth = 0;
            this.MultiPoint12_txtY7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY7.Hint = "Y";
            this.MultiPoint12_txtY7.LeadingIcon = null;
            this.MultiPoint12_txtY7.Location = new System.Drawing.Point(217, 342);
            this.MultiPoint12_txtY7.MaxLength = 50;
            this.MultiPoint12_txtY7.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY7.Multiline = false;
            this.MultiPoint12_txtY7.Name = "MultiPoint12_txtY7";
            this.MultiPoint12_txtY7.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY7.TabIndex = 28;
            this.MultiPoint12_txtY7.Text = "";
            this.MultiPoint12_txtY7.TrailingIcon = null;
            // 
            // MultiPoint12_txtY6
            // 
            this.MultiPoint12_txtY6.AnimateReadOnly = false;
            this.MultiPoint12_txtY6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY6.Depth = 0;
            this.MultiPoint12_txtY6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY6.Hint = "Y";
            this.MultiPoint12_txtY6.LeadingIcon = null;
            this.MultiPoint12_txtY6.Location = new System.Drawing.Point(217, 286);
            this.MultiPoint12_txtY6.MaxLength = 50;
            this.MultiPoint12_txtY6.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY6.Multiline = false;
            this.MultiPoint12_txtY6.Name = "MultiPoint12_txtY6";
            this.MultiPoint12_txtY6.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY6.TabIndex = 25;
            this.MultiPoint12_txtY6.Text = "";
            this.MultiPoint12_txtY6.TrailingIcon = null;
            // 
            // MultiPoint12_txtY5
            // 
            this.MultiPoint12_txtY5.AnimateReadOnly = false;
            this.MultiPoint12_txtY5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY5.Depth = 0;
            this.MultiPoint12_txtY5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY5.Hint = "Y";
            this.MultiPoint12_txtY5.LeadingIcon = null;
            this.MultiPoint12_txtY5.Location = new System.Drawing.Point(217, 230);
            this.MultiPoint12_txtY5.MaxLength = 50;
            this.MultiPoint12_txtY5.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY5.Multiline = false;
            this.MultiPoint12_txtY5.Name = "MultiPoint12_txtY5";
            this.MultiPoint12_txtY5.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY5.TabIndex = 24;
            this.MultiPoint12_txtY5.Text = "";
            this.MultiPoint12_txtY5.TrailingIcon = null;
            // 
            // MultiPoint12_txtY4
            // 
            this.MultiPoint12_txtY4.AnimateReadOnly = false;
            this.MultiPoint12_txtY4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY4.Depth = 0;
            this.MultiPoint12_txtY4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY4.Hint = "Y";
            this.MultiPoint12_txtY4.LeadingIcon = null;
            this.MultiPoint12_txtY4.Location = new System.Drawing.Point(217, 174);
            this.MultiPoint12_txtY4.MaxLength = 50;
            this.MultiPoint12_txtY4.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY4.Multiline = false;
            this.MultiPoint12_txtY4.Name = "MultiPoint12_txtY4";
            this.MultiPoint12_txtY4.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY4.TabIndex = 23;
            this.MultiPoint12_txtY4.Text = "";
            this.MultiPoint12_txtY4.TrailingIcon = null;
            // 
            // MultiPoint12_txtY3
            // 
            this.MultiPoint12_txtY3.AnimateReadOnly = false;
            this.MultiPoint12_txtY3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY3.Depth = 0;
            this.MultiPoint12_txtY3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY3.Hint = "Y";
            this.MultiPoint12_txtY3.LeadingIcon = null;
            this.MultiPoint12_txtY3.Location = new System.Drawing.Point(217, 118);
            this.MultiPoint12_txtY3.MaxLength = 50;
            this.MultiPoint12_txtY3.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY3.Multiline = false;
            this.MultiPoint12_txtY3.Name = "MultiPoint12_txtY3";
            this.MultiPoint12_txtY3.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY3.TabIndex = 22;
            this.MultiPoint12_txtY3.Text = "";
            this.MultiPoint12_txtY3.TrailingIcon = null;
            // 
            // MultiPoint12_txtY2
            // 
            this.MultiPoint12_txtY2.AnimateReadOnly = false;
            this.MultiPoint12_txtY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY2.Depth = 0;
            this.MultiPoint12_txtY2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY2.Hint = "Y";
            this.MultiPoint12_txtY2.LeadingIcon = null;
            this.MultiPoint12_txtY2.Location = new System.Drawing.Point(217, 62);
            this.MultiPoint12_txtY2.MaxLength = 50;
            this.MultiPoint12_txtY2.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY2.Multiline = false;
            this.MultiPoint12_txtY2.Name = "MultiPoint12_txtY2";
            this.MultiPoint12_txtY2.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY2.TabIndex = 21;
            this.MultiPoint12_txtY2.Text = "";
            this.MultiPoint12_txtY2.TrailingIcon = null;
            // 
            // MultiPoint12_txtY1
            // 
            this.MultiPoint12_txtY1.AnimateReadOnly = false;
            this.MultiPoint12_txtY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiPoint12_txtY1.Depth = 0;
            this.MultiPoint12_txtY1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiPoint12_txtY1.Hint = "Y";
            this.MultiPoint12_txtY1.LeadingIcon = null;
            this.MultiPoint12_txtY1.Location = new System.Drawing.Point(217, 6);
            this.MultiPoint12_txtY1.MaxLength = 50;
            this.MultiPoint12_txtY1.MouseState = MaterialSkin.MouseState.OUT;
            this.MultiPoint12_txtY1.Multiline = false;
            this.MultiPoint12_txtY1.Name = "MultiPoint12_txtY1";
            this.MultiPoint12_txtY1.Size = new System.Drawing.Size(100, 50);
            this.MultiPoint12_txtY1.TabIndex = 20;
            this.MultiPoint12_txtY1.Text = "";
            this.MultiPoint12_txtY1.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.White;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel10.ForeColor = System.Drawing.Color.Black;
            this.materialLabel10.Location = new System.Drawing.Point(49, 431);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(47, 17);
            this.materialLabel10.TabIndex = 19;
            this.materialLabel10.Text = "Point8:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.White;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel11.ForeColor = System.Drawing.Color.Black;
            this.materialLabel11.Location = new System.Drawing.Point(49, 375);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(47, 17);
            this.materialLabel11.TabIndex = 18;
            this.materialLabel11.Text = "Point7:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.White;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel12.ForeColor = System.Drawing.Color.Black;
            this.materialLabel12.Location = new System.Drawing.Point(49, 319);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(47, 17);
            this.materialLabel12.TabIndex = 17;
            this.materialLabel12.Text = "Point6:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.White;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel13.ForeColor = System.Drawing.Color.Black;
            this.materialLabel13.Location = new System.Drawing.Point(49, 263);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(47, 17);
            this.materialLabel13.TabIndex = 16;
            this.materialLabel13.Text = "Point5:";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.White;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel14.ForeColor = System.Drawing.Color.Black;
            this.materialLabel14.Location = new System.Drawing.Point(49, 207);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(47, 17);
            this.materialLabel14.TabIndex = 15;
            this.materialLabel14.Text = "Point4:";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.BackColor = System.Drawing.Color.White;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel15.ForeColor = System.Drawing.Color.Black;
            this.materialLabel15.Location = new System.Drawing.Point(49, 151);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(47, 17);
            this.materialLabel15.TabIndex = 14;
            this.materialLabel15.Text = "Point3:";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.White;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel16.ForeColor = System.Drawing.Color.Black;
            this.materialLabel16.Location = new System.Drawing.Point(49, 95);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(47, 17);
            this.materialLabel16.TabIndex = 13;
            this.materialLabel16.Text = "Point2:";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.BackColor = System.Drawing.Color.White;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel17.ForeColor = System.Drawing.Color.Black;
            this.materialLabel17.Location = new System.Drawing.Point(49, 39);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(47, 17);
            this.materialLabel17.TabIndex = 12;
            this.materialLabel17.Text = "Point1:";
            // 
            // hSmartWindowControl2
            // 
            this.hSmartWindowControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl2.HDoubleClickToFitContent = true;
            this.hSmartWindowControl2.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl2.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl2.HKeepAspectRatio = true;
            this.hSmartWindowControl2.HMoveContent = true;
            this.hSmartWindowControl2.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl2.Location = new System.Drawing.Point(-4, 44);
            this.hSmartWindowControl2.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl2.Name = "hSmartWindowControl2";
            this.hSmartWindowControl2.Size = new System.Drawing.Size(1181, 788);
            this.hSmartWindowControl2.TabIndex = 0;
            this.hSmartWindowControl2.WindowSize = new System.Drawing.Size(1181, 788);
            // 
            // DistortionCorrectionPage
            // 
            this.DistortionCorrectionPage.Controls.Add(this.hSmartWindowControl3);
            this.DistortionCorrectionPage.Controls.Add(this.materialSwitch1);
            this.DistortionCorrectionPage.Controls.Add(this.materialButton1);
            this.DistortionCorrectionPage.Controls.Add(this.Distortion_labCameraDataState);
            this.DistortionCorrectionPage.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DistortionCorrectionPage.ImageKey = "flip_camera_android_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.DistortionCorrectionPage.Location = new System.Drawing.Point(4, 39);
            this.DistortionCorrectionPage.Margin = new System.Windows.Forms.Padding(4);
            this.DistortionCorrectionPage.Name = "DistortionCorrectionPage";
            this.DistortionCorrectionPage.Size = new System.Drawing.Size(1617, 784);
            this.DistortionCorrectionPage.TabIndex = 3;
            this.DistortionCorrectionPage.Text = "畸变矫正";
            this.DistortionCorrectionPage.UseVisualStyleBackColor = true;
            // 
            // hSmartWindowControl3
            // 
            this.hSmartWindowControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl3.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl3.HDoubleClickToFitContent = true;
            this.hSmartWindowControl3.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl3.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl3.HKeepAspectRatio = true;
            this.hSmartWindowControl3.HMoveContent = true;
            this.hSmartWindowControl3.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl3.Location = new System.Drawing.Point(0, 68);
            this.hSmartWindowControl3.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl3.Name = "hSmartWindowControl3";
            this.hSmartWindowControl3.Size = new System.Drawing.Size(1555, 676);
            this.hSmartWindowControl3.TabIndex = 3;
            this.hSmartWindowControl3.WindowSize = new System.Drawing.Size(1555, 676);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(1391, 747);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(58, 37);
            this.materialSwitch1.TabIndex = 2;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(4, 26);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(65, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "选择...";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // Distortion_labCameraDataState
            // 
            this.Distortion_labCameraDataState.AutoSize = true;
            this.Distortion_labCameraDataState.Depth = 0;
            this.Distortion_labCameraDataState.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Distortion_labCameraDataState.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Distortion_labCameraDataState.Location = new System.Drawing.Point(76, 38);
            this.Distortion_labCameraDataState.MouseState = MaterialSkin.MouseState.HOVER;
            this.Distortion_labCameraDataState.Name = "Distortion_labCameraDataState";
            this.Distortion_labCameraDataState.Size = new System.Drawing.Size(121, 24);
            this.Distortion_labCameraDataState.TabIndex = 0;
            this.Distortion_labCameraDataState.Text = "相机参数为空";
            // 
            // CreateDescrFilePage
            // 
            this.CreateDescrFilePage.Controls.Add(this.Calibration_btnBack);
            this.CreateDescrFilePage.Controls.Add(this.hSmartWindowControl4);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_btnCreateDescrFile_Finsh);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_btnSaveDescrFileAddress);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_SaveDescrFileAddress);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_labFileParam);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_txtCenterLengthRate);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_txtCenterLength);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_ClomnPointNum);
            this.CreateDescrFilePage.Controls.Add(this.Calibration_txtRowPointNum);
            this.CreateDescrFilePage.ImageKey = "description_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.CreateDescrFilePage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CreateDescrFilePage.Location = new System.Drawing.Point(4, 39);
            this.CreateDescrFilePage.Name = "CreateDescrFilePage";
            this.CreateDescrFilePage.Size = new System.Drawing.Size(1617, 784);
            this.CreateDescrFilePage.TabIndex = 4;
            this.CreateDescrFilePage.Text = "创建标定板文件";
            this.CreateDescrFilePage.UseVisualStyleBackColor = true;
            // 
            // Calibration_btnBack
            // 
            this.Calibration_btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibration_btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibration_btnBack.Depth = 0;
            this.Calibration_btnBack.HighEmphasis = true;
            this.Calibration_btnBack.Icon = global::CamaraCalibration_Win.Properties.Resources.arrow_back_40dp_5F6368_FILL0_wght400_GRAD0_opsz40;
            this.Calibration_btnBack.Location = new System.Drawing.Point(29, 40);
            this.Calibration_btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibration_btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_btnBack.Name = "Calibration_btnBack";
            this.Calibration_btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibration_btnBack.Size = new System.Drawing.Size(87, 36);
            this.Calibration_btnBack.TabIndex = 20;
            this.Calibration_btnBack.Text = "Back";
            this.Calibration_btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibration_btnBack.UseAccentColor = false;
            this.Calibration_btnBack.UseVisualStyleBackColor = true;
            this.Calibration_btnBack.Click += new System.EventHandler(this.Calibration_btnBack_Click);
            // 
            // hSmartWindowControl4
            // 
            this.hSmartWindowControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl4.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl4.HDoubleClickToFitContent = true;
            this.hSmartWindowControl4.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl4.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl4.HKeepAspectRatio = true;
            this.hSmartWindowControl4.HMoveContent = true;
            this.hSmartWindowControl4.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl4.Location = new System.Drawing.Point(405, 22);
            this.hSmartWindowControl4.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl4.Name = "hSmartWindowControl4";
            this.hSmartWindowControl4.Size = new System.Drawing.Size(1149, 778);
            this.hSmartWindowControl4.TabIndex = 19;
            this.hSmartWindowControl4.WindowSize = new System.Drawing.Size(1149, 778);
            // 
            // Calibration_btnCreateDescrFile_Finsh
            // 
            this.Calibration_btnCreateDescrFile_Finsh.AutoSize = false;
            this.Calibration_btnCreateDescrFile_Finsh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibration_btnCreateDescrFile_Finsh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibration_btnCreateDescrFile_Finsh.Depth = 0;
            this.Calibration_btnCreateDescrFile_Finsh.HighEmphasis = true;
            this.Calibration_btnCreateDescrFile_Finsh.Icon = null;
            this.Calibration_btnCreateDescrFile_Finsh.Location = new System.Drawing.Point(19, 744);
            this.Calibration_btnCreateDescrFile_Finsh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibration_btnCreateDescrFile_Finsh.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_btnCreateDescrFile_Finsh.Name = "Calibration_btnCreateDescrFile_Finsh";
            this.Calibration_btnCreateDescrFile_Finsh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibration_btnCreateDescrFile_Finsh.Size = new System.Drawing.Size(345, 36);
            this.Calibration_btnCreateDescrFile_Finsh.TabIndex = 18;
            this.Calibration_btnCreateDescrFile_Finsh.Text = "选择";
            this.Calibration_btnCreateDescrFile_Finsh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibration_btnCreateDescrFile_Finsh.UseAccentColor = false;
            this.Calibration_btnCreateDescrFile_Finsh.UseVisualStyleBackColor = true;
            // 
            // Calibration_btnSaveDescrFileAddress
            // 
            this.Calibration_btnSaveDescrFileAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibration_btnSaveDescrFileAddress.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibration_btnSaveDescrFileAddress.Depth = 0;
            this.Calibration_btnSaveDescrFileAddress.HighEmphasis = true;
            this.Calibration_btnSaveDescrFileAddress.Icon = null;
            this.Calibration_btnSaveDescrFileAddress.Location = new System.Drawing.Point(300, 360);
            this.Calibration_btnSaveDescrFileAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibration_btnSaveDescrFileAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_btnSaveDescrFileAddress.Name = "Calibration_btnSaveDescrFileAddress";
            this.Calibration_btnSaveDescrFileAddress.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibration_btnSaveDescrFileAddress.Size = new System.Drawing.Size(64, 36);
            this.Calibration_btnSaveDescrFileAddress.TabIndex = 17;
            this.Calibration_btnSaveDescrFileAddress.Text = "选择";
            this.Calibration_btnSaveDescrFileAddress.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibration_btnSaveDescrFileAddress.UseAccentColor = false;
            this.Calibration_btnSaveDescrFileAddress.UseVisualStyleBackColor = true;
            // 
            // Calibration_SaveDescrFileAddress
            // 
            this.Calibration_SaveDescrFileAddress.AnimateReadOnly = false;
            this.Calibration_SaveDescrFileAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_SaveDescrFileAddress.Depth = 0;
            this.Calibration_SaveDescrFileAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_SaveDescrFileAddress.ForeColor = System.Drawing.Color.White;
            this.Calibration_SaveDescrFileAddress.Hint = "保存文件路径";
            this.Calibration_SaveDescrFileAddress.LeadingIcon = null;
            this.Calibration_SaveDescrFileAddress.Location = new System.Drawing.Point(19, 346);
            this.Calibration_SaveDescrFileAddress.MaxLength = 50;
            this.Calibration_SaveDescrFileAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_SaveDescrFileAddress.Multiline = false;
            this.Calibration_SaveDescrFileAddress.Name = "Calibration_SaveDescrFileAddress";
            this.Calibration_SaveDescrFileAddress.Size = new System.Drawing.Size(274, 50);
            this.Calibration_SaveDescrFileAddress.TabIndex = 16;
            this.Calibration_SaveDescrFileAddress.Text = "";
            this.Calibration_SaveDescrFileAddress.TrailingIcon = null;
            // 
            // Calibration_labFileParam
            // 
            this.Calibration_labFileParam.AutoSize = true;
            this.Calibration_labFileParam.BackColor = System.Drawing.Color.White;
            this.Calibration_labFileParam.Depth = 0;
            this.Calibration_labFileParam.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_labFileParam.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.Calibration_labFileParam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calibration_labFileParam.Location = new System.Drawing.Point(123, 18);
            this.Calibration_labFileParam.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibration_labFileParam.Name = "Calibration_labFileParam";
            this.Calibration_labFileParam.Size = new System.Drawing.Size(241, 72);
            this.Calibration_labFileParam.TabIndex = 15;
            this.Calibration_labFileParam.Text = "文件参数";
            this.Calibration_labFileParam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Calibration_txtCenterLengthRate
            // 
            this.Calibration_txtCenterLengthRate.AnimateReadOnly = false;
            this.Calibration_txtCenterLengthRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtCenterLengthRate.Depth = 0;
            this.Calibration_txtCenterLengthRate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtCenterLengthRate.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtCenterLengthRate.Hint = "中心距离比值";
            this.Calibration_txtCenterLengthRate.LeadingIcon = null;
            this.Calibration_txtCenterLengthRate.Location = new System.Drawing.Point(19, 290);
            this.Calibration_txtCenterLengthRate.MaxLength = 50;
            this.Calibration_txtCenterLengthRate.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtCenterLengthRate.Multiline = false;
            this.Calibration_txtCenterLengthRate.Name = "Calibration_txtCenterLengthRate";
            this.Calibration_txtCenterLengthRate.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtCenterLengthRate.TabIndex = 14;
            this.Calibration_txtCenterLengthRate.Text = "";
            this.Calibration_txtCenterLengthRate.TrailingIcon = null;
            // 
            // Calibration_txtCenterLength
            // 
            this.Calibration_txtCenterLength.AnimateReadOnly = false;
            this.Calibration_txtCenterLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtCenterLength.Depth = 0;
            this.Calibration_txtCenterLength.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtCenterLength.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtCenterLength.Hint = "中心间距(m)";
            this.Calibration_txtCenterLength.LeadingIcon = null;
            this.Calibration_txtCenterLength.Location = new System.Drawing.Point(19, 234);
            this.Calibration_txtCenterLength.MaxLength = 50;
            this.Calibration_txtCenterLength.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtCenterLength.Multiline = false;
            this.Calibration_txtCenterLength.Name = "Calibration_txtCenterLength";
            this.Calibration_txtCenterLength.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtCenterLength.TabIndex = 13;
            this.Calibration_txtCenterLength.Text = "";
            this.Calibration_txtCenterLength.TrailingIcon = null;
            // 
            // Calibration_ClomnPointNum
            // 
            this.Calibration_ClomnPointNum.AnimateReadOnly = false;
            this.Calibration_ClomnPointNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_ClomnPointNum.Depth = 0;
            this.Calibration_ClomnPointNum.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_ClomnPointNum.ForeColor = System.Drawing.Color.White;
            this.Calibration_ClomnPointNum.Hint = "列圆点数量";
            this.Calibration_ClomnPointNum.LeadingIcon = null;
            this.Calibration_ClomnPointNum.Location = new System.Drawing.Point(19, 178);
            this.Calibration_ClomnPointNum.MaxLength = 50;
            this.Calibration_ClomnPointNum.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_ClomnPointNum.Multiline = false;
            this.Calibration_ClomnPointNum.Name = "Calibration_ClomnPointNum";
            this.Calibration_ClomnPointNum.Size = new System.Drawing.Size(345, 50);
            this.Calibration_ClomnPointNum.TabIndex = 12;
            this.Calibration_ClomnPointNum.Text = "";
            this.Calibration_ClomnPointNum.TrailingIcon = null;
            // 
            // Calibration_txtRowPointNum
            // 
            this.Calibration_txtRowPointNum.AnimateReadOnly = false;
            this.Calibration_txtRowPointNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calibration_txtRowPointNum.Depth = 0;
            this.Calibration_txtRowPointNum.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibration_txtRowPointNum.ForeColor = System.Drawing.Color.White;
            this.Calibration_txtRowPointNum.Hint = "行圆点数量";
            this.Calibration_txtRowPointNum.LeadingIcon = null;
            this.Calibration_txtRowPointNum.Location = new System.Drawing.Point(19, 122);
            this.Calibration_txtRowPointNum.MaxLength = 50;
            this.Calibration_txtRowPointNum.MouseState = MaterialSkin.MouseState.OUT;
            this.Calibration_txtRowPointNum.Multiline = false;
            this.Calibration_txtRowPointNum.Name = "Calibration_txtRowPointNum";
            this.Calibration_txtRowPointNum.Size = new System.Drawing.Size(345, 50);
            this.Calibration_txtRowPointNum.TabIndex = 11;
            this.Calibration_txtRowPointNum.Text = "";
            this.Calibration_txtRowPointNum.TrailingIcon = null;
            // 
            // CamaraParamPage
            // 
            this.CamaraParamPage.Controls.Add(this.materialTabControl2);
            this.CamaraParamPage.Controls.Add(this.materialTabSelector2);
            this.CamaraParamPage.ImageKey = "monochrome_photos_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.CamaraParamPage.Location = new System.Drawing.Point(4, 39);
            this.CamaraParamPage.Name = "CamaraParamPage";
            this.CamaraParamPage.Size = new System.Drawing.Size(1617, 784);
            this.CamaraParamPage.TabIndex = 5;
            this.CamaraParamPage.Text = "相机参数";
            this.CamaraParamPage.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(6, 88);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1611, 724);
            this.materialTabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CameraParam_btnSaveData);
            this.tabPage3.Controls.Add(this.CameraParam_txtImageHight);
            this.tabPage3.Controls.Add(this.CameraParam_txtKappa);
            this.tabPage3.Controls.Add(this.CameraParam_txtImageWidth);
            this.tabPage3.Controls.Add(this.CameraParam_txtFocalLength);
            this.tabPage3.Controls.Add(this.CameraParam_txtCenterY);
            this.tabPage3.Controls.Add(this.CameraParam_txtSiglePixelHight);
            this.tabPage3.Controls.Add(this.CameraParam_txtCenterX);
            this.tabPage3.Controls.Add(this.CameraParam_txtSiglePixelWidth);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1603, 695);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "相机内参";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CameraParam_btnSaveData
            // 
            this.CameraParam_btnSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CameraParam_btnSaveData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CameraParam_btnSaveData.Depth = 0;
            this.CameraParam_btnSaveData.HighEmphasis = true;
            this.CameraParam_btnSaveData.Icon = null;
            this.CameraParam_btnSaveData.Location = new System.Drawing.Point(1326, 653);
            this.CameraParam_btnSaveData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CameraParam_btnSaveData.MouseState = MaterialSkin.MouseState.HOVER;
            this.CameraParam_btnSaveData.Name = "CameraParam_btnSaveData";
            this.CameraParam_btnSaveData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CameraParam_btnSaveData.Size = new System.Drawing.Size(64, 36);
            this.CameraParam_btnSaveData.TabIndex = 9;
            this.CameraParam_btnSaveData.Text = "保存";
            this.CameraParam_btnSaveData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CameraParam_btnSaveData.UseAccentColor = false;
            this.CameraParam_btnSaveData.UseVisualStyleBackColor = true;
            // 
            // CameraParam_txtImageHight
            // 
            this.CameraParam_txtImageHight.AnimateReadOnly = false;
            this.CameraParam_txtImageHight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtImageHight.Depth = 0;
            this.CameraParam_txtImageHight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtImageHight.Hint = "图像高 (像素)";
            this.CameraParam_txtImageHight.LeadingIcon = null;
            this.CameraParam_txtImageHight.Location = new System.Drawing.Point(375, 174);
            this.CameraParam_txtImageHight.MaxLength = 50;
            this.CameraParam_txtImageHight.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtImageHight.Multiline = false;
            this.CameraParam_txtImageHight.Name = "CameraParam_txtImageHight";
            this.CameraParam_txtImageHight.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtImageHight.TabIndex = 7;
            this.CameraParam_txtImageHight.Text = "";
            this.CameraParam_txtImageHight.TrailingIcon = null;
            // 
            // CameraParam_txtKappa
            // 
            this.CameraParam_txtKappa.AnimateReadOnly = false;
            this.CameraParam_txtKappa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtKappa.Depth = 0;
            this.CameraParam_txtKappa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtKappa.Hint = "Kappa(1/平方米)";
            this.CameraParam_txtKappa.LeadingIcon = null;
            this.CameraParam_txtKappa.Location = new System.Drawing.Point(6, 174);
            this.CameraParam_txtKappa.MaxLength = 50;
            this.CameraParam_txtKappa.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtKappa.Multiline = false;
            this.CameraParam_txtKappa.Name = "CameraParam_txtKappa";
            this.CameraParam_txtKappa.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtKappa.TabIndex = 6;
            this.CameraParam_txtKappa.Text = "";
            this.CameraParam_txtKappa.TrailingIcon = null;
            // 
            // CameraParam_txtImageWidth
            // 
            this.CameraParam_txtImageWidth.AnimateReadOnly = false;
            this.CameraParam_txtImageWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtImageWidth.Depth = 0;
            this.CameraParam_txtImageWidth.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtImageWidth.Hint = "图像宽 (像素)";
            this.CameraParam_txtImageWidth.LeadingIcon = null;
            this.CameraParam_txtImageWidth.Location = new System.Drawing.Point(375, 118);
            this.CameraParam_txtImageWidth.MaxLength = 50;
            this.CameraParam_txtImageWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtImageWidth.Multiline = false;
            this.CameraParam_txtImageWidth.Name = "CameraParam_txtImageWidth";
            this.CameraParam_txtImageWidth.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtImageWidth.TabIndex = 5;
            this.CameraParam_txtImageWidth.Text = "";
            this.CameraParam_txtImageWidth.TrailingIcon = null;
            // 
            // CameraParam_txtFocalLength
            // 
            this.CameraParam_txtFocalLength.AnimateReadOnly = false;
            this.CameraParam_txtFocalLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtFocalLength.Depth = 0;
            this.CameraParam_txtFocalLength.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtFocalLength.Hint = "焦距 (mm)";
            this.CameraParam_txtFocalLength.LeadingIcon = null;
            this.CameraParam_txtFocalLength.Location = new System.Drawing.Point(6, 118);
            this.CameraParam_txtFocalLength.MaxLength = 50;
            this.CameraParam_txtFocalLength.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtFocalLength.Multiline = false;
            this.CameraParam_txtFocalLength.Name = "CameraParam_txtFocalLength";
            this.CameraParam_txtFocalLength.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtFocalLength.TabIndex = 4;
            this.CameraParam_txtFocalLength.Text = "";
            this.CameraParam_txtFocalLength.TrailingIcon = null;
            // 
            // CameraParam_txtCenterY
            // 
            this.CameraParam_txtCenterY.AnimateReadOnly = false;
            this.CameraParam_txtCenterY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtCenterY.Depth = 0;
            this.CameraParam_txtCenterY.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtCenterY.Hint = "中心点y坐标 (Cy) (像素)";
            this.CameraParam_txtCenterY.LeadingIcon = null;
            this.CameraParam_txtCenterY.Location = new System.Drawing.Point(375, 62);
            this.CameraParam_txtCenterY.MaxLength = 50;
            this.CameraParam_txtCenterY.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtCenterY.Multiline = false;
            this.CameraParam_txtCenterY.Name = "CameraParam_txtCenterY";
            this.CameraParam_txtCenterY.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtCenterY.TabIndex = 3;
            this.CameraParam_txtCenterY.Text = "";
            this.CameraParam_txtCenterY.TrailingIcon = null;
            // 
            // CameraParam_txtSiglePixelHight
            // 
            this.CameraParam_txtSiglePixelHight.AnimateReadOnly = false;
            this.CameraParam_txtSiglePixelHight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtSiglePixelHight.Depth = 0;
            this.CameraParam_txtSiglePixelHight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtSiglePixelHight.Hint = "单个像元的高";
            this.CameraParam_txtSiglePixelHight.LeadingIcon = null;
            this.CameraParam_txtSiglePixelHight.Location = new System.Drawing.Point(6, 62);
            this.CameraParam_txtSiglePixelHight.MaxLength = 50;
            this.CameraParam_txtSiglePixelHight.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtSiglePixelHight.Multiline = false;
            this.CameraParam_txtSiglePixelHight.Name = "CameraParam_txtSiglePixelHight";
            this.CameraParam_txtSiglePixelHight.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtSiglePixelHight.TabIndex = 2;
            this.CameraParam_txtSiglePixelHight.Text = "";
            this.CameraParam_txtSiglePixelHight.TrailingIcon = null;
            // 
            // CameraParam_txtCenterX
            // 
            this.CameraParam_txtCenterX.AnimateReadOnly = false;
            this.CameraParam_txtCenterX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtCenterX.Depth = 0;
            this.CameraParam_txtCenterX.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtCenterX.Hint = "中心点x坐标 (Cx) (像素)";
            this.CameraParam_txtCenterX.LeadingIcon = null;
            this.CameraParam_txtCenterX.Location = new System.Drawing.Point(375, 6);
            this.CameraParam_txtCenterX.MaxLength = 50;
            this.CameraParam_txtCenterX.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtCenterX.Multiline = false;
            this.CameraParam_txtCenterX.Name = "CameraParam_txtCenterX";
            this.CameraParam_txtCenterX.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtCenterX.TabIndex = 1;
            this.CameraParam_txtCenterX.Text = "";
            this.CameraParam_txtCenterX.TrailingIcon = null;
            // 
            // CameraParam_txtSiglePixelWidth
            // 
            this.CameraParam_txtSiglePixelWidth.AnimateReadOnly = false;
            this.CameraParam_txtSiglePixelWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtSiglePixelWidth.Depth = 0;
            this.CameraParam_txtSiglePixelWidth.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtSiglePixelWidth.Hint = "单个像元的宽";
            this.CameraParam_txtSiglePixelWidth.LeadingIcon = null;
            this.CameraParam_txtSiglePixelWidth.Location = new System.Drawing.Point(6, 6);
            this.CameraParam_txtSiglePixelWidth.MaxLength = 50;
            this.CameraParam_txtSiglePixelWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtSiglePixelWidth.Multiline = false;
            this.CameraParam_txtSiglePixelWidth.Name = "CameraParam_txtSiglePixelWidth";
            this.CameraParam_txtSiglePixelWidth.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtSiglePixelWidth.TabIndex = 0;
            this.CameraParam_txtSiglePixelWidth.Text = "";
            this.CameraParam_txtSiglePixelWidth.TrailingIcon = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CameraParam_btnSavePose);
            this.tabPage4.Controls.Add(this.CameraParam_ZSpin);
            this.tabPage4.Controls.Add(this.CameraParam_Z);
            this.tabPage4.Controls.Add(this.CameraParam_YSpin);
            this.tabPage4.Controls.Add(this.CameraParam_txtY);
            this.tabPage4.Controls.Add(this.CameraParam_XSpin);
            this.tabPage4.Controls.Add(this.CameraParam_txtX);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1603, 695);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "相机位姿";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CameraParam_btnSavePose
            // 
            this.CameraParam_btnSavePose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CameraParam_btnSavePose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CameraParam_btnSavePose.Depth = 0;
            this.CameraParam_btnSavePose.HighEmphasis = true;
            this.CameraParam_btnSavePose.Icon = null;
            this.CameraParam_btnSavePose.Location = new System.Drawing.Point(1326, 653);
            this.CameraParam_btnSavePose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CameraParam_btnSavePose.MouseState = MaterialSkin.MouseState.HOVER;
            this.CameraParam_btnSavePose.Name = "CameraParam_btnSavePose";
            this.CameraParam_btnSavePose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CameraParam_btnSavePose.Size = new System.Drawing.Size(64, 36);
            this.CameraParam_btnSavePose.TabIndex = 8;
            this.CameraParam_btnSavePose.Text = "保存";
            this.CameraParam_btnSavePose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CameraParam_btnSavePose.UseAccentColor = false;
            this.CameraParam_btnSavePose.UseVisualStyleBackColor = true;
            // 
            // CameraParam_ZSpin
            // 
            this.CameraParam_ZSpin.AnimateReadOnly = false;
            this.CameraParam_ZSpin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_ZSpin.Depth = 0;
            this.CameraParam_ZSpin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_ZSpin.Hint = "Z方向旋转 (度)";
            this.CameraParam_ZSpin.LeadingIcon = null;
            this.CameraParam_ZSpin.Location = new System.Drawing.Point(375, 118);
            this.CameraParam_ZSpin.MaxLength = 50;
            this.CameraParam_ZSpin.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_ZSpin.Multiline = false;
            this.CameraParam_ZSpin.Name = "CameraParam_ZSpin";
            this.CameraParam_ZSpin.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_ZSpin.TabIndex = 7;
            this.CameraParam_ZSpin.Text = "";
            this.CameraParam_ZSpin.TrailingIcon = null;
            // 
            // CameraParam_Z
            // 
            this.CameraParam_Z.AnimateReadOnly = false;
            this.CameraParam_Z.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_Z.Depth = 0;
            this.CameraParam_Z.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_Z.Hint = "Z (mm)";
            this.CameraParam_Z.LeadingIcon = null;
            this.CameraParam_Z.Location = new System.Drawing.Point(6, 118);
            this.CameraParam_Z.MaxLength = 50;
            this.CameraParam_Z.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_Z.Multiline = false;
            this.CameraParam_Z.Name = "CameraParam_Z";
            this.CameraParam_Z.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_Z.TabIndex = 6;
            this.CameraParam_Z.Text = "";
            this.CameraParam_Z.TrailingIcon = null;
            // 
            // CameraParam_YSpin
            // 
            this.CameraParam_YSpin.AnimateReadOnly = false;
            this.CameraParam_YSpin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_YSpin.Depth = 0;
            this.CameraParam_YSpin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_YSpin.Hint = "Y方向旋转 (度)";
            this.CameraParam_YSpin.LeadingIcon = null;
            this.CameraParam_YSpin.Location = new System.Drawing.Point(375, 62);
            this.CameraParam_YSpin.MaxLength = 50;
            this.CameraParam_YSpin.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_YSpin.Multiline = false;
            this.CameraParam_YSpin.Name = "CameraParam_YSpin";
            this.CameraParam_YSpin.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_YSpin.TabIndex = 5;
            this.CameraParam_YSpin.Text = "";
            this.CameraParam_YSpin.TrailingIcon = null;
            // 
            // CameraParam_txtY
            // 
            this.CameraParam_txtY.AnimateReadOnly = false;
            this.CameraParam_txtY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtY.Depth = 0;
            this.CameraParam_txtY.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtY.Hint = "Y (mm)";
            this.CameraParam_txtY.LeadingIcon = null;
            this.CameraParam_txtY.Location = new System.Drawing.Point(6, 62);
            this.CameraParam_txtY.MaxLength = 50;
            this.CameraParam_txtY.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtY.Multiline = false;
            this.CameraParam_txtY.Name = "CameraParam_txtY";
            this.CameraParam_txtY.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtY.TabIndex = 4;
            this.CameraParam_txtY.Text = "";
            this.CameraParam_txtY.TrailingIcon = null;
            // 
            // CameraParam_XSpin
            // 
            this.CameraParam_XSpin.AnimateReadOnly = false;
            this.CameraParam_XSpin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_XSpin.Depth = 0;
            this.CameraParam_XSpin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_XSpin.Hint = "X方向旋转 (度)";
            this.CameraParam_XSpin.LeadingIcon = null;
            this.CameraParam_XSpin.Location = new System.Drawing.Point(375, 6);
            this.CameraParam_XSpin.MaxLength = 50;
            this.CameraParam_XSpin.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_XSpin.Multiline = false;
            this.CameraParam_XSpin.Name = "CameraParam_XSpin";
            this.CameraParam_XSpin.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_XSpin.TabIndex = 3;
            this.CameraParam_XSpin.Text = "";
            this.CameraParam_XSpin.TrailingIcon = null;
            // 
            // CameraParam_txtX
            // 
            this.CameraParam_txtX.AnimateReadOnly = false;
            this.CameraParam_txtX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CameraParam_txtX.Depth = 0;
            this.CameraParam_txtX.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CameraParam_txtX.Hint = "X (mm)";
            this.CameraParam_txtX.LeadingIcon = null;
            this.CameraParam_txtX.Location = new System.Drawing.Point(6, 6);
            this.CameraParam_txtX.MaxLength = 50;
            this.CameraParam_txtX.MouseState = MaterialSkin.MouseState.OUT;
            this.CameraParam_txtX.Multiline = false;
            this.CameraParam_txtX.Name = "CameraParam_txtX";
            this.CameraParam_txtX.Size = new System.Drawing.Size(352, 50);
            this.CameraParam_txtX.TabIndex = 2;
            this.CameraParam_txtX.Text = "";
            this.CameraParam_txtX.TrailingIcon = null;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(6, 34);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1611, 48);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "z";
            // 
            // CalibratingPage
            // 
            this.CalibratingPage.Controls.Add(this.Calibrating_labImageState);
            this.CalibratingPage.Controls.Add(this.Calibrating_btnFinish);
            this.CalibratingPage.Controls.Add(this.Calibrating_ClearImage);
            this.CalibratingPage.Controls.Add(this.Calibrating_labCountofImage);
            this.CalibratingPage.Controls.Add(this.Calibrating_btnCapture);
            this.CalibratingPage.Controls.Add(this.hSmartWindowControl5);
            this.CalibratingPage.ImageKey = "add_a_photo_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png";
            this.CalibratingPage.Location = new System.Drawing.Point(4, 39);
            this.CalibratingPage.Name = "CalibratingPage";
            this.CalibratingPage.Size = new System.Drawing.Size(1617, 784);
            this.CalibratingPage.TabIndex = 6;
            this.CalibratingPage.Text = "标定";
            this.CalibratingPage.UseVisualStyleBackColor = true;
            // 
            // Calibrating_labImageState
            // 
            this.Calibrating_labImageState.AutoSize = true;
            this.Calibrating_labImageState.Depth = 0;
            this.Calibrating_labImageState.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibrating_labImageState.Location = new System.Drawing.Point(61, 62);
            this.Calibrating_labImageState.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibrating_labImageState.Name = "Calibrating_labImageState";
            this.Calibrating_labImageState.Size = new System.Drawing.Size(23, 19);
            this.Calibrating_labImageState.TabIndex = 5;
            this.Calibrating_labImageState.Text = "NG";
            // 
            // Calibrating_btnFinish
            // 
            this.Calibrating_btnFinish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibrating_btnFinish.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibrating_btnFinish.Depth = 0;
            this.Calibrating_btnFinish.HighEmphasis = true;
            this.Calibrating_btnFinish.Icon = null;
            this.Calibrating_btnFinish.Location = new System.Drawing.Point(1454, 742);
            this.Calibrating_btnFinish.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibrating_btnFinish.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibrating_btnFinish.Name = "Calibrating_btnFinish";
            this.Calibrating_btnFinish.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibrating_btnFinish.Size = new System.Drawing.Size(64, 36);
            this.Calibrating_btnFinish.TabIndex = 4;
            this.Calibrating_btnFinish.Text = "完成";
            this.Calibrating_btnFinish.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibrating_btnFinish.UseAccentColor = false;
            this.Calibrating_btnFinish.UseVisualStyleBackColor = true;
            // 
            // Calibrating_ClearImage
            // 
            this.Calibrating_ClearImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibrating_ClearImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibrating_ClearImage.Depth = 0;
            this.Calibrating_ClearImage.HighEmphasis = true;
            this.Calibrating_ClearImage.Icon = null;
            this.Calibrating_ClearImage.Location = new System.Drawing.Point(1382, 742);
            this.Calibrating_ClearImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibrating_ClearImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibrating_ClearImage.Name = "Calibrating_ClearImage";
            this.Calibrating_ClearImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibrating_ClearImage.Size = new System.Drawing.Size(64, 36);
            this.Calibrating_ClearImage.TabIndex = 3;
            this.Calibrating_ClearImage.Text = "清除";
            this.Calibrating_ClearImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibrating_ClearImage.UseAccentColor = false;
            this.Calibrating_ClearImage.UseVisualStyleBackColor = true;
            // 
            // Calibrating_labCountofImage
            // 
            this.Calibrating_labCountofImage.AutoSize = true;
            this.Calibrating_labCountofImage.Depth = 0;
            this.Calibrating_labCountofImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Calibrating_labCountofImage.Location = new System.Drawing.Point(1365, 752);
            this.Calibrating_labCountofImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibrating_labCountofImage.Name = "Calibrating_labCountofImage";
            this.Calibrating_labCountofImage.Size = new System.Drawing.Size(10, 19);
            this.Calibrating_labCountofImage.TabIndex = 2;
            this.Calibrating_labCountofImage.Text = "0";
            // 
            // Calibrating_btnCapture
            // 
            this.Calibrating_btnCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calibrating_btnCapture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calibrating_btnCapture.Depth = 0;
            this.Calibrating_btnCapture.HighEmphasis = true;
            this.Calibrating_btnCapture.Icon = null;
            this.Calibrating_btnCapture.Location = new System.Drawing.Point(1294, 741);
            this.Calibrating_btnCapture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calibrating_btnCapture.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calibrating_btnCapture.Name = "Calibrating_btnCapture";
            this.Calibrating_btnCapture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calibrating_btnCapture.Size = new System.Drawing.Size(64, 36);
            this.Calibrating_btnCapture.TabIndex = 1;
            this.Calibrating_btnCapture.Text = "采集";
            this.Calibrating_btnCapture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calibrating_btnCapture.UseAccentColor = false;
            this.Calibrating_btnCapture.UseVisualStyleBackColor = true;
            // 
            // hSmartWindowControl5
            // 
            this.hSmartWindowControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl5.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl5.HDoubleClickToFitContent = true;
            this.hSmartWindowControl5.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl5.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl5.HKeepAspectRatio = true;
            this.hSmartWindowControl5.HMoveContent = true;
            this.hSmartWindowControl5.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl5.Location = new System.Drawing.Point(33, 42);
            this.hSmartWindowControl5.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl5.Name = "hSmartWindowControl5";
            this.hSmartWindowControl5.Size = new System.Drawing.Size(1485, 694);
            this.hSmartWindowControl5.TabIndex = 0;
            this.hSmartWindowControl5.WindowSize = new System.Drawing.Size(1485, 694);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "control_camera_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(1, "flip_camera_android_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(2, "photo_camera_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(3, "radio_button_checked_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(4, "description_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(5, "monochrome_photos_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            this.imageList1.Images.SetKeyName(6, "add_a_photo_40dp_5F6368_FILL0_wght400_GRAD0_opsz40.png");
            // 
            // btnCloseCamera
            // 
            this.btnCloseCamera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseCamera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseCamera.Depth = 0;
            this.btnCloseCamera.HighEmphasis = true;
            this.btnCloseCamera.Icon = null;
            this.btnCloseCamera.Location = new System.Drawing.Point(100, 69);
            this.btnCloseCamera.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseCamera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseCamera.Name = "btnCloseCamera";
            this.btnCloseCamera.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseCamera.Size = new System.Drawing.Size(85, 36);
            this.btnCloseCamera.TabIndex = 1;
            this.btnCloseCamera.Text = "关闭相机";
            this.btnCloseCamera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseCamera.UseAccentColor = false;
            this.btnCloseCamera.UseVisualStyleBackColor = true;
            this.btnCloseCamera.Click += new System.EventHandler(this.btnCloseCamera_Click);
            // 
            // btn_OpenCamera
            // 
            this.btn_OpenCamera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_OpenCamera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_OpenCamera.Depth = 0;
            this.btn_OpenCamera.HighEmphasis = true;
            this.btn_OpenCamera.Icon = null;
            this.btn_OpenCamera.Location = new System.Drawing.Point(7, 69);
            this.btn_OpenCamera.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_OpenCamera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_OpenCamera.Name = "btn_OpenCamera";
            this.btn_OpenCamera.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_OpenCamera.Size = new System.Drawing.Size(85, 36);
            this.btn_OpenCamera.TabIndex = 2;
            this.btn_OpenCamera.Text = "打开相机";
            this.btn_OpenCamera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_OpenCamera.UseAccentColor = false;
            this.btn_OpenCamera.UseVisualStyleBackColor = true;
            this.btn_OpenCamera.Click += new System.EventHandler(this.btn_OpenCamera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 921);
            this.Controls.Add(this.btn_OpenCamera);
            this.Controls.Add(this.btnCloseCamera);
            this.Controls.Add(this.AppTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.AppTabControl;
            this.Font = new System.Drawing.Font("小米兰亭", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 90, 4, 4);
            this.Text = "CamaraCalibration";
            this.AppTabControl.ResumeLayout(false);
            this.CameraCalibrationPage.ResumeLayout(false);
            this.CameraCalibrationPage.PerformLayout();
            this.PositionGuidancePage.ResumeLayout(false);
            this.PositionGuidancePage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MultipointCalibrationPage.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.DistortionCorrectionPage.ResumeLayout(false);
            this.DistortionCorrectionPage.PerformLayout();
            this.CreateDescrFilePage.ResumeLayout(false);
            this.CreateDescrFilePage.PerformLayout();
            this.CamaraParamPage.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.CalibratingPage.ResumeLayout(false);
            this.CalibratingPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialTabControl AppTabControl;
        private TabPage CameraCalibrationPage;
        private TabPage PositionGuidancePage;
        private ImageList imageList1;
        private TabPage MultipointCalibrationPage;
        private TabPage DistortionCorrectionPage;
        private MaterialTextBox Calibration_txtDesrFileAddress;
        private MaterialTextBox Calibration_txtPlateThick;
        private MaterialTextBox Calibration_txtFocalLength;
        private MaterialTextBox Calibration_txtSinglePixelHeight;
        private MaterialTextBox Calibration_txtSinglePixelWidth;

        private MaterialLabel Calibration_labCalibrationParam;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl;
        private MaterialButton Calibration_btnCreateDescrFile;
        private MaterialButton Calibration_btnSelectDescrFile;
        private MaterialButton Calibration_btnBeginToCalibration;
        private TabPage CreateDescrFilePage;
        private MaterialButton Calibration_btnSaveDescrFileAddress;
        private MaterialTextBox Calibration_SaveDescrFileAddress;
        private MaterialLabel Calibration_labFileParam;
        private MaterialTextBox Calibration_txtCenterLengthRate;
        private MaterialTextBox Calibration_txtCenterLength;
        private MaterialTextBox Calibration_ClomnPointNum;
        private MaterialTextBox Calibration_txtRowPointNum;
        private MaterialButton Calibration_btnCreateDescrFile_Finsh;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl4;
        private GroupBox groupBox1;
        private MaterialTextBox PositionGuaidance_txtPort;
        private MaterialTextBox PositionGuidance_txtIPAddress;
        private MaterialButton PositionGuaidance_btnLinkModbusTcp;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl1;
        private MaterialMultiLineTextBox PositionGuaidance_txtMutiLineOutPut;
        private MaterialButton PositionGuaidance_btnBegin;
        private MaterialButton PositionGuaidance_btnCreateData;
        private MaterialButton PositionGuaidance_btnInputData;
        private MaterialButton PositionGuaidance_btnStop;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl2;
        private MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialTabSelector materialTabSelector1;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel8;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel2;
        private MaterialTextBox MultiPoint9_txtX1;
        private MaterialTextBox MultiPoint9_txtY1;
        private MaterialLabel materialLabel9;
        private MaterialTextBox MultiPoint9_txtX9;
        private MaterialTextBox MultiPoint9_txtX8;
        private MaterialTextBox MultiPoint9_txtX7;
        private MaterialTextBox MultiPoint9_txtX6;
        private MaterialTextBox MultiPoint9_txtX5;
        private MaterialTextBox MultiPoint9_txtX4;
        private MaterialTextBox MultiPoint9_txtX3;
        private MaterialTextBox MultiPoint9_txtX2;
        private MaterialTextBox MultiPoint9_txtY9;
        private MaterialTextBox MultiPoint9_txtY8;
        private MaterialTextBox MultiPoint9_txtY7;
        private MaterialTextBox MultiPoint9_txtY6;
        private MaterialTextBox MultiPoint9_txtY5;
        private MaterialTextBox MultiPoint9_txtY4;
        private MaterialTextBox MultiPoint9_txtY3;
        private MaterialTextBox MultiPoint9_txtY2;
        private MaterialLabel materialLabel21;
        private MaterialTextBox MultiPoint12_txtX12;
        private MaterialTextBox MultiPoint12_txtY12;
        private MaterialLabel materialLabel20;
        private MaterialTextBox MultiPoint12_txtX11;
        private MaterialTextBox MultiPoint12_txtY11;
        private MaterialLabel materialLabel19;
        private MaterialTextBox MultiPoint12_txtX10;
        private MaterialTextBox MultiPoint12_txtY10;
        private MaterialLabel materialLabel18;
        private MaterialTextBox MultiPoint12_txtX9;
        private MaterialTextBox MultiPoint12_txtX8;
        private MaterialTextBox MultiPoint12_txtX7;
        private MaterialTextBox MultiPoint12_txtX6;
        private MaterialTextBox MultiPoint12_txtX5;
        private MaterialTextBox MultiPoint12_txtX4;
        private MaterialTextBox MultiPoint12_txtX3;
        private MaterialTextBox MultiPoint12_txtX2;
        private MaterialTextBox MultiPoint12_txtX1;
        private MaterialTextBox MultiPoint12_txtY9;
        private MaterialTextBox MultiPoint12_txtY8;
        private MaterialTextBox MultiPoint12_txtY7;
        private MaterialTextBox MultiPoint12_txtY6;
        private MaterialTextBox MultiPoint12_txtY5;
        private MaterialTextBox MultiPoint12_txtY4;
        private MaterialTextBox MultiPoint12_txtY3;
        private MaterialTextBox MultiPoint12_txtY2;
        private MaterialTextBox MultiPoint12_txtY1;
        private MaterialLabel materialLabel10;
        private MaterialLabel materialLabel11;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel13;
        private MaterialLabel materialLabel14;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel16;
        private MaterialLabel materialLabel17;
        private MaterialButton MultiPoint12_btnCreate;
        private MaterialButton MultiPoint9_btnCreate;
        private MaterialSwitch materialSwitch1;
        private MaterialButton materialButton1;
        private MaterialLabel Distortion_labCameraDataState;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl3;
        private TabPage CamaraParamPage;
        private MaterialTabControl materialTabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private MaterialTabSelector materialTabSelector2;
        private MaterialTextBox CameraParam_txtCenterX;
        private MaterialTextBox CameraParam_txtSiglePixelWidth;
        private MaterialTextBox CameraParam_txtImageHight;
        private MaterialTextBox CameraParam_txtKappa;
        private MaterialTextBox CameraParam_txtImageWidth;
        private MaterialTextBox CameraParam_txtFocalLength;
        private MaterialTextBox CameraParam_txtCenterY;
        private MaterialTextBox CameraParam_txtSiglePixelHight;
        private MaterialTextBox CameraParam_ZSpin;
        private MaterialTextBox CameraParam_Z;
        private MaterialTextBox CameraParam_YSpin;
        private MaterialTextBox CameraParam_txtY;
        private MaterialTextBox CameraParam_XSpin;
        private MaterialTextBox CameraParam_txtX;
        private MaterialButton CameraParam_btnSaveData;
        private MaterialButton CameraParam_btnSavePose;
        private TabPage CalibratingPage;
        private MaterialButton Calibrating_btnFinish;
        private MaterialButton Calibrating_ClearImage;
        private MaterialLabel Calibrating_labCountofImage;
        private MaterialButton Calibrating_btnCapture;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl5;
        private MaterialButton Calibration_btnBack;
        private MaterialButton MultiPoint_btnCapture;
        private MaterialButton MultiPoint12_btnCapture;
        private MaterialButton btnCloseCamera;
        private MaterialButton btn_OpenCamera;
        private MaterialLabel Calibrating_labImageState;
    }
}

