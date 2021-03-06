﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Simples_Scanner
{
    public partial class SelecProc : Form
    {

        public SelecProc()
        {
            InitializeComponent();
        }
        public Process ProcSelecionado;
        public bool Selecionado = false;
        void Atualizar()
        {
            listBox1.Items.Clear();
            foreach(Process p in Process.GetProcesses())
            {
                listBox1.Items.Add(p.ProcessName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                if (Process.GetProcessesByName(listBox1.SelectedItem.ToString()).Length > 0)
                {
                    ProcSelecionado = Process.GetProcessesByName(listBox1.SelectedItem.ToString())[0];
                    Selecionado = true;
                    this.Close();
                }
            }
        }

        private void SelecProc_Load(object sender, EventArgs e)
        {
            Atualizar();
        }
    }
}
