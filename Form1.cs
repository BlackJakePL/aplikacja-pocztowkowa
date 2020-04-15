using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;


namespace aplikacja_pocztowkowa
{

    public partial class Aplikacja_pocztowkowa : Form
    {
        FontFamily fontName;
        string imgFilename="",saveFilename="";
        bool flag1=false,flag2=false,flag3=false;
        XImage photo, frame=null,rewers= XImage.FromFile("Resources\\Rewers.jpg");

        public Aplikacja_pocztowkowa()
        {
            InitializeComponent();
        }

        private void tbSenderName_Enter(object sender, EventArgs e)
        {
            if(tbSenderName.Text=="Imie")
            {
                tbSenderName.Text = "";
                tbSenderName.ForeColor = Color.Black;
            }
        }

        private void tbSenderName_Leave(object sender, EventArgs e)
        {
            if (tbSenderName.Text == "")
            {
                tbSenderName.Text = "Imie";
                tbSenderName.ForeColor = Color.Gray;
            }
        }

        private void tbSenderSurname_Leave(object sender, EventArgs e)
        {
            if (tbSenderSurname.Text == "")
            {
                tbSenderSurname.Text = "Nazwisko";
                tbSenderSurname.ForeColor = Color.Gray;
            }
        }

        private void tbSenderSurname_Enter(object sender, EventArgs e)
        {
            if (tbSenderSurname.Text == "Nazwisko")
            {
                tbSenderSurname.Text = "";
                tbSenderSurname.ForeColor = Color.Black;
            }
        }

        private void tbCity_Enter(object sender, EventArgs e)
        {
            if (tbCity.Text == "Miejscowość")
            {
                tbCity.Text = "";
                tbCity.ForeColor = Color.Black;
            }
        }

        private void tbCity_Leave(object sender, EventArgs e)
        {
            if (tbCity.Text == "")
            {
                tbCity.Text = "Miejscowość";
                tbCity.ForeColor = Color.Gray;
            }
        }

        private void tbWishes_Leave(object sender, EventArgs e)
        {
            if (tbWishes.Text == "")
            {
                tbWishes.Text = "Życzenia...";
                tbWishes.ForeColor = Color.Gray;
            }
        }
        
        private void tbWishes_Enter(object sender, EventArgs e)
        {
            if (tbWishes.Text == "Życzenia...")
            {
                tbWishes.Text = "";
                tbWishes.ForeColor = Color.Black;
            }
        }

        private void Aplikacja_pocztowkowa_Load(object sender, EventArgs e)
        {

        }

        private void tbReceiverTitle_Enter(object sender, EventArgs e)
        {
            if (tbReceiverTitle.Text == "Przedrostek")
            {
                tbReceiverTitle.Text = "";
                tbReceiverTitle.ForeColor = Color.Black;
            }
        }

        private void tbReceiverTitle_Leave(object sender, EventArgs e)
        {
            if (tbReceiverTitle.Text == "")
            {
                tbReceiverTitle.Text = "Przedrostek";
                tbReceiverTitle.ForeColor = Color.Gray;
            }
        }

        private void tbReceiverName_Enter(object sender, EventArgs e)
        {
            if (tbReceiverName.Text == "Imie")
            {
                tbReceiverName.Text = "";
                tbReceiverName.ForeColor = Color.Black;
            }
        }

        private void tbReceiverName_Leave(object sender, EventArgs e)
        {
            if (tbReceiverName.Text == "")
            {
                tbReceiverName.Text = "Imie";
                tbReceiverName.ForeColor = Color.Gray;
            }
        }

        private void tbReceiverSurname_Enter(object sender, EventArgs e)
        {
            if (tbReceiverSurname.Text == "Nazwisko")
            {
                tbReceiverSurname.Text = "";
                tbReceiverSurname.ForeColor = Color.Black;
            }
        }

        private void tbReceiverSurname_Leave(object sender, EventArgs e)
        {
            if (tbReceiverSurname.Text == "")
            {
                tbReceiverSurname.Text = "Nazwisko";
                tbReceiverSurname.ForeColor = Color.Gray;
            }
        }

        private void tbReceiverStreet_Enter(object sender, EventArgs e)
        {
            if (tbReceiverStreet.Text == "Ulica/Miejscowość nr")
            {
                tbReceiverStreet.Text = "";
                tbReceiverStreet.ForeColor = Color.Black;
            }
        }

        private void tbReceiverStreet_Leave(object sender, EventArgs e)
        {
            if (tbReceiverStreet.Text == "")
            {
                tbReceiverStreet.Text = "Ulica/Miejscowość nr";
                tbReceiverStreet.ForeColor = Color.Gray;
            }
        }

