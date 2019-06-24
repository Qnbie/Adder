using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adder
{
    public partial class Form1 : Form
    {
        private string basedirectory;

        public Form1()
        {
            basedirectory = Directory.GetCurrentDirectory();
            int last = basedirectory.LastIndexOf("\\");
            basedirectory = basedirectory.Remove(last);
            
            InitializeComponent();
        }

        private void BCharacter_Click(object sender, EventArgs e)
        {
            string strTmp;
            if (tbCharacter.Text == "") errorEmpty();
            else
            {
                strTmp = basedirectory + "\\CHR" + "\\" + tbCharacter.Text.ToUpper();
                Directory.CreateDirectory(strTmp);
                Directory.CreateDirectory(strTmp + "\\MODEL");
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\MODEL\\" + tbCharacter.Text.ToUpper() + "_MODEL_01.max");
                Directory.CreateDirectory(strTmp + "\\RIG");
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\RIG\\" + tbCharacter.Text.ToUpper() + "_RIG_01.max");
                Directory.CreateDirectory(strTmp + "\\TEXT");
                Directory.CreateDirectory(strTmp + "\\HAIR");
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\HAIR\\" + tbCharacter.Text.ToUpper() + "_HAIR_01.max");
                Directory.CreateDirectory(strTmp + "\\RENDER");
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\RENDER\\" + tbCharacter.Text.ToUpper() + "_RENDER_01.max");
                Directory.CreateDirectory(strTmp + "\\LATVANY");
                Directory.CreateDirectory(strTmp + "\\ANIM");
                Directory.CreateDirectory(strTmp + "\\MARI");
                tbCharacter.Text = "";
            }
        }

        private void BScene_Click(object sender, EventArgs e)
        {
            string strTmp;
            if (tbScene.Text == "") errorEmpty();
            else
            {
                strTmp = basedirectory + "\\JELENETEK" + "\\" + tbScene.Text;
                //Directorys
                Directory.CreateDirectory(strTmp + "\\RENDER");
                Directory.CreateDirectory(strTmp + "\\SIM");
                Directory.CreateDirectory(strTmp + "\\PC");
                Directory.CreateDirectory(strTmp + "\\HANG");
                Directory.CreateDirectory(strTmp + "\\ANIM");
                //Template Files
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\ANIM\\" + tbScene.Text + "_ANIM_01.max");
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\RENDER\\" + tbScene.Text + "_RENDER_01.max");
                tbScene.Text = "";
            }
        }

        private void BModel_Click(object sender, EventArgs e)
        {
            string strTmp;
            if (tbModel.Text == "") errorEmpty();
            else
            {
                strTmp = basedirectory + "\\MODELS" + "\\" + tbModel.Text.ToUpper();
                Directory.CreateDirectory(strTmp);
                Directory.CreateDirectory(strTmp + "\\MODEL");
                File.Copy(basedirectory + "\\DEVS\\maxTemplate.max", strTmp + $"\\MODEL\\" + tbModel.Text + "_MODEL_01.max");
                Directory.CreateDirectory(strTmp + "\\TEXT");
                Directory.CreateDirectory(strTmp + "\\MARI");
                tbModel.Text = "";
            }
        }

        private void errorEmpty()
        {
            MessageBox.Show("Empty fields!");
        }
    }
}
