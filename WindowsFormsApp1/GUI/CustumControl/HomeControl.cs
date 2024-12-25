using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, System.EventArgs e)
        {
            txtSoLuongCTY.Text = new QuanLyCongTy().DemCT().ToString();
            txtSoLuongDTAI.Text = new QuanLyDeTai().DemDT().ToString();
            txtSoluongGV.Text = new QuanLyGiangVien().DemGV().ToString();
            txtSoLuongSV.Text = new QuanLySinhVien().DemSV().ToString();
            txtSoLuongKhoa.Text = new QuanLyKhoa().DemMaKhoa().ToString();

            chartHome.Series.Clear();
            Series series = new Series("Tổng quan");

            series.Points.AddXY("Công ty", int.Parse(txtSoLuongCTY.Text));
            series.Points.AddXY("Đề tài", int.Parse(txtSoLuongDTAI.Text));
            series.Points.AddXY("Giáo viên", int.Parse(txtSoluongGV.Text));
            series.Points.AddXY("Sinh viên", int.Parse(txtSoLuongSV.Text));
            series.Points.AddXY("Khoa", int.Parse(txtSoLuongKhoa.Text));
            chartHome.Series.Add(series);
        }
    }
}
