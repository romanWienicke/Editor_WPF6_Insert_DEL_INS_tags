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

namespace Editor_WPF6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.htmlEditor.CSSText = "body {font-family: Arial}";
            this.htmlEditor.DocumentHTML = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla iaculis, ipsum id vestibulum cursus, " +
                "felis lectus tristique mi, dictum bibendum justo ligula sollicitudin quam. Nullam vitae mauris ligula.</p><p>" +
                "Phasellus in euismod tellus. Cras et turpis id tortor facilisis euismod vel at nibh. Nulla mattis consequat leo in efficitur." +
                " Proin eget arcu ullamcorper, interdum metus vel, placerat lacus</p>";

            this.htmlEditor.HiddenButtons = "tsbPrint; tsbPrintPreview; tsbElementProperties";
            this.htmlEditor.CodeEditor.WordWrap = true;

            var oDEL = this.htmlEditor.ToolStripItems.Add("DEL");
            oDEL.Padding = new System.Windows.Forms.Padding(3);
            oDEL.Click += ODEL_Click;

            var oINS = this.htmlEditor.ToolStripItems.Add("INS");
            oINS.Padding = new System.Windows.Forms.Padding(3);
            oINS.Click += OINS_Click;

        }

        private void OINS_Click(object? sender, EventArgs e)
        {
            var Element = this.htmlEditor.SurroundSelectionWithElementType("ins");
            if (Element != null) Element.Style = "color: red";
        }

        private void ODEL_Click(object? sender, EventArgs e)
        {
            var Element = this.htmlEditor.SurroundSelectionWithElementType("del");
            if (Element != null) Element.Style = "color: red";
        }
    }
}
