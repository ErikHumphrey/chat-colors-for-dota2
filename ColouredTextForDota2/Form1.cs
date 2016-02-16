﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColouredTextForDota2
{
    public partial class frmDotaColor : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
    IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fontNormal;

        public frmDotaColor()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.chat;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.chat.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.chat.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontNormal = new Font(fonts.Families[0], 12F, FontStyle.Bold);
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            string messageToCopy = txtUserTextEntry.Text
                .Replace("[default]", "")
                .Replace("[orange]", "")
                .Replace("[violet]", "")
                .Replace("[pink]", "")
                .Replace("[magenta]", "")
                .Replace("[rose]", "")
                .Replace("[red]", "")
                .Replace("[orange]", "")
                .Replace("[gold]", "")
                .Replace("[yellow]", "")
                .Replace("[mintgreen]", "")
                .Replace("[limegreen]", "")
                .Replace("[ferngreen]", "")
                .Replace("[olive]", "")
                .Replace("[blue]", "")
                .Replace("[white]", "")
                .Replace("[grey]", "");
            Clipboard.Clear();    // Clear if any old value is there in Clipboard        
            Clipboard.SetText(messageToCopy); // Copy text to Clipboard
            string strClip = Clipboard.GetText(); // Get text from Clipboard
        }

        private void frmDotaColor_Load(object sender, EventArgs e)
        {
            lblHeroName.Font = lblHeroNameBlack.Font = fontNormal; 

            lblHeroName.Parent = lblHeroNameBlack;
            lblHeroName.Location = new Point(-1, -2);
            lblColonBlack.Parent = lblHeroName;
            lblColonBlack.Location = new Point(106, 2);
            lblColon.Parent = lblColonBlack;
            lblColon.Location = new Point(-1, -2);
            lblPreviewText.Parent = lblPreviewTextBlack;
            lblPreviewText.Location = new Point(-1, -2);
        }

        private void txtUserTextEntry_TextChanged(object sender, EventArgs e)
        {
            string textToDisplay = "                                      " + txtUserTextEntry.Text
                .Replace("[default]", "")
                .Replace("[orange]", "")
                .Replace("[violet]", "")
                .Replace("[pink]", "")
                .Replace("[magenta]", "")
                .Replace("[rose]", "")
                .Replace("[red]", "")
                .Replace("[orange]", "")
                .Replace("[gold]", "")
                .Replace("[yellow]", "")
                .Replace("[mintgreen]", "")
                .Replace("[limegreen]", "")
                .Replace("[ferngreen]", "")
                .Replace("[olive]", "")
                .Replace("[blue]", "")
                .Replace("[white]", "")
                .Replace("[grey]", "");
            lblPreviewText.Text = lblPreviewTextBlack.Text = textToDisplay;
        }

        void caretToEnd()
        {
            txtUserTextEntry.Focus();
            txtUserTextEntry.SelectionStart = txtUserTextEntry.Text.Length;
            txtUserTextEntry.SelectionLength = 0;
        }

        private void btnClearTextEntry_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Clear();
        }

        private void lblColorDefault_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[default]";
            lblPreviewText.ForeColor = lblColorDefault.BackColor;
            caretToEnd();
        }

        private void lblColorViolet_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[violet]";
            lblPreviewText.ForeColor = lblColorViolet.BackColor;
            caretToEnd();
        }

        private void lblColorPink_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[pink]";
            lblPreviewText.ForeColor = lblColorPink.BackColor;
            caretToEnd();
        }

        private void lblColorMagenta_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[magenta]";
            lblPreviewText.ForeColor = lblColorMagenta.BackColor;
            caretToEnd();
        }

        private void lblColorRose_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[rose]";
            lblPreviewText.ForeColor = lblColorRose.BackColor;
            caretToEnd();
        }

        private void lblColorRed_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[red]";
            lblPreviewText.ForeColor = lblColorRed.BackColor;
            caretToEnd();
        }

        private void lblColorOrange_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[orange]";
            lblPreviewText.ForeColor = lblColorOrange.BackColor;
            caretToEnd();
        }

        private void lblColorGold_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[gold]";
            lblPreviewText.ForeColor = lblColorGold.BackColor;
            caretToEnd();
        }

        private void lblColorYellow_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[yellow]";
            lblPreviewText.ForeColor = lblColorYellow.BackColor;
            caretToEnd();
        }

        private void lblColorMintgreen_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[mintgreen]";
            lblPreviewText.ForeColor = lblColorMintgreen.BackColor;
            caretToEnd();
        }

        private void lblColorLimegreen_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[limegreen]";
            lblPreviewText.ForeColor = lblColorLimegreen.BackColor;
            caretToEnd();
        }

        private void lblColorFerngreen_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[ferngreen]";
            lblPreviewText.ForeColor = lblColorFerngreen.BackColor;
            caretToEnd();
        }

        private void lblColorOlive_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[olive]";
            lblPreviewText.ForeColor = lblColorOlive.BackColor;
            caretToEnd();
        }

        private void lblColorBlue_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[blue]";
            lblPreviewText.ForeColor = lblColorBlue.BackColor;
            caretToEnd();
        }

        private void lblColorWhite_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[white]";
            lblPreviewText.ForeColor = lblColorWhite.BackColor;
            caretToEnd();
        }

        private void lblColorGrey_Click(object sender, EventArgs e)
        {
            txtUserTextEntry.Text += "[grey]";
            lblPreviewText.ForeColor = lblColorGrey.BackColor;
            caretToEnd();
        }

        private void frmDotaColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutWindow = new frmAbout();
            aboutWindow.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp helpWindow = new frmHelp();
            helpWindow.ShowDialog();
        }
    }
}
