using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
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

namespace _9_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog()) {
                OFD.Filter = "图片格式|*.jpg;jpeg;*png;*.gif;";
                OFD.Title = "选择轮胎图片";

                if (OFD.ShowDialog() == DialogResult.OK) {
                    pictureBox1.Image = Image.FromFile(OFD.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    CogImageFileTool CIFT = new CogImageFileTool();
                    CIFT.Operator.Open(OFD.FileName, CogImageFileModeConstants.Read);
                    CIFT.Run();

                    string vppFilePath = Path.Combine(Directory.GetCurrentDirectory(), "vpps", "");
                    object CSL = CogSerializer.LoadObjectFromFile(vppFilePath);
                    CogToolBlock CTB = (CogToolBlock)CSL;
                    CTB.Inputs["OutPutImage"].Value = CIFT.OutputImage;

                    CTB.Run();
                    label1.Text = CTB.Outputs[""].Value.ToString();
                }
            }
        }
    }
}
