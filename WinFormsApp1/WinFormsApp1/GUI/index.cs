using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsApp1.GUI;
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
            panNav.Height = home.Height;
            panNav.Top = home.Top;
            panNav.Left = home.Left;
            //home.BackColor = Color.FromArgb(46, 51, 73);
            //nhanviengui usctr = new nhanviengui();
            //Controls.Add(usctr);
            //usctr.BringToFront();
            //usctr.Location = new System.Drawing.Point(186, 0);

        }



        private void home_Click(object sender, EventArgs e)
        {
            panNav.Height = home.Height;
            panNav.Top = home.Top;
            panNav.Left = home.Left;
            home.BackColor = Color.FromArgb(46, 51, 73);


        }
        private void chamcong_Click(object sender, EventArgs e)
        {
            panNav.Height = chamcong.Height;
            panNav.Top = chamcong.Top;
            panNav.Left = chamcong.Left;
            chamcong.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void nhanvien_Click(object sender, EventArgs e)
        {
            panNav.Height = nhanvien.Height;
            panNav.Top = nhanvien.Top;
            panNav.Left = nhanvien.Left;
            nhanvien.BackColor = Color.FromArgb(46, 51, 73);
            nhanviengui t2 = new nhanviengui();
            Controls.Add(t2);
            t2.BringToFront();
            t2.Dock = DockStyle.Fill;
            t2.Location = new System.Drawing.Point(186, 0);
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
            pb.Location = new System.Drawing.Point(186, 0);
        }
        private void duan_Click(object sender, EventArgs e)
        {
            panNav.Height = duan.Height;
            panNav.Top = duan.Top;
            panNav.Left = duan.Left;
            duan.BackColor = Color.FromArgb(46, 51, 73);
            duangui d1 = new duangui();
            Controls.Add(d1);
            d1.BringToFront();
            d1.Dock = DockStyle.Fill;
            d1.Location = new System.Drawing.Point(186, 0);
        }
        private void bangluong_Click(object sender, EventArgs e)
        {
            panNav.Height = bangluong.Height;
            panNav.Top = bangluong.Top;
            panNav.Left = bangluong.Left;
            bangluong.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void thongbao_Click(object sender, EventArgs e)
        {
            panNav.Height = thongbao.Height;
            panNav.Top = thongbao.Top;
            panNav.Left = thongbao.Left;
            thongbao.BackColor = Color.FromArgb(46, 51, 73);
            //thongbaogui usctr = new thongbaogui();
            //Controls.Add(usctr);
            //usctr.BringToFront();
            //usctr.Location = new System.Drawing.Point(186, 0);
        }

        private void baohiem_Click(object sender, EventArgs e)
        {
            panNav.Height = baohiem.Height;
            panNav.Top = baohiem.Top;
            panNav.Left = baohiem.Left;
            baohiem.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void tuyendung_Click(object sender, EventArgs e)
        {
            panNav.Height = tuyendung.Height;
            panNav.Top = tuyendung.Top;
            panNav.Left = tuyendung.Left;
            tuyendung.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button10_Click(object sender, EventArgs e)
        { }

        private void LoadUserControlInPanel4(UserControl userControl)
        {
            // Xóa tất cả các UserControl trong panel4
            panel4.Controls.Clear();

            // Thêm UserControl mới vào panel4
            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void home_Leave(object sender, EventArgs e)
        {
            home.BackColor = Color.FromArgb(24, 30, 54);
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

        private void baohiem_Leave(object sender, EventArgs e)
        {
            baohiem.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void bangluong_Leave(object sender, EventArgs e)
        {
            bangluong.BackColor = Color.FromArgb(24, 30, 54);
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
