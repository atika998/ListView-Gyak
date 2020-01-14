using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDataBase_01_14
{
    
    public partial class Form1 : Form
    {
        model Model;
        public Form1(model mod)
        {
            Model = mod;
            InitializeComponent();

            button1.Click += (s, e) => { };
    //-------------------------------------------//
            button2.Click += (s, e) => { };
    //-------------------------------------------//
            button3.Click += (s, e) => { };
    //-------------------------------------------//
            button4.Click += (s, e) => { };
    //-------------------------------------------//
            button5.Click += (s, e) => { };
    //-------------------------------------------//
            button6.Click += (s, e) => { };
    //-------------------------------------------//
            button7.Click += (s, e) => { Application.Exit(); };
    //-------------------------------------------//
        }
    }
}
