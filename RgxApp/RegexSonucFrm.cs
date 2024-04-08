using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RgxApp
{
    public partial class RegexSonucFrm : Form
    {
        public RegexSonucFrm()
        {
            InitializeComponent();
        }
        public ListBox SonuclarListBox 
        {
            get { return sncListBox; }
        }
    }
}
