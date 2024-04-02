namespace oop_15
{
    public partial class OOP : Form
    {
        public OOP()
        {
            InitializeComponent();
        }
        private void btn_1_Click(object sender, EventArgs e)//кнопка завдання 1
        {
            try
            {
                double x = double.Parse(txtBox1.Text);//перетворення з string у double
                double counter;//лічильник
                double exp = 2.7f;//експонента
                counter = Math.Pow(exp, x) - x - 2 + Math.Pow((1 + x), x);//обчислення виразу
                lbl_2.Text = "Резульат: " + counter.ToString();//запис результату в лейбл
            }
            catch (FormatException)//якщо введено не числовий формат
            {
                lbl_2.Text = "Введено не числовий формат даних!";
            }
        }
        private void btn_2_Click(object sender, EventArgs e)// дія для кнопки завдання 2
        {
            int digit = 1;//змінна яка зберігає добуток 
            int temp;//тимчасова змінна 
            if (txtBox2.Text.Length != 4)
            {
                lbl_4.Text = "Введено не чотиризначне число.";
                return;
            }
            try
            {
                int num = int.Parse(txtBox2.Text);//перетворення з string в int 

                for (int i = 0; i < txtBox2.Text.Length; i++)
                {
                    temp = num % 10;        //
                    digit = digit * temp;   //обчислення добутку чисел чотиризначного числа
                    num /= 10;              //
                }
                lbl_4.Text = "Добуток чотиризначного числа: " + digit.ToString();
            }
            catch (FormatException)
            {
                lbl_4.Text = "Введено не числовий формат даних.";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)//дія для кнопки завдання 3
        {
            if (txtBox3.Text.Length != 4)//перевірка на читиризначне число
            {
                lbl_6.Text = "Введено не чотиризначне число.";
                return;
            }
            try
            {
                int num = int.Parse(txtBox3.Text);//перетворення
                char[] txt = txtBox3.Text.ToCharArray();//масив для зберігання даних з txtBox3
                Array.Reverse(txt);//метод для оберту масиву
                int txt_num = int.Parse(txt);//перетворення
                if (int.Equals(num, txt_num))//перевірка на збіжність
                {
                    lbl_6.Text = "Результат: True";
                }
                else
                {
                    lbl_6.Text = "Результат: False";
                }
            }
            catch (FormatException)
            {
                lbl_6.Text = "Введено не числовий формат даних.";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)//дія для кнопки завдання 4
        {
            try
            {
                int A = int.Parse(txtBox4.Text);
                int B = int.Parse(txtBox5.Text);
                int C = int.Parse(txtBox6.Text);
                int D = int.Parse(txtBox7.Text);
                if (A == D)
                {
                    lbl_11.Text = "Результат: число А дорівнює числу D";
                }
                else if (B == D)
                {
                    lbl_11.Text = "Результат: число B дорівнює числу D";
                }
                else if (C == D)
                {
                    lbl_11.Text = "Результат: число C дорівнює числу D";
                }
                else
                {
                    int max_1 = Math.Max(D - A, D - B);
                    int result = Math.Max(max_1, D - C);
                    lbl_11.Text = "Результат: максимальне = " + result;
                }
            }
            catch (FormatException)
            {
                lbl_11.Text = "Введено не числовий формат даних.";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)//дія для кнопки 4
        {
            try
            {
                int temp;
                int k = 0;
                int MAX = 0;
                int num = int.Parse(txtBox8.Text);
                for (int i = 0; i < txtBox8.Text.Length; i++)
                {
                    temp = num % 10;
                    if (temp > MAX)
                    {
                        MAX = temp;
                        k = 1;
                    }
                    else if (temp == MAX)
                    {
                        k++;
                    }
                    num /= 10;
                }
                lbl_13.Text = "Результат: кількість цифр з найбільшим значенням " + k + "/" + MAX;
            }
            catch (FormatException)
            {
                lbl_13.Text = "Введено не числовий формат даних.";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)//дія для кнопки 6
        {
            try
            {
                char[] str = txtBox9.Text.ToCharArray();//масив для зберігання даних з txtBox9
                Array.Sort(str);//сортування масиву
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '1' && str[i] != '0')//перевірка щоб в записі були лише 0 і 1
                    {
                        lbl_15.Text = "Вводити можна тільки 0 і 1";
                        return;
                    }
                }
                lbl_15.Text = "Відсортована послідовність: " + new string(str);
            }
            catch (FormatException)
            {
                lbl_15.Text = "Введено не числовий формат даних.";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)//дія для кнопки 7
        {
            try
            {
                bool counter_1 = false;//перемикач сторони
                int l = 0, r = 0;//лічильник лівої частини і правої
                string str = txtBox10.Text;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ';')
                    {
                        counter_1 = true;
                        continue;
                    }
                    if (!counter_1)
                    {
                        l++;
                    }
                    else if (counter_1)
                    {
                        r++;
                    }
                }
                lbl_17.Text = ($"Результат: символів до крапки з комою({l}), після ({r})");
            }
            catch (FormatException)
            {
                lbl_17.Text = "Поле потрібно заповнити!";
            }
            
        }
    }
}