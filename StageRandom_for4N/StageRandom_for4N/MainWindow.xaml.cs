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
using System.Collections;
using YukariGames;

namespace StageRandom_for4N
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList cName = new ArrayList();
            ArrayList sName = new ArrayList();
            Random rand = new Random();
            TextLoadClass textLoadClass = new TextLoadClass();
            textLoadClass.TextRoad(ref cName, "Character.txt", "UTF-8");
            textLoadClass.TextRoad(ref sName, "stage.txt", "UTF-8");
            int cnum = rand.Next(cName.Count-1);
            int snum = rand.Next(sName.Count-1);
            this.CharacterName.Text = (string)cName[cnum];
            this.StageBox.Text = (string)sName[snum];
        }
    }
}
