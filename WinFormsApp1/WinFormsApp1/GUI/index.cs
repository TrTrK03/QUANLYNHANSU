using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsApp1.GUI;
using WinFormsApp1.GUI.NewFolder;
using WinFormsApp1.BUS;
namespace WinFormsApp1
{
    public partial class index : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );



        public index()
        {
            InitializeComponent();
            phongban.BackColor = Color.FromArgb(46, 51, 73);

            panel5.Controls.Clear();
            phongbangui pb = new phongbangui();
            panel5.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;

        

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi động Timer khi form load
            timer1.Start();
        }

        private void chamcong_Click(object sender, EventArgs e)
        {

            chamcong.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            chamconggui ccgui = new chamconggui();

            panel5.Controls.Add(ccgui);
            ccgui.Dock = DockStyle.Fill;
        }
        private void nhanvien_Click(object sender, EventArgs e)
        {
            nhanvien.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            nhanviengui nv = new nhanviengui();
            panel5.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
        }
        private void phongban_Click(object sender, EventArgs e)
        {
            phongban.BackColor = Color.FromArgb(46, 51, 73);

            panel5.Controls.Clear();
            phongbangui pb = new phongbangui();
            panel5.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }
        private void duan_Click(object sender, EventArgs e)
        {
            duan.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            duangui da = new duangui();
            panel5.Controls.Add(da);
            da.Dock = DockStyle.Fill;
        }
        private void bangluong_Click(object sender, EventArgs e)
        {

            bangluong.BackColor = Color.FromArgb(46, 51, 73);

            // Xóa tất cả các điều khiển cũ trong panel5 trước khi thêm mới
            panel5.Controls.Clear();

            // Tạo đối tượng GUI cho bangLuong
            bangLuongGUI da = new bangLuongGUI();
            panel5.Controls.Add(da);
            da.Dock = DockStyle.Fill;
        }


        private void thongbao_Click(object sender, EventArgs e)
        {

            thongbao.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            thongbaogui tb = new thongbaogui();
            panel5.Controls.Add(tb);
            tb.Dock = DockStyle.Fill;
        }

        private void phucloi_Click(object sender, EventArgs e)
        {

            phucloi.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            phucloigui pl = new phucloigui();
            panel5.Controls.Add(pl);
            pl.Dock = DockStyle.Fill;
        }

        private void tuyendung_Click(object sender, EventArgs e)
        {

            tuyendung.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            tuyendunggui td = new tuyendunggui();
            panel5.Controls.Add(td);
            td.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khenthuong.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            khenThuongGUI td = new khenThuongGUI();
            panel5.Controls.Add(td);
            td.Dock = DockStyle.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        { }

        private void home_Leave(object sender, EventArgs e)
        {
            //home.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void phongban_Leave(object sender, EventArgs e)
        {
            phongban.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void duan_Leave(object sender, EventArgs e)
        {
            duan.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void tuyendung_Leave(object sender, EventArgs e)
        {
            tuyendung.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void thongbao_Leave(object sender, EventArgs e)
        {
            thongbao.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void phucloi_Leave(object sender, EventArgs e)
        {
            phucloi.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void bangluong_Leave(object sender, EventArgs e)
        {
            bangluong.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void khenthuong_leave(object sender, EventArgs e)
        {
            khenthuong.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void nhanvien_Leave(object sender, EventArgs e)
        {
            nhanvien.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void chamcong_Leave(object sender, EventArgs e)
        {
            chamcong.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void khenthuong_Leave(object sender, EventArgs e)
        {
            khenthuong.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian hiện tại
            label1.Text = DateTime.Now.ToString("HH : mm");
        }

    }
}
