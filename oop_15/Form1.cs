namespace oop_15
{
    public partial class OOP : Form
    {
        public OOP()
        {
            InitializeComponent();
        }
        private void btn_1_Click(object sender, EventArgs e)//������ �������� 1
        {
            try
            {
                double x = double.Parse(txtBox1.Text);//������������ � string � double
                double counter;//��������
                double exp = 2.7f;//����������
                counter = Math.Pow(exp, x) - x - 2 + Math.Pow((1 + x), x);//���������� ������
                lbl_2.Text = "��������: " + counter.ToString();//����� ���������� � �����
            }
            catch (FormatException)//���� ������� �� �������� ������
            {
                lbl_2.Text = "������� �� �������� ������ �����!";
            }
        }
        private void btn_2_Click(object sender, EventArgs e)// �� ��� ������ �������� 2
        {
            int digit = 1;//����� ��� ������ ������� 
            int temp;//��������� ����� 
            if (txtBox2.Text.Length != 4)
            {
                lbl_4.Text = "������� �� ������������ �����.";
                return;
            }
            try
            {
                int num = int.Parse(txtBox2.Text);//������������ � string � int 

                for (int i = 0; i < txtBox2.Text.Length; i++)
                {
                    temp = num % 10;        //
                    digit = digit * temp;   //���������� ������� ����� �������������� �����
                    num /= 10;              //
                }
                lbl_4.Text = "������� �������������� �����: " + digit.ToString();
            }
            catch (FormatException)
            {
                lbl_4.Text = "������� �� �������� ������ �����.";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)//�� ��� ������ �������� 3
        {
            if (txtBox3.Text.Length != 4)//�������� �� ������������ �����
            {
                lbl_6.Text = "������� �� ������������ �����.";
                return;
            }
            try
            {
                int num = int.Parse(txtBox3.Text);//������������
                char[] txt = txtBox3.Text.ToCharArray();//����� ��� ��������� ����� � txtBox3
                Array.Reverse(txt);//����� ��� ������ ������
                int txt_num = int.Parse(txt);//������������
                if (int.Equals(num, txt_num))//�������� �� �������
                {
                    lbl_6.Text = "���������: True";
                }
                else
                {
                    lbl_6.Text = "���������: False";
                }
            }
            catch (FormatException)
            {
                lbl_6.Text = "������� �� �������� ������ �����.";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)//�� ��� ������ �������� 4
        {
            try
            {
                int A = int.Parse(txtBox4.Text);
                int B = int.Parse(txtBox5.Text);
                int C = int.Parse(txtBox6.Text);
                int D = int.Parse(txtBox7.Text);
                if (A == D)
                {
                    lbl_11.Text = "���������: ����� � ������� ����� D";
                }
                else if (B == D)
                {
                    lbl_11.Text = "���������: ����� B ������� ����� D";
                }
                else if (C == D)
                {
                    lbl_11.Text = "���������: ����� C ������� ����� D";
                }
                else
                {
                    int max_1 = Math.Max(D - A, D - B);
                    int result = Math.Max(max_1, D - C);
                    lbl_11.Text = "���������: ����������� = " + result;
                }
            }
            catch (FormatException)
            {
                lbl_11.Text = "������� �� �������� ������ �����.";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)//�� ��� ������ 4
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
                lbl_13.Text = "���������: ������� ���� � ��������� ��������� " + k + "/" + MAX;
            }
            catch (FormatException)
            {
                lbl_13.Text = "������� �� �������� ������ �����.";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)//�� ��� ������ 6
        {
            try
            {
                char[] str = txtBox9.Text.ToCharArray();//����� ��� ��������� ����� � txtBox9
                Array.Sort(str);//���������� ������
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '1' && str[i] != '0')//�������� ��� � ����� ���� ���� 0 � 1
                    {
                        lbl_15.Text = "������� ����� ����� 0 � 1";
                        return;
                    }
                }
                lbl_15.Text = "³���������� �����������: " + new string(str);
            }
            catch (FormatException)
            {
                lbl_15.Text = "������� �� �������� ������ �����.";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)//�� ��� ������ 7
        {
            try
            {
                bool counter_1 = false;//��������� �������
                int l = 0, r = 0;//�������� ��� ������� � �����
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
                lbl_17.Text = ($"���������: ������� �� ������ � �����({l}), ���� ({r})");
            }
            catch (FormatException)
            {
                lbl_17.Text = "���� ������� ���������!";
            }
            
        }
    }
}