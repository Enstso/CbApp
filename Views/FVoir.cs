using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;

namespace Views
{
    public partial class FVoir : Form
    {
        public FVoir(List<Cours> cours)
        {
            InitializeComponent();
            List<Cours> liste = cours;
            foreach (Cours c in liste)
            {
                lbVoir.Items.Add(c);
            }
        }
    }
}
