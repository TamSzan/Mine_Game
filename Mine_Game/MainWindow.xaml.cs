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

namespace Mine_Game
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sizeX = 10;
        int sizeY = 10;
        int mines = 10;
        Button[,] table;
                
        public MainWindow()
        {
            InitializeComponent();
            Title = "Mine Game";
        }        

        private void CreateTable()
        {
            table = new Button[sizeY + 2, sizeX + 2];
            gr.ColumnDefinitions.Clear();
            gr.RowDefinitions.Clear();
            for (int i = 0; i < sizeX; i++)
            {
                gr.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < sizeY; i++)
            {
                gr.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < sizeY + 2; i++)
            { 
                for (int j = 0; j < sizeX + 2; j++)
                {
                    Button b = new Button();
                    b.Tag = "";
                    b.FontSize = 20;
                    b.FontWeight = FontWeights.Bold;               
                    table[i, j] = b;
                    if (i > 0 && j > 0 && i < sizeY + 1 && j < sizeX + 1)
                    {
                        table[i, j].Click += Button_Click;
                        table[i, j].MouseRightButtonDown += RightButton_Down;
                        gr.Children.Add(b);
                        Grid.SetRow(b, i - 1);
                        Grid.SetColumn(b, j - 1);
                    }
                    b.Name = "w" + i + "w" + j;
                }
            }
            SetMines();
        }

        private void RightButton_Down(object sender, MouseButtonEventArgs e)
        {
            Button _temp = (Button)sender;            
            if(_temp.Tag.ToString() == "#")
            {
                _temp.Content = _temp.Tag;
                _temp.Click -= Button_Click;
                _temp.MouseRightButtonDown -= RightButton_Down;
                mines--;
                if (mines == 0)
                {
                    MessageBox.Show("You Win!!!");
                    CreateTable();
                }
            }
            else
            {
                _temp.Content = _temp.Tag;
                MessageBox.Show("Game Over!!!");
                CreateTable();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button _temp = (Button)sender;
            if (_temp.Tag.ToString() == "0")
            {
                Recursive(_temp);
            }
            else if (_temp.Tag.ToString() != "#")
            {
                _temp.Content = _temp.Tag;
                _temp.Click -= Button_Click;
                _temp.MouseRightButtonDown -= RightButton_Down;
            }
            else
            {
                _temp.Content = _temp.Tag;
                MessageBox.Show("Game Over!!!");
                CreateTable();
            }            
        }

        private void Recursive(Button _temp)
        {
            _temp.IsEnabled = false;
            _temp.Tag = "";
            var nr = _temp.Name.Split('w');
            int y = Convert.ToInt32(nr[1]);
            int x = Convert.ToInt32(nr[2]);
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    Button b = table[y + i, x + j];
                    b.Content = b.Tag;
                    b.Click -= Button_Click;
                    b.MouseRightButtonDown -= RightButton_Down;
                }
            }
            if (table[y , x + 1].Tag.ToString() == "0")
                Recursive(table[y , x + 1]);
            if (table[y - 1, x].Tag.ToString() == "0")
                Recursive(table[y - 1, x]);
            if (table[y , x - 1 ].Tag.ToString() == "0")
                Recursive(table[y , x - 1]);
            if (table[y + 1, x].Tag.ToString() == "0")
                Recursive(table[y + 1, x]);
        }

        private void SetMines()
        {
            int m = mines;
            Random rd = new Random();
            do
            {
                int x = rd.Next(1, sizeX + 1);
                int y = rd.Next(1, sizeY + 1);
                if (table[y, x].Tag.ToString() != "#")
                {
                    table[y, x].Tag = "#";
                    m--;
                }
            } while (m > 0);            
            SetNumbers();            
        }

        private void SetNumbers()
        {
            for (int y = 1; y < sizeY + 1; y++)
            {
                for (int x = 1; x < sizeX + 1; x++)
                {
                    if (table[y, x].Tag.ToString() != "#")
                        table[y, x].Tag = NR(y,x);
                    switch(table[y, x].Tag.ToString())
                    {
                        case "1":
                            table[y, x].Foreground = Brushes.Magenta;
                            break;
                        case "2":
                            table[y, x].Foreground = Brushes.DarkGreen;
                            break;
                        case "3":
                            table[y, x].Foreground = Brushes.Blue;
                            break;
                        case "4":
                            table[y, x].Foreground = Brushes.Red;
                            break;
                        case "5":
                            table[y, x].Foreground = Brushes.DarkOrange;
                            break;
                        case "6":
                            table[y, x].Foreground = Brushes.Pink;
                            break;
                        case "7":
                            table[y, x].Foreground = Brushes.Tomato;
                            break;
                        case "8":
                            table[y, x].Foreground = Brushes.Thistle;
                            break;
                        default:
                            table[y, x].Foreground = Brushes.Red;
                            break;
                    }
                }
            }
        }

        private int NR(int y, int x)
        {
            int nr = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (table[y+i, x+j].Tag.ToString() == "#")
                        nr++;
                }
            }
            return nr;
        }        

        private void bt_Start_Click(object sender, RoutedEventArgs e)
        {
            sizeX = Convert.ToInt32(sliderX.Value);
            sizeY = Convert.ToInt32(sliderY.Value);
            mines = Convert.ToInt32(sliderM.Value);
            gr.Children.Clear();
            CreateTable();
        }
    }
}
