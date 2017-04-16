﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PowerfulSample().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MarkerToolSample().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomStyleSample().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new VisibleRangeChangedDelayedSample().Show();
            Cursor = Cursors.Default;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new SimplestSyntaxHighlightingSample().Show();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            new SimplestCodeFoldingSample().Show();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            new DynamicSyntaxHighlighting().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new SyntaxHighlightingByXmlDescription().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new IMEsample().Show();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            new GifImageDrawingSample().Show();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            new TooltipSample().Show();
        }



        private void button20_Click(object sender, EventArgs e)
        {
            new LazyLoadingSample().Show();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            new BilingualHighlighterSample().Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            new CustomTextSourceSample().Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            new HintSample().Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            new ReadOnlyBlocksSample().Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            new PredefinedStylesSample().Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            new MacrosSample().Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            new OpenTypeFontSample().Show();
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            new Sandbox().ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            new RulerSample().Show();
        }


        private void button35_Click(object sender, EventArgs e)
        {
            new DiffMergeSample().Show();
        }

    }
}
