using APControlCentre.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System.IO;

namespace APControlCentre.View
{
    public partial class Dashboard : UserControl, IClsUI
    {
        public ChartValues<ChartData> CPUChartValues { get; set; }
        public ChartValues<ChartData> GPUChartValues { get; set; }
        private delegate void SensorDataChangeEventHandler(string arduinoString, params string[] data);
        private event SensorDataChangeEventHandler SensorDataChanged;

        private delegate void TelemetryDataChangeEventHandler(params string[] data);
        private event TelemetryDataChangeEventHandler TelemetryDataChanged;

        bool isConnected = false;

        SerialPort port;
        public string gRED = string.Empty;
        public string gGREEN = string.Empty;
        public string gBLUE = string.Empty;
        OpenHardwareMonitor.Hardware.Computer thisComputer = new OpenHardwareMonitor.Hardware.Computer() { };
        Queue DataQ = new Queue();
        Timer tmrPollData;

        public Dashboard()
        {
            InitializeComponent();
            InitializeCharting();
            InitializeResources();
            tmrPollData = new Timer
            {
                Interval = 1000
            };
            SubscribeEvents();

        }

        private async void FrmDashboard_SensorDataChanged(string arduinoString, params string[] data)
        {
            try
            {
                var now = System.DateTime.Now;

                lblActualCPUName.Text = data[0].ToString();
                lblActCPUTemp.Text = data[1].ToString();
                lblActualCPUUsage.Text = data[2].ToString();

                lblActGPUName.Text = data[3].ToString();
                lblActGPUTemp.Text = data[4].ToString();
                lblActGPUUsage.Text = data[5].ToString();

                await Task.Run(() => UpdateGPUData(data, now));
                await Task.Run(() => UpdateCPUChart(data, now));
                if (port != null && port.IsOpen)
                    await Task.Run(() => SendDataToArduino(arduinoString));

                SetAxisLimits(now);

                //lets only use the last 30 values
                if (CPUChartValues.Count > 30) CPUChartValues.RemoveAt(0);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SendDataToArduino(string arduinoData)
        {
            try
            {
                DataSender.Enqueue(arduinoData);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void UpdateGPUData(string[] data, DateTime now)
        {
            bool isGPUDataAvailable = double.TryParse(data[4], out double gputempData);
            if (isGPUDataAvailable)
            {
                GPUChartValues.Add(new ChartData
                {
                    DateData = now,

                    Value = gputempData
                });
            }
        }

        private void UpdateCPUChart(string[] data, DateTime now)
        {
            bool isCPUDataAvailable = double.TryParse(data[1], out double cputempData);
            if (isCPUDataAvailable)
            {
                CPUChartValues.Add(new ChartData
                {
                    DateData = now,

                    Value = cputempData
                });
            }

            TelemetryDataChanged?.Invoke(data);
            
        }

        private void TmrPollData_Tick(object sender, EventArgs e)
        {
            try
            {
                dataCheck();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void InitializeResources()
        {
            try
            {
                this.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void InitializeCharting()
        {
            try
            {
                var mapper = Mappers.Xy<ChartData>()
                                    .X(model => model.DateData.Ticks)   //use DateTime.Ticks as X
                                    .Y(model => model.Value);           //use the value property as Y

                //lets save the mapper globally.
                Charting.For<ChartData>(mapper);

                //the ChartValues property will store our values array
                CPUChartValues = new ChartValues<ChartData>();
                GPUChartValues = new ChartValues<ChartData>();

                chrtCPU.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = CPUChartValues,
                    PointGeometrySize = 0,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 71, 144)),
                    //Fill = System.Windows.Media.Brushes.Transparent,
                    StrokeThickness = 1

                }
            };
                chrtCPU.AxisX.Add(new Axis
                {
                    DisableAnimations = true,
                    LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                    Separator = new Separator
                    {
                        Step = TimeSpan.FromSeconds(1).Ticks
                    }
                });
                chrtCPU.AxisY.Add(new Axis
                {
                    DisableAnimations = true,
                    //LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                    //Separator = new Separator
                    //{
                    //    Step = TimeSpan.FromSeconds(1).Ticks
                    //}
                });

                chrtGPU.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = GPUChartValues,
                    PointGeometrySize = 0,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 71, 144)),
                    StrokeThickness = 1
                }
            };
                chrtGPU.AxisX.Add(new Axis
                {
                    DisableAnimations = true,
                    LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                    Separator = new Separator
                    {
                        Step = TimeSpan.FromSeconds(1).Ticks
                    }
                });
                chrtGPU.AxisY.Add(new Axis
                {
                    DisableAnimations = true,
                    //LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                    //Separator = new Separator
                    //{
                    //    Step = TimeSpan.FromSeconds(1).Ticks
                    //}
                });
                SetAxisLimits(System.DateTime.Now);
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                StartTelemetry();
                disableControls();
                if (ClsCommon.gobjclsVariables.port != null)
                    connectToArduino();
                tmrPollData.Start();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void StartTelemetry()
        {
            try
            {
                thisComputer.CPUEnabled = true;
                thisComputer.GPUEnabled = true;
                thisComputer.HDDEnabled = true;
                thisComputer.MainboardEnabled = true;
                thisComputer.RAMEnabled = true;
                thisComputer.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void dataCheck()
        {
            try
            {
                string cpuTemp = string.Empty;
                string gpuTemp = string.Empty;
                string gpuLoad = string.Empty;
                string cpuLoad = string.Empty;
                string ramUsed = string.Empty;
                string CPUName = string.Empty;
                string GPUName = string.Empty;

                // enumerating all the hardware
                foreach (OpenHardwareMonitor.Hardware.IHardware hw in thisComputer.Hardware)
                {

                    hw.Update();

                    switch (hw.HardwareType)
                    {
                        case OpenHardwareMonitor.Hardware.HardwareType.Mainboard:
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.SuperIO:
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.CPU:
                            CPUName = hw.Name.Substring(4);
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.RAM:
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.GpuNvidia:
                            GPUName = hw.Name;
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.GpuAti:
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.TBalancer:
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.Heatmaster:
                            break;
                        case OpenHardwareMonitor.Hardware.HardwareType.HDD:
                            break;
                        default:
                            break;
                    }

                    // searching for all sensors and adding data to listbox
                    foreach (OpenHardwareMonitor.Hardware.ISensor sensor in hw.Sensors)
                    {
                        switch (sensor.SensorType)
                        {
                            case OpenHardwareMonitor.Hardware.SensorType.Voltage:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Clock:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Temperature:
                                if (sensor.Value != null)
                                {
                                    int curTemp = (int)sensor.Value;
                                    switch (sensor.Name)
                                    {
                                        case "CPU Package":
                                            cpuTemp = curTemp.ToString();
                                            break;
                                        case "GPU Core":
                                            gpuTemp = curTemp.ToString();
                                            break;

                                    }
                                }
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Load:
                                if (sensor.Value != null)
                                {
                                    int curLoad = (int)sensor.Value;
                                    switch (sensor.Name)
                                    {
                                        case "CPU Total":
                                            cpuLoad = curLoad.ToString();
                                            break;
                                        case "GPU Core":
                                            gpuLoad = curLoad.ToString();
                                            break;
                                    }
                                }
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Fan:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Flow:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Control:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Level:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Factor:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Power:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Data:
                                if (sensor.Value != null)
                                {
                                    switch (sensor.Name)
                                    {
                                        case "Used Memory":
                                            decimal decimalRam = Math.Round((decimal)sensor.Value, 1);
                                            ramUsed = decimalRam.ToString();
                                            break;
                                    }
                                }
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.SmallData:
                                break;
                            case OpenHardwareMonitor.Hardware.SensorType.Throughput:
                                break;
                            default:
                                break;
                        }
                    }
                }
                //string curSong = "";
                //Process[] processlist = Process.GetProcesses();

                //foreach (Process process in processlist)
                //{
                //    if (!String.IsNullOrEmpty(process.MainWindowTitle))
                //    {

                //        if (process.ProcessName == "AIMP3")
                //        {
                //            curSong = process.MainWindowTitle;
                //        }
                //        else if (process.ProcessName == "foobar2000" && (process.MainWindowTitle.IndexOf("[") > 0))
                //        {
                //            curSong = process.MainWindowTitle.Substring(0, process.MainWindowTitle.IndexOf("[") - 1);
                //        }
                //    }
                //}

                //string arduinoData = "C" + cpuTemp + "c " + cpuLoad + "%|G" + gpuTemp + "c " + gpuLoad + "%|R" + ramUsed + "G|S" + curSong + "|";
                string curSong = string.Empty;
                //string arduinoData = "CPU:" + CPUName + "GPU:" + GPUName + "|" + "CT" + cpuTemp + "ct " + cpuLoad + "|G" + gpuTemp + "c " + gpuLoad + "%|R" + ramUsed + "G|S" + curSong + "|";
                //string arduinoData = "CPU:" + CPUName + "GPU:" + GPUName + "|" + "CT" + cpuTemp + "ct " + cpuLoad + "|G" + gpuTemp + "c " + gpuLoad + "%|R" + ramUsed + "G|";
                string arduinoData = "CPU:" + CPUName + "GPU:" + GPUName + "CT:" + cpuTemp + "CL:" + cpuLoad + "GT:" + gpuTemp + "GL:" + gpuLoad + "RAM:" + ramUsed + "SONG:" + curSong + "|";

                string[] data = new string[]
                {
                    CPUName,
                    cpuTemp,
                    cpuLoad,
                    GPUName,
                    gpuTemp,
                    gpuLoad
                };

                SensorDataChanged?.Invoke(arduinoData, data);

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    connectToArduino();
                }
                else
                {
                    disconnectFromArduino();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void connectToArduino()
        {
            try
            {
                isConnected = true;
                port = ClsCommon.gobjclsVariables.port;
                if (!port.IsOpen)
                {
                    port.Open();

                };
                enableControls();
            }
            catch (UnauthorizedAccessException)
            {
                //MessageBox.Show(cboPorts.Text + " is not available. Please try again.");
            }
        }


        private void disconnectFromArduino()
        {
            try
            {
                isConnected = false;
                if (port.IsOpen)
                {
                    port.Close();
                }

                //btnConnect.Text = "Connect";
                disableControls();
                resetDefaults();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void enableControls()
        {

            //grpPower.Enabled = true;
            //btnRGBON.Enabled = true;
            //btnRGBOFF.Enabled = true;
            //btnApply.Enabled = true;
            //chkAdMode.Enabled = true;
            //if (chkAdMode.Checked)
            //{
            //    btnWrite.Enabled = true;
            //    txtCustCommands.Enabled = true;
            //    grpCustomCommands.Enabled = true;
            //}
        }

        private void disableControls()
        {
            //grpPower.Enabled = false;
            //btnRGBON.Enabled = false;
            //btnRGBOFF.Enabled = false;
            //btnApply.Enabled = false;
            //chkAdMode.Enabled = false;
            //txtCustCommands.Enabled = false;
            //btnWrite.Visible = false;
            //txtCustCommands.Visible = false;
            //grpCustomCommands.Visible = false;
            //btnWrite.Enabled = false;
            //txtCustCommands.Enabled = false;
            //grpCustomCommands.Enabled = false;

        }

        private void resetDefaults()
        {
            //txtCustCommands.Text = "";
            //chkAdMode.Checked = false;

        }

        private void SetAxisLimits(System.DateTime now)
        {

            //chrtCPU.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            chrtCPU.AxisX[0].MaxValue = now.Ticks;
            chrtCPU.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
            chrtCPU.AxisY[0].MaxValue = 100;
            chrtCPU.AxisY[0].MinValue = 0;
            //chrtGPU.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            chrtGPU.AxisX[0].MaxValue = now.Ticks;
            chrtGPU.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds 
            chrtGPU.AxisY[0].MaxValue = 100;
            chrtGPU.AxisY[0].MinValue = 0;

        }

        public void SubscribeEvents()
        {
            try
            {
                tmrPollData.Tick += TmrPollData_Tick;
                SensorDataChanged += FrmDashboard_SensorDataChanged;
                TelemetryDataChanged += Dashboard_TelemetryDataChanged;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Dashboard_TelemetryDataChanged(params string[] data)
        {
            try
            {
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UnSubscribeEvents()
        {
            try
            {
                tmrPollData.Tick -= TmrPollData_Tick;
                SensorDataChanged -= FrmDashboard_SensorDataChanged;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetDefaultValues()
        {
            throw new NotImplementedException();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            try
            {
                if (ClsCommon.gobjclsVariables.port != null)
                    connectToArduino();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ChangeIcon(ref object objPbox, EnumNewOldIndicator indicator)
        {
            try
            {
                PictureBox pbox = objPbox as PictureBox;
                Bitmap image = null;

                if (indicator.Equals(EnumNewOldIndicator.Old))
                    image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icoDashboard_small_Alt");
                else
                    image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icoDashboard");

                ClsCommon.gobjclsFunctions.ChangeNavButtonImage(ref objPbox, image, indicator);


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
