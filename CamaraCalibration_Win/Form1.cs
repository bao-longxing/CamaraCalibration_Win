using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
namespace CamaraCalibration_Win
{

    public partial class Form1 : MaterialForm
    {
        private CalibrationData CalibrationData;
        private DataControler DataControler;
        private HalconFuntion HalconFuntion;
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            SnackbarManager.Initilaze(this);

            CalibrationData = new CalibrationData();
            DataControler = new DataControler(CalibrationData);
            HalconFuntion = new HalconFuntion(DataControler,this);

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple700, Primary.DeepPurple100, Accent.DeepPurple200, TextShade.WHITE);
        }

        //创建Descr文件
        private void btnCreateDescrFile_Click(object sender, EventArgs e)
        {
            AppTabControl.SelectedIndex = 4;
        }

        private void Calibration_btnBack_Click(object sender, EventArgs e)
        {
            AppTabControl.SelectedIndex = 0;
        }

        private void btn_OpenCamera_Click(object sender, EventArgs e)
        {
            switch (AppTabControl.SelectedIndex)
            {
                //相机标定
                case 0:
                    HalconFuntion.OpenCamera(0, hSmartWindowControl);
                    break;
                //定位引导
                case 1:
                    HalconFuntion.OpenCamera(1, hSmartWindowControl1);
                    break;
                //多点标定
                case 2:
                    HalconFuntion.OpenCamera(2, hSmartWindowControl2);
                    break;
                //畸变矫正
                case 3:
                    HalconFuntion.OpenCamera(3, hSmartWindowControl3);
                    break;
                //创建标定板文件
                case 4:
                    HalconFuntion.OpenCamera(4, hSmartWindowControl4);
                    break;
                //标定
                case 6:
                    HalconFuntion.OpenCamera(6, hSmartWindowControl5);
                    break;
                default:
                    break;
            }
        }

        private void btnCloseCamera_Click(object sender, EventArgs e)
        {
            HalconFuntion.CloseCamera();
        }
        //设置标定界面lab提示
        public void SetCalibratingImageState(string message)
        {
            Calibrating_labImageState.Invoke((Action)(() =>
            {
                Calibrating_labImageState.Text = message;
            }));
        }
        //设置标定界面图片数量
        public void SetCalibratingImageCount(int count)
        {
            Calibrating_labCountofImage.Invoke((Action)(() =>
            {
                Calibrating_labCountofImage.Text = count.ToString();
            }));
        }
        //获取九点标定数据
        public PointGroup GetPointValue()
        {
            PointGroup pointGroup = new PointGroup();
            if (MultiPoint9_btnCreate.Visible == true)
            {
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX1.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX2.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX3.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX4.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX5.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX6.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX7.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX8.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint9_txtX9.Text));

                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY1.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY2.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY3.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY4.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY5.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY6.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY7.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY8.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint9_txtY9.Text));

                return pointGroup;
            }
            else if (MultiPoint12_btnCreate.Visible == true)
            {
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX1.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX2.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX3.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX4.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX5.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX6.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX7.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX8.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX9.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX10.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX11.Text));
                pointGroup.row.Append(Convert.ToDouble(MultiPoint12_txtX12.Text));

                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY1.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY2.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY3.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY4.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY5.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY6.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY7.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY8.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY9.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY10.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY11.Text));
                pointGroup.col.Append(Convert.ToDouble(MultiPoint12_txtY12.Text));

                return pointGroup;
            }
            else
            {
                throw new Exception("按钮可见性错误");
            }
            
        }
        //定位引导界面log
        public void SetPositionGuaidanceLog(string GuaidanceLog)
        {
            PositionGuaidance_txtMutiLineOutPut.Invoke((Action)(() => 
            {
                PositionGuaidance_txtMutiLineOutPut.Text += GuaidanceLog;
            }));
        }
    }
}
