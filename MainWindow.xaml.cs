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

            this.htmlEditor.CSSText = css;
            this.htmlEditor.DocumentHTML = "<P>1)&nbsp;&nbsp;Jegliches Fernbleiben von der Arbeit muss vorher der/dem zuständigen Vorgesetzten gemeldet werden. Ist die Meldung nicht möglich, so ist jedenfalls die/der jeweilige Vorgesetzte unverzüglich zu benachrichtigen.</P><P>Genehmigungspflichtige Abwesenheiten (z.B. Urlaub, Zeitausgleich in der Kernzeit) müssen jedenfalls vorher von der/m zuständigen Vorgesetzten genehmigt werden.</P><P /><P>2)&nbsp;&nbsp;Ist ein/e Angestellte/r durch Krankheit länger als drei Tage verhindert ihren/seinen Dienst zu versehen, so hat sie/er außerdem ohne besondere Aufforderung eine ärztliche Bestätigung beizubringen. Diese Bestätigung kann auch bei kürzerer Krankheitsdauer verlangt werden.</P><P /><P>3)&nbsp;&nbsp;Alle Arbeitsunfälle im Sinne des ASVG sind ohne Verzug dem Personalbüro zu melden.</P><P /><P>4)&nbsp;&nbsp;Bei einer durch Unfall oder Krankheit verursachten Arbeitsunfähigkeit werden der/m Angestellten die vollen Gehaltsbezüge für folgende Zeiträume fortgezahlt:</P><TABLE><COLGROUP><COL WIDTH=\"400\" /><COL WIDTH=\"150\" /><COL WIDTH=\"150\" /></COLGROUP><TR><TD><P>Dienstzeit in der AMA (einschließlich Vordienstzeiten in den Vorgängerorganisationen) </P></TD><TD><P>Volles Entgelt für </P></TD><TD><P>Halbes Entgelt für</P></TD></TR><TR><TD><P>bis 5 Jahre </P></TD><TD><P>45 Kalendertage </P></TD><TD><P>30 Kalendertage</P></TD></TR><TR><TD><P>bis 15 Jahre </P></TD><TD><P>60 Kalendertage </P></TD><TD><P>30 Kalendertage</P></TD></TR><TR><TD><P>bis 25 Jahre </P></TD><TD><P>105 Kalendertage </P></TD><TD><P>30 Kalendertage</P></TD></TR><TR><TD><P>über 25 Jahre </P></TD><TD><P>150 Kalendertage </P></TD><TD><P>30 Kalendertage</P></TD></TR></TABLE><P>Ist die Erkrankung Folge eines Arbeitsunfalles, gebührt volles Entgelt schon bei einer Dienstzeit unter 5 Jahren für 60 Kalendertage.</P><P /><P>5)&nbsp;&nbsp;Tritt innerhalb eines halben Jahres nach Wiederaufnahme der Arbeit abermals eine Dienstverhinderung wegen Krankheit ein, besteht nur Anspruch auf die Hälfte der unter 4) angeführten Entgelte, wenn die Gesamtdauer der Dienstverhinderung die unter 4) bezeichneten Zeiträume übersteigt.</P>";

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

        private string css = @"
body
{
    font-family: Arial;
    font-size: 14px;
}

h3
{
    font-family: Arial;
    font-size: 16px;
    font-weight: bold;
}

p
{
    font-family: Arial;
    font-size: 14px;
}

del
{
    font-family: Arial;
    color: red;
    font-size: 14px;
}

ins {
    font-family: Arial;
    color: blue;
    font-size: 14px;
}


table, td, th
{
    font-family: Arial;
    font-size: 14px;
    border-collapse: collapse !important;
    border: 1px solid black !important;
}

th
{
    font-weight: bold;
}
 

td p
{
    margin: 0;
}

";
    }

}
