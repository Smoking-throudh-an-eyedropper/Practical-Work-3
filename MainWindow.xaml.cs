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

namespace Practical_Work__3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players;
        List<Questions> quuestions;
        string a;
        int v;

        public MainWindow()
        {
            InitializeComponent();
            players = new List<Player>()
            {

            };
            Update();
            quuestions = new List<Questions>()
            {
                new Questions("Что такое этикет?","правила поведения", 100),
                new Questions("Как переводится с французского языка слово «этикет»?","ярлык", 200),
                new Questions("Что значит слово «вежливость»?","быть вежливым", 300),
                new Questions("Кто должен пройти первым: входящий в магазин или выходящий в это же время из него?","входящий должен пропустить выходящего", 400),
                new Questions("Какие существуют виды этикета?","Деловой, дипломатический, военный, педагогический, врачебный, поведениев общественных местах", 500),

                new Questions("Что образуют Солнце и планеты вокруг него?","Солнечную систем", 100),
                new Questions("Какой по счёту планетой по мере удаления от солнца является Земля?","третьей ", 200),
                new Questions("Какая планета Солнечной системы самая маленькая", "Меркурий", 300),
                new Questions("Какой космонавт первым высадился на Луну?","Армстронг", 400),
                new Questions("У какой планеты Солнечной системы нет кольца","Марс", 500),

                new Questions("Этот римский папа призвал рыцарей к 4 крестовому походу?","Иннокентий III", 100),
                new Questions("Тевтонские рыцари прибыли в Польшу в?","1231 году ", 200),
                new Questions("Что предлагает своей возлюбленной рыцарь", "руку и сердце", 300),
                new Questions("Какая причина подтолкнула рыцарей к походу в Святую землю?","захват новых земель", 400),
                new Questions("В этом году король Венгрии Андраш II пригласил рыцарей для помощи в борьбе с половцами","1211", 500),

                new Questions("Жидкая ткань?","Кровь", 100),
                new Questions("Неклеточные формы жизни?","Вирусы", 200),
                new Questions("Легочные пузырьки", "Альвеолы", 300),
                new Questions("Что такое микология?","Наука о грибах", 400),
                new Questions("Что такое лейкоциты?","Клетки крови", 500),

                new Questions("Жидкая ткань?","Кровь", 100),
                new Questions("Неклеточные формы жизни?","Вирусы", 200),
                new Questions("Легочные пузырьки", "Альвеолы", 300),
                new Questions("Что такое микология?","Наука о грибах", 400),
                new Questions("Что такое лейкоциты?","Клетки крови", 500),

                new Questions("Главная функция первой фазы творческого поиска заключается в?","проведении анализа ", 100),
                new Questions("Основные принципы творческого поиска заключаются в?","поиске аргументов", 200),
                new Questions("Сколько всего есть категорий творческой деятельности", "3", 300),
                new Questions("Для чего привлекаются работники частично занятые на производстве?","для поиска новых идей", 400),
                new Questions("Какие сферы объединят 2 категория творческой деятельности?","всех участников процесса", 500),

                new Questions("Самая маленькая единица измерения информации?","Бит ", 100),
                new Questions("Для чего служат диски?","для сохранения информации", 200),
                new Questions("Один из элементов окна приложения Paint", "кнопка закрыть", 300),
                new Questions("Что выполняет компьютер сразу после включения POWER?"," проверку устройств и тестирование памяти ", 400),
                new Questions("Какое из устройств компьютера не входит в состав системного блока?","принтер", 500),
            };
        }
        public void Update()
        {
            players = players.ToList();
            list2.ItemsSource = players;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[0].question;
            a = quuestions[0].answer;
            v = quuestions[0].Point;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            b2.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[1].question;
            a = quuestions[1].answer;
            v = quuestions[1].Point * 2;
            MessageBox.Show("X2");
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            b3.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[2].question;
            a = quuestions[2].answer;
            v = quuestions[2].Point;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            b4.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[3].question;
            a = quuestions[3].answer;
            v = quuestions[3].Point * 3;
            MessageBox.Show("X3");
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            b5.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[4].question;
            a = quuestions[4].answer;
            v = quuestions[4].Point;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (otv.Text == a)
                {
                    if (list2.SelectedItem == null)
                    {

                    }
                    int c = v;
                    var b = players.FindIndex(u => u == list2.SelectedItem);
                    players[b].Point = players[b].Point + c;
                    Update();
                }
                vpr.Text = "";
                otv.Text = "";
                Update();
            }
            catch (System.Exception)
            {
                otv.Text = "";
                vpr.Text = "";
                MessageBox.Show("Выберети пользователя");
            }
        }
         private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            b5.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[5].question;
            a = quuestions[5].answer;
            v = quuestions[5].Point;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            b6.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[6].question;
            a = quuestions[6].answer;
            v = quuestions[6].Point;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            b7.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[7].question;
            a = quuestions[7].answer;
            v = quuestions[7].Point;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            b8.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[8].question;
            a = quuestions[8].answer;
            v = quuestions[8].Point;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            b9.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[9].question;
            a = quuestions[9].answer;
            v = quuestions[9].Point - 100;
            MessageBox.Show("-100");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            b10.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[10].question;
            a = quuestions[10].answer;
            v = quuestions[10].Point;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            b11.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[11].question;
            a = quuestions[11].answer;
            v = quuestions[11].Point;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            b12.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[12].question;
            a = quuestions[12].answer;
            v = quuestions[12].Point * 10;
            MessageBox.Show("X10");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            b13.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[13].question;
            a = quuestions[13].answer;
            v = quuestions[13].Point;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            b14.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[14].question;
            a = quuestions[14].answer;
            v = quuestions[14].Point;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            b15.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[15].question;
            a = quuestions[15].answer;
            v = quuestions[15].Point - 1000;
            MessageBox.Show("noooooooo -1000");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            b16.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[16].question;
            a = quuestions[16].answer;
            v = quuestions[16].Point;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            b17.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[17].question;
            a = quuestions[17].answer;
            v = quuestions[17].Point;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            b18.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[18].question;
            a = quuestions[18].answer;
            v = quuestions[18].Point;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            b19.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[19].question;
            a = quuestions[19].answer;
            v = quuestions[19].Point;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            b20.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[20].question;
            a = quuestions[20].answer;
            v = quuestions[20].Point;
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            b21.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[21].question;
            a = quuestions[21].answer;
            v = quuestions[21].Point;
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            b22.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[22].question;
            a = quuestions[22].answer;
            v = quuestions[22].Point;
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            b23.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[23].question;
            a = quuestions[23].answer;
            v = quuestions[23].Point;
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            b24.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[24].question;
            a = quuestions[24].answer;
            v = quuestions[24].Point;
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            b25.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[25].question;
            a = quuestions[25].answer;
            v = quuestions[25].Point;
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            b26.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[26].question;
            a = quuestions[26].answer;
            v = quuestions[26].Point;
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            b27.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[27].question;
            a = quuestions[27].answer;
            v = quuestions[27].Point;
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            b28.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[28].question;
            a = quuestions[28].answer;
            v = quuestions[28].Point;
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            b29.Visibility = Visibility.Collapsed;
            vpr.Text = quuestions[29].question;
            a = quuestions[29].answer;
            v = quuestions[29].Point;
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            if (tx2.Text == null || tx2.Text == "")
            {
                MessageBox.Show("21312");
            }
            else
            {
                players.Add(new Player(tx2.Text, 0));
                Update();
            }
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            Player player1 = players[0];
            foreach (var a in players)
            {
                if (player1.Point < a.Point) player1 = a;
            }
            MessageBox.Show(player1.Name, "Победитель");
        }


    }
}
