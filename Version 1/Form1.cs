using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x_player, y_player;
        int x_computer, y_computer;
        int x_viendan, y_viendan;
        int DiemSo = 0;

        PictureBox[] arrXe = new PictureBox[2];
        PictureBox[] arrDan = new PictureBox[5];

        private void Form1_Load(object sender, EventArgs e)
        {
            

            // thay đổi kích thước Form.
            this.Size = new Size(766, 700);
            XePlayer.Size = new Size(75, 150);
            XeComputer.Size = new Size(75, 150);

            XePlayer.Location = new Point(300, 400);
            NutPlay.Size = new Size(50, 50);
            NutPlay.Location = new Point(this.Width - NutPlay.Width - 10, 10);

            VuNo.Size = new Size(150, 150);
            VuNo.Visible = false;

            VienDan.Size = new Size(30, 100);
            VienDan.Visible = false;


            // tọa độ ban đầu của xe Player
            x_player = XePlayer.Location.X;
            y_player = XePlayer.Location.Y;

            // Tọa độ ban đầu của xe Computer.
            y_computer = 0;
            x_computer = 150;

            timerDiChuyenXe.Interval = 10; // cứ 1/10 giây sẽ gọi hàm tick
            
        }

        bool KiemTraNhan = false; // cờ hiệu
        Point ToaDo;

        private void XePlayer_MouseDown(object sender, MouseEventArgs e)
        {
            KiemTraNhan = true; // đã nhấn chuột.
            ToaDo = e.Location; // cập nhật tọa độ khi nhấn chuột xuống.
        }
        
        private void XePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            // phải là đang còn nhấn xuống thì mới cho phép di chuyển.
            if (KiemTraNhan == true)
            {
                PictureBox a = (PictureBox)(sender);
                Point toadobandau = a.Location; // Lấy tọa độ ban đầu của tấm hình.
                
                // e.Location: Là tọa độ mới sau khi đã di chuyển chuột
                // ToaDo.x: Là tọa độ ngay lúc vừa mới nhấn chuột xuống
                // => khoảng cách dịch chuyển của tấm hình sẽ là hiệu của lần dịch sau - lúc đầu
                toadobandau.X += e.Location.X - ToaDo.X;
                toadobandau.Y += e.Location.Y - ToaDo.Y;

                if (toadobandau.X <= 0)
                {
                    toadobandau.X = 0;
                }
                if (toadobandau.X >= this.Width - XePlayer.Width - 10)
                {
                    toadobandau.X = this.Width - XePlayer.Width - 10;
                }
                if (toadobandau.Y <= 0)
                {
                    toadobandau.Y = 0;
                }
                if (toadobandau.Y >= this.Height - XePlayer.Height - 10)
                {
                    toadobandau.Y = this.Height - XePlayer.Height - 10;
                }

                // cập nhật lại mới tọa độ cho tấm hình.
                XePlayer.Location = toadobandau; // cập nhật lại vị trí mới sau khi di chuyển.


                
            }
        }

        private void XePlayer_MouseUp(object sender, MouseEventArgs e)
        {
            KiemTraNhan = false;
        }

        private void timerDiChuyenXe_Tick(object sender, EventArgs e)
        {
            
            y_computer += 10;

            // cập nhật lại tọa độ mới cho xe computer
            XeComputer.Location = new Point(x_computer, y_computer);

            // Cho xe đi hết Form thì quy trở lại ban đầu.
            if (y_computer >= this.Height)
            {
                DiemSo++; // tăng lên 1 điểm.
                lblDiemSo.Text = "Score: " + DiemSo.ToString();
                timerDiChuyenXe.Interval = 10;

                //if (DiemSo == 5)
                //{
                //    timerDiChuyenXe.Interval = 50;
                //}
                //else if (DiemSo == 10)
                //{
                //    timerDiChuyenXe.Interval = 20;
                //}
                //else if (DiemSo == 15)
                //{
                //    timerDiChuyenXe.Interval = 10;
                //}
                //else if (DiemSo > 20)
                //{
                //    timerDiChuyenXe.Interval = 1;
                //}

                y_computer = 0;

                // thay đổi lại x nằm trong đoạn từ 0 --> this.Width - XeComputer.Width
                Random rd = new Random();
                x_computer = rd.Next(0, this.Width - XeComputer.Width);
            }

            // Kiểm tra va chạm giữa 2 xe. (giữa 2 picture box)
            if (XeComputer.Visible == true && XePlayer.Visible == true)
            {
                if (XeComputer.Location.Y + XeComputer.Height >= XePlayer.Location.Y)
                {
                    if (XePlayer.Location.X >= XeComputer.Location.X - XePlayer.Width && XePlayer.Location.X <= XeComputer.Location.X + XePlayer.Width)
                    {
                        timerDiChuyenXe.Stop(); // dừng lại timer lại.
                        VuNo.Visible = true; // Hiện vụ nổ.
                        XePlayer.Visible = false; // mất xe
                        XeComputer.Visible = false; // mất xe

                        VuNo.Location = new Point(XePlayer.Location.X, XePlayer.Location.Y);

                        DialogResult luachon = MessageBox.Show("Bạn có muốn tiếp tục trò chơi ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (luachon == DialogResult.Yes)
                        {
                            DiemSo = 0;
                            lblDiemSo.Text = "Score: ";

                            timerDiChuyenXe.Start(); // choi lai tu dau
                            KiemTraNhan = false; // reset lại cờ hiệu
                            VuNo.Visible = false; // ẩn vụ nổ
                            XeComputer.Visible = true; // hiện lại xe
                            XePlayer.Visible = true; // hiện lại xe

                            y_computer = 0;

                            // thay đổi lại x nằm trong đoạn từ 0 --> this.Width - XeComputer.Width
                            Random rd = new Random();
                            x_computer = rd.Next(0, this.Width - XeComputer.Width);

                            XeComputer.Location = new Point(x_computer, y_computer); // cập nhật lại 
                        }
                        else
                        {
                            DaChoi = true;
                            Application.Exit();
                        }

                    }
                }
            }
            

            // Bắn đạn
            if (VienDan.Visible == true)
            {
                y_viendan -= 10;
                VienDan.Location = new Point(x_viendan, y_viendan);

                // Kiểm tra sự va chạm giữa viên đạn với xe Computer
                if (XeComputer.Location.Y + XeComputer.Height >= VienDan.Location.Y)
                {
                    if (VienDan.Location.X >= XeComputer.Location.X - VienDan.Width && VienDan.Location.X <= XeComputer.Location.X + XeComputer.Width)
                    {
                        XeComputer.Visible = false; // Biến mất
                        VienDan.Visible = false; // biến mất.
                    }
                }
            }

            // Nếu như y_XeComputer mà chạm đáy thì lại cho xe hiện lại
            if (y_computer + XeComputer.Height >= this.Height)
            {
                y_computer = 0;
                Random rd = new Random();
                x_computer = rd.Next(0, this.Width - XeComputer.Width);
                XeComputer.Location = new Point(x_computer, y_computer); // cập nhật lại 

                XeComputer.Visible = true;
            }

        }

        bool DaChoi = false;
        int dem = 0;

        private void XeComputer_Click(object sender, EventArgs e)
        {

        }

        private void XePlayer_Click(object sender, EventArgs e)
        {

        }

        private void NutPlay_Click(object sender, EventArgs e)
        {
           
            dem++;
            if (dem % 2 != 0)
            {
                timerDiChuyenXe.Start();
            }
            else
            {
                timerDiChuyenXe.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DaChoi == true)
            {
                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("ê ! Phải chơi rồi nếu thua mới tắt được");
                e.Cancel = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                VienDan.Visible = true;
                y_viendan = XePlayer.Location.Y - VienDan.Height - 10;
                x_viendan = XePlayer.Location.X + XePlayer.Width / 2;

                VienDan.Location = new Point(x_viendan, y_viendan);
            }
        }
    }
}
