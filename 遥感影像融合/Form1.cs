using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 遥感影像融合
{
    public partial class Form1 : Form
    {
        Image img1;//全色影像
        Image img2;//多光谱影像
        private Bitmap Fusion_map;//融合图

        public Form1()
        {
            InitializeComponent();
        }

        //遥感图像读入
        private void 遥感图像读入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img1 = Image.FromFile(@"spot.tif");
            this.pictureBox1.Image = img1;

            img2 = Image.FromFile(@"tm_743.tif");
            this.pictureBox2.Image = img2;

        }
        //比值变换融合
        private void 比值变换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                Fusion_map = new Bitmap(img1.Width, img1.Height);
                Bitmap map1 = (Bitmap)img1;
                Bitmap map2 = (Bitmap)img2;
                int r, g, b,rgb,r1,r2,g2,b2;

                for(int i=0;i<img1.Width;i++)
                {
                    for(int j=0;j<img1.Height;j++)
                    {
                        Color pixel1 = map1.GetPixel(i, j);
                        Color pixel2 = map2.GetPixel(i, j);

                        r1 = pixel1.R;
                        r2 = pixel2.R;
                        g2 = pixel2.G;
                        b2 = pixel2.B;
                        rgb = r2+g2+b2;

                        r = (int)(r2*1.0/ rgb * r1);
                        g = (int)(g2 * 1.0 / rgb * r1);
                        b = (int)(b2 * 1.0 / rgb * r1);

                        Fusion_map.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }

                Fusion_map.Save("比值变换融合图.bmp");
                Form2 form2 = new Form2();//实例化Form2窗体
                form2.Show();//显示实例化后的窗体
                form2.draw("比值变换融合图.bmp");
            }
            else MessageBox.Show("图像大小不一致无法完成融合！");
        }

        //乘积变换融合
        private void 乘积变换融合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                Fusion_map = new Bitmap(img1.Width, img1.Height);
                Bitmap map1 = (Bitmap)img1;
                Bitmap map2 = (Bitmap)img2;
                int r, g, b, r1, r2, g2, b2;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = map1.GetPixel(i, j);
                        Color pixel2 = map2.GetPixel(i, j);

                        r1 = pixel1.R;

                        r2 = pixel2.R;
                        g2 = pixel2.G;
                        b2 = pixel2.B;
                       

                        r = r1 * r2/255;
                        g = r1 * g2/255;
                        b = r1 * b2/255;

                        Fusion_map.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }

                Fusion_map.Save("乘积变换融合图.bmp");
                Form2 form2 = new Form2();//实例化Form2窗体
                form2.Show();//显示实例化后的窗体
                form2.draw("乘积变换融合图.bmp");
            }
            else MessageBox.Show("图像大小不一致无法完成融合！");
        }

        //加权变换融合
        private void 加权融合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                double R1, R2, R3;
                double R11, R12, R13, R21, R22, R23, R31, R32, R33;
                double mean1, mean2_r, mean2_g, mean2_b;
                int r1 = 0;
                int r2 = 0;
                int g2 = 0;
                int b2 = 0;

                Fusion_map = new Bitmap(img1.Width, img1.Height);
                Bitmap map1 = (Bitmap)img1;
                Bitmap map2 = (Bitmap)img2;

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = map1.GetPixel(i, j);
                        Color pixel2 = map2.GetPixel(i, j);

                        r1 += pixel1.R;

                        r2 += pixel2.R;
                        g2 += pixel2.G;
                        b2 += pixel2.B;
                    }
                }

                mean1 = r1 * 1.0 / (img1.Width * img1.Height);
                mean2_r = r2 * 1.0 / (img1.Height * img1.Width);
                mean2_g = g2 * 1.0 / (img1.Height * img1.Width);
                mean2_b = b2 * 1.0 / (img1.Height * img1.Width);

                R11 = R12 = R13 = R21 = R22 = R23 = R31 = R32 = R33 = 0;
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = map1.GetPixel(i, j);
                        Color pixel2 = map2.GetPixel(i, j);

                        R11 += (pixel1.R - mean1) * (pixel2.R - mean2_r);
                        R21 += (pixel1.R - mean1) * (pixel2.G - mean2_g);
                        R31 += (pixel1.R - mean1) * (pixel2.B - mean2_b);

                        R12 += (pixel1.R - mean1) * (pixel1.R - mean1);

                        R13 += (pixel2.R - mean2_r) * (pixel2.R - mean2_r);
                        R23 += (pixel2.G - mean2_g) * (pixel2.G - mean2_g);
                        R33 += (pixel2.B - mean2_b) * (pixel2.B - mean2_b);
                    }

                }

                R22 = R32 = R12;

                R1 = R11 / Math.Sqrt(R12 * R13);
                R2 = R21 / Math.Sqrt(R22 * R23);
                R3 = R31 / Math.Sqrt(R32 * R33);

                double Pri, Prj, Pgi, Pgj, Pbi, Pbj;

                Pri = (1 - Math.Abs(R1)) / 2;
                Prj = 1 - Pri;

                Pgi = (1 - Math.Abs(R2)) / 2;
                Pgj = 1 - Pgi;

                Pbi = (1 - Math.Abs(R3)) / 2;
                Pbj = 1 - Pbi;

                int r, g, b;
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = map1.GetPixel(i, j);
                        Color pixel2 = map2.GetPixel(i, j);

                        r = (int)(Pri * pixel1.R + Prj * pixel2.R);
                        g = (int)(Pgi * pixel1.R + Pgj * pixel2.G);
                        b = (int)(Pbi * pixel1.R + Pbj * pixel2.B);

                        Fusion_map.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }

                }

                Fusion_map.Save("加权融合图.bmp");
                Form2 form2 = new Form2();//实例化Form2窗体
                form2.Show();//显示实例化后的窗体
                form2.draw("加权融合图.bmp");
            }
            else MessageBox.Show("图像大小不一致无法完成融合！");
   
        }


        //平均梯度评价
        private void 平均梯度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double Gr, Gg, Gb;
            int delt_xr, delt_yr, delt_xg, delt_yg, delt_xb, delt_yb;

            double map_r,map_g,map_b; 
            map_r = map_g = map_b = 0;

            for(int i=0;i<Fusion_map.Width-1;i++)
            {
                for(int j=0;j<Fusion_map.Height-1;j++)
                {
                    Color pixel=Fusion_map.GetPixel(i,j);
                    Color pixel_x=Fusion_map.GetPixel(i+1,j);
                    Color pixel_y=Fusion_map.GetPixel(i,j+1);

                    delt_xr = (pixel_x.R - pixel.R) * (pixel_x.R - pixel.R);
                    delt_yr = (pixel_y.R - pixel.R) * (pixel_y.R - pixel.R);

                    delt_xg = (pixel_x.G - pixel.G) * (pixel_x.G - pixel.G);
                    delt_yg = (pixel_y.G - pixel.G) * (pixel_y.G- pixel.G);

                    delt_xb = (pixel_x.B - pixel.B) * (pixel_x.B - pixel.B);
                    delt_yb = (pixel_y.B - pixel.B) * (pixel_y.B - pixel.B);

                    map_r += Math.Sqrt(delt_xr + delt_yr);
                    map_g += Math.Sqrt(delt_xg + delt_yg);
                    map_b += Math.Sqrt(delt_xb + delt_yb);

                }

            }

            Gr = map_r / ((Fusion_map.Width - 1) * (Fusion_map.Height - 1));
            Gg = map_g / ((Fusion_map.Width - 1) * (Fusion_map.Height - 1));
            Gb = map_b / ((Fusion_map.Width - 1) * (Fusion_map.Height - 1));

            MessageBox.Show("融合图三通道平均梯度" + "\r\n"+"Gr:" + Gr.ToString() + "   " + "Gg:" + Gg.ToString() + "   " + "Gb:" + Gb.ToString());
        }

        //偏差指数评价
        private void 偏差指数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double Br, Bg, Bb;//三通道偏差指数

            double r, g, b;
            r = g = b=0;
            Bitmap map2=(Bitmap)img2;

            for(int i=0;i<Fusion_map.Width;i++)
            {
                for(int j=0;j<Fusion_map.Height;j++)
                {
                    Color pixel1 = Fusion_map.GetPixel(i, j);
                    Color piexl2 = map2.GetPixel(i, j);

                    r += Math.Abs(pixel1.R - piexl2.R) * 1.0 / piexl2.R;
                    g += Math.Abs(pixel1.G - piexl2.G) * 1.0 / piexl2.G;
                    b += Math.Abs(pixel1.B - piexl2.B) * 1.0 / piexl2.B;

                }
            }

            Br = r / (Fusion_map.Width * Fusion_map.Height);
            Bg = g / (Fusion_map.Width * Fusion_map.Height);
            Bb = b / (Fusion_map.Width * Fusion_map.Height);

            MessageBox.Show("融合图三通道偏差指数" + "\r\n" + "Br:" + Br.ToString() + "   " + "Bg:" + Bg.ToString() + "   " + "Bb:" + Bb.ToString());
        }
    }
}
