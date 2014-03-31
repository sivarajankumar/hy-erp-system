using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;
using System.Text;

namespace Hy.Erp.system.Common
{

    public class ValidateCode
    {
        public void CreateImage(Page containsPage, MemoryStream stream)
        {
            containsPage.Response.Clear();
            containsPage.Response.ContentType = "image/jpeg";
            containsPage.Response.BinaryWrite(stream.ToArray());
        }

        // 随机数生成器，使用静态变量
        private static Random rnd = new Random();

        public string CreateValidateCode(int length)
        {
            // 验证码
            StringBuilder sb = new StringBuilder();
            // 4 位验证码
            for (int i = 0; i < 4; i++)
            {
                // 数字验证码
                string s = rnd.Next(10).ToString();
                sb.Append(s);
            }
            return sb.ToString();
        }

        public MemoryStream CreateValidateGraphic(string validateNum)
        {
            MemoryStream stream2;
            Bitmap image = new Bitmap((int)Math.Ceiling(validateNum.Length * 12.5), 0x16);
            Graphics graphics = Graphics.FromImage(image);
            try
            {
                int num;
                Random random = new Random();
                graphics.Clear(Color.White);
                for (num = 0; num < 0x19; num++)
                {
                    int num2 = random.Next(image.Width);
                    int num3 = random.Next(image.Width);
                    int num4 = random.Next(image.Height);
                    int num5 = random.Next(image.Height);
                    graphics.DrawLine(new Pen(Color.Silver), num2, num4, num3, num5);
                }
                Font font = new Font("Arial", 12f, FontStyle.Italic | FontStyle.Bold);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);
                graphics.DrawString(validateNum, font, brush, (float)3f, (float)2f);
                for (num = 0; num < 50; num++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                graphics.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                stream2 = stream;
            }
            finally
            {
                graphics.Dispose();
                image.Dispose();
            }
            return stream2;
        }

        public static double GetImageHeight()
        {
            return 24.0;
        }

        public static int GetImageWidth(int validateNumLength)
        {
            return (validateNumLength * 14);
        }

        public int MaxLength
        {
            get
            {
                return 10;
            }
        }

        public int MinLength
        {
            get
            {
                return 1;
            }
        }
    }
}


