using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;

namespace Ex12WinFormsMathLib
{
   public partial class Form1 : Form
   {
      double result;

      public Form1()
      {
         InitializeComponent();
      }

      private void btnPlus_Click( object sender, EventArgs e )
      {
         result = Arithmetic.Add( double.Parse( txtBox1.Text ), double.Parse( txtBox2.Text ) );
         listBox1.Items.Add( result );
      }


   }
}
