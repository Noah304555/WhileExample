/*
 * Noah Irving
 * March 8, 2019
 * While example
 * needs a label called output
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace while_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader reader = new System.IO.StreamReader("myFile.txt");
            try {
                string output = "";
                while(!reader.EndOfStream)
                {
                    output +=  reader.ReadLine() + Environment.NewLine;
                }
                output = output.Trim();
                lblOutput.Content = output;
            } catch (Exception ex) {  }

        }
    }
}