        private void tbReceiverPost_Enter(object sender, EventArgs e)
        {
            if (tbReceiverPost.Text == "Kod Poczta")
            {
                tbReceiverPost.Text = "";
                tbReceiverPost.ForeColor = Color.Black;
            }
        }

        private void tbReceiverPost_Leave(object sender, EventArgs e)
        {
            if (tbReceiverPost.Text == "")
            {
                tbReceiverPost.Text = "Kod Poczta";
                tbReceiverPost.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            fontName = fontDialog1.Font.FontFamily;
            flag2 = true;
            flagFont.Visible = false;
            if ((flag1==true)&&(flag2==true)&&(flag3==true))
            {
                btnCreate.Enabled = true;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFilename = saveFileDialog1.FileName;
            if (saveFilename != "")
            {
                flag3 = true;
                FlagFile.Visible = false;
                if ((flag1 == true) && (flag2 == true) && (flag3 == true))
                {
                    btnCreate.Enabled = true;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(radioFirst.Checked)
            {
                frame = XImage.FromFile("Resources\\first.png");
            }
            if (radioSecond.Checked)
            {
                frame = XImage.FromFile("Resources\\second.png");
            }
            if (radioThird.Checked)
            {
                frame = XImage.FromFile("Resources\\third.png");
            }

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Width = 1748;
            page.Height = 1240;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            int width = this.photo.PixelWidth;
            int height = this.photo.PixelHeight;
            gfx.DrawImage(this.photo, 0, 0, 1748, 1240);
            if (frame != null)
            {
                gfx.DrawImage(this.frame, 0, 0, 1748, 1240);
            }
            PdfPage pageR = document.AddPage();
            pageR.Width = 1748;
            pageR.Height = 1240;
            XGraphics gfxR = XGraphics.FromPdfPage(pageR);
            
            gfxR.DrawImage(this.rewers, 0, 0, 1748, 1240);

            XFont font = new XFont(fontName, 32, XFontStyle.BoldItalic);
            var tf = new XTextFormatter(gfxR);
            var rect = new XRect(50, 300, 800, 500);

            XPen xpen = new XPen(XColors.White, 0.4);

            gfxR.DrawRectangle(xpen, rect);

            XStringFormat format = new XStringFormat();
            format.LineAlignment = XLineAlignment.Near;
            format.Alignment = XStringAlignment.Near;

            string data = dateTimePicker.Value.ToString(), wishes = tbWishes.Text, names = tbSenderName.Text + " " + tbSenderSurname.Text,
                pref = tbReceiverTitle.Text, recNames = tbReceiverName.Text + " " + tbReceiverSurname.Text, street= tbReceiverStreet.Text,
                post=tbReceiverPost.Text;
            data = data + ", " + tbCity.Text;
            gfxR.DrawString(data,font,XBrushes.Black, 
                new XRect(-940,90 , page.Width, page.Height), XStringFormats.TopRight);
            tf.DrawString(wishes,font,XBrushes.Black,
                new XRect(rect.X + 5, rect.Y, rect.Width - 5, 500), format);
            gfxR.DrawString(names, font, XBrushes.Black,
                new XRect(-940, 1000, page.Width, page.Height), XStringFormats.TopRight);
            gfxR.DrawString(pref, font, XBrushes.Black,
                new XRect(1050, 600, page.Width, page.Height), XStringFormat.TopLeft);
            gfxR.DrawString(recNames, font, XBrushes.Black,
                new XRect(1050, 735, page.Width, page.Height), XStringFormat.TopLeft);
            gfxR.DrawString(street, font, XBrushes.Black,
                new XRect(1050, 870, page.Width, page.Height), XStringFormat.TopLeft);
            gfxR.DrawString(post, font, XBrushes.Black,
                new XRect(1050, 1010, page.Width, page.Height), XStringFormat.TopLeft);


            while (File.Exists(saveFilename + ".pdf"))
            {
                saveFilename = saveFilename + "1";
            }
            saveFilename = saveFilename + ".pdf";
            document.Save(saveFilename + ".pdf");
            MessageBox.Show("Utworzono dokument w: " + saveFilename );

        }

        private void btnImageChoice_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imgFilename = openFileDialog1.FileName;
            lbFileLocal.Text=imgFilename;
            pbPhoto.ImageLocation = imgFilename;
            photo = XImage.FromFile(imgFilename);
            if (imgFilename != "")
            {
                flag1 = true;
                flagPhoto.Visible = false;
                if ((flag1 == true) && (flag2 == true) && (flag3 == true))
                {
                    btnCreate.Enabled = true;
                }
            }
        }
    }
}
