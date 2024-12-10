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
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //panNav.Height = home.Height;
            //panNav.Top = home.Top;
            //panNav.Left = home.Left;
            //home.BackColor = Color.FromArgb(46, 51, 73);
            //nhanviengui usctr = new nhanviengui();
            //Controls.Add(usctr);
            //usctr.BringToFront();
            //usctr.Location = new System.Drawing.Point(186, 0);

        }



        private void home_Click(object sender, EventArgs e)
        {
            //panNav.Height = home.Height;
            //panNav.Top = home.Top;
            //panNav.Left = home.Left;
            //home.BackColor = Color.FromArgb(46, 51, 73);


        }
        private void chamcong_Click(object sender, EventArgs e)
        {
            panNav.Height = chamcong.Height;
            panNav.Top = chamcong.Top;
            panNav.Left = chamcong.Left;
            chamcong.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            chamconggui ccgui = new chamconggui();

            panel5.Controls.Add(ccgui);
            ccgui.Dock = DockStyle.Fill;
        }
        private void nhanvien_Click(object sender, EventArgs e)
        {
            panNav.Height = nhanvien.Height;
            panNav.Top = nhanvien.Top;
            panNav.Left = nhanvien.Left;
            nhanvien.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            nhanviengui nv = new nhanviengui();
            panel5.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
        }
        private void phongban_Click(object sender, EventArgs e)
        {
            panNav.Height = phongban.Height;
            panNav.Top = phongban.Top;
            panNav.Left = phongban.Left;
            phongban.BackColor = Color.FromArgb(46, 51, 73);

            panel5.Controls.Clear();
            phongbangui pb = new phongbangui();
            panel5.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }
        private void duan_Click(object sender, EventArgs e)
        {
            panNav.Height = duan.Height;
            panNav.Top = duan.Top;
            panNav.Left = duan.Left;
            duan.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            duangui da = new duangui();
            panel5.Controls.Add(da);
            da.Dock = DockStyle.Fill;
        }
        private void bangluong_Click(object sender, EventArgs e)
        {
            panNav.Height = bangluong.Height;
            panNav.Top = bangluong.Top;
            panNav.Left = bangluong.Left;
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
            panNav.Height = thongbao.Height;
            panNav.Top = thongbao.Top;
            panNav.Left = thongbao.Left;
            thongbao.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            thongbaogui tb = new thongbaogui();
            panel5.Controls.Add(tb);
            tb.Dock = DockStyle.Fill;
        }

        private void phucloi_Click(object sender, EventArgs e)
        {
            panNav.Height = phucloi.Height;
            panNav.Top = phucloi.Top;
            panNav.Left = phucloi.Left;
            phucloi.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            phucloigui pl = new phucloigui();
            panel5.Controls.Add(pl);
            pl.Dock = DockStyle.Fill;
        }

        private void tuyendung_Click(object sender, EventArgs e)
        {
            panNav.Height = tuyendung.Height;
            panNav.Top = tuyendung.Top;
            panNav.Left = tuyendung.Left;
            tuyendung.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            tuyendunggui td = new tuyendunggui();
            panel5.Controls.Add(td);
            td.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panNav.Height = khenthuong.Height;
            panNav.Top = khenthuong.Top;
            panNav.Left = khenthuong.Left;
            khenthuong.BackColor = Color.FromArgb(46, 51, 73);
            panel5.Controls.Clear();
            khenThuongGUI td = new khenThuongGUI();
            panel5.Controls.Add(td);
            td.Dock = DockStyle.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void home_Leave(object sender, EventArgs e)
        {
            //home.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void phongban_Leave(object sender, EventArgs e)
        {
            phongban.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void duan_Leave(object sender, EventArgs e)
        {
            duan.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tuyendung_Leave(object sender, EventArgs e)
        {
            tuyendung.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void thongbao_Leave(object sender, EventArgs e)
        {
            thongbao.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void phucloi_Leave(object sender, EventArgs e)
        {
            phucloi.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void bangluong_Leave(object sender, EventArgs e)
        {
            bangluong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void khenthuong_leave(object sender, EventArgs e)
        {
            khenthuong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void nhanvien_Leave(object sender, EventArgs e)
        {
            nhanvien.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void chamcong_Leave(object sender, EventArgs e)
        {
            chamcong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
