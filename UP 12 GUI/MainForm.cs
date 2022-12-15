using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_12_GUI
{
    public partial class MainForm : Form
    {
        private int a;
        private int b;
        Rectangle rectangle;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateSquareButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = null;
            if (!int.TryParse(ASideBox.Text, out a) || a <= 0)
            {
                MessageBox.Show("Введите целое положительное число!", "Ошибка");
                return;
            }
            if (!int.TryParse(BSideBox.Text, out b) || b <= 0)
            {
                MessageBox.Show("Введите целое положительное число!", "Ошибка");
                return;
            }

            if (rectangle == null)
            {
                foreach (var button in this.Controls.OfType<Button>())
                    button.Enabled = true;

                foreach (var tb in this.Controls.OfType<TextBox>())
                    tb.Enabled = true;

                foreach (var gb in this.Controls.OfType<GroupBox>())
                {
                    foreach (var button in gb.Controls.OfType<Button>()) button.Enabled = true;
                    foreach (var tb in gb.Controls.OfType<TextBox>()) tb.Enabled = true;
                }
            }

            rectangle = new Rectangle(a, b);
            rectangle.PrintSides(ChangesBox);
        }

        private void IncrementSidesButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = null;
            rectangle++;
            rectangle.PrintSides(ChangesBox);
        }

        private void DecrementSidesButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = null;
            rectangle--;
            rectangle.PrintSides(ChangesBox);
        }

        private void KnowByIndexButton_Click(object sender, EventArgs e)
        {
            int index;
            if (!int.TryParse(IndexBox.Text, out index))
            {
                MessageBox.Show("Введите целое число в поле ввода индекса!", "Ошибка");
                return;
            }
            try
            {   
                ChangesBox.Text = (index == 0) ? $"Сторона а -> {rectangle[index]}" :
                    $"Сторона b -> {rectangle[index]}";
            }
            catch (Exception ex)
            {
                ChangesBox.Text = ex.Message;
            }
        }

        private void ChangeByIndexButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = null;
            int index;
            if (!int.TryParse(IndexBox.Text, out index))
            {
                MessageBox.Show("Введите целое число в поле ввода индекса!", "Ошибка");
                return;
            }
            int side;
            if (!int.TryParse(SideChangeBox.Text, out side) || side <= 0)
            {
                MessageBox.Show("Введите целое положительное число в поле ввода изменения стороны!", "Ошибка");
                return;
            }
            try
            {
                rectangle[index] = side;
                rectangle.PrintSides(ChangesBox);
            }
            catch (Exception ex)
            {
                ChangesBox.Text = ex.Message;
            }
        }

        private void IsSquareButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = (rectangle.IsSquare) ? "Прямоугольник является квадратом" :
                "Прямоугольник не является квадратом";
        }

        private void MultiplyToScalarButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = null;
            int scalar;
            if (!int.TryParse(ScalarBox.Text, out scalar) || scalar <= 0)
            {
                MessageBox.Show("Введите целое положительное число в поле ввода скаляра!", "Ошибка");
                return;
            }
            rectangle *= scalar;
            rectangle.PrintSides(ChangesBox);
        }

        private void ToStringButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = (String)rectangle;
        }

        private void StringToRecButton_Click(object sender, EventArgs e)
        {
            ChangesBox.Text = null;
            string s = StringBox.Text;
            try
            {
                rectangle = (Rectangle)s;
                rectangle.PrintSides(ChangesBox);
            }
            catch (Exception ex)
            {
                ChangesBox.Text = ex.Message;
            }
        }
    }
    class Rectangle
    {
        private int a;
        private int b;

        public int A
        {
            get => a;
            set => a = value;
        }
        public int B
        {
            get => b;
            set => b = value;
        }
        public bool IsSquare => a == b;
        public int this[int index]
        {
            get => (index == 0) ? a :
                (index == 1) ? b : throw new Exception("Индекс в пределах допустимого дипазона [0, 1]");
            set
            {
                switch (index)
                {
                    case 0: a = value; break;
                    case 1: b = value; break;
                    default: throw new Exception("Индекс в пределах допустимого дипазона [0, 1]");
                }
            }
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void PrintSides(RichTextBox rtb)
        {
            rtb.Text += $"Сторона а -> {a}\n";
            rtb.Text += $"Сторона b -> {b}\n";
        }

        public int Perimeter() => a * 2 + b * 2;
        public int Square() => a * b;
        public static Rectangle operator ++(Rectangle rec)
        {
            rec.a++;
            rec.b++;
            return rec;
        }
        public static Rectangle operator --(Rectangle rec)
        {
            rec.a--;
            rec.b--;
            return rec;
        }
        public static Rectangle operator *(Rectangle rec, int scalar)
        {
            rec.a *= scalar;
            rec.b *= scalar;
            return rec;
        }
        public static explicit operator String(Rectangle rec) => $"Прямоугольник: a -> {rec.a}, b -> {rec.b}";
        
        public static explicit operator Rectangle(string s)
        {
            int a, b;
            Regex regex = new Regex(@"[0-9]+");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 2) throw new Exception("Строка содержит больше двух определений сторон прямоугольника!");
            else if (matches.Count < 2) throw new Exception("Строка содержит меньше двух определений сторон прямоугольника!");
            a = int.Parse(matches[0].Value);
            b = int.Parse(matches[1].Value);
            return new Rectangle(a, b);
        }
        public static bool operator true(Rectangle rec) => rec.a == rec.b;
        
        public static bool operator false(Rectangle rec) =>  rec.a != rec.b;
        

    }
}
