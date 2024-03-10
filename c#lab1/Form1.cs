using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void clearTextBox(TextBox textBox)
        {
            // text boxu temizle
            textBox.Clear();
        }

        private double[] get_Numbers(TextBox textBox1, TextBox textBox2)
        {
            double num_1;
            double num_2;

            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            textBox1.Clear();
            textBox2.Clear();

            if (!(double.TryParse(text1, out num_1) && double.TryParse(text2, out num_2)))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
                return null;
            }
            else
            {
                double[] numbers = new double[] { num_1, num_2 };
                return numbers;
            }
        }

        private string Addition(double num_1, double num_2)
        {
            try
            {
                //işlem yapılabilir ise yapılır sayılar double değişkeninden taşacak kadar büyükse hata fırlatılır.
                double result = num_1 + num_2;
                string output = "Toplam = " + result.ToString() + "\n";
                return output;
            }
            catch (OverflowException)
            {

                MessageBox.Show("Hesaplanamayacak kadar büyük sayılar girdiniz!");
                return null;
            }

        }

        private string Subtraction(double num_1, double num_2)
        {
            try
            {
                double result = num_1 - num_2;
                string output = "Fark = " + result.ToString() + "\n";
                return output;
            }
            catch (OverflowException)
            {

                MessageBox.Show("Hesaplanamayacak kadar büyük sayılar girdiniz!");
                return null;
            }
        }

        private string Multiplication(double num_1, double num_2)
        {
            try
            {
                double result = num_1 * num_2;
                string output = "Çarpım = " + result.ToString() + "\n";
                return output;
            }
            catch (OverflowException)
            {

                MessageBox.Show("Hesaplanamayacak kadar büyük sayılar girdiniz!");
                return null;
            }
        }

        private string Division(double num_1, double num_2)
        {
            if (num_2 == 0)
            {
                string output = "Bir sayı sıfıra bölünemez!\n";
                return output;

            }
            else
            {
                try
                {
                    double result = num_1 / num_2;
                    string output = "Bölüm = " + result.ToString() + "\n";
                    return output;
                }
                catch (OverflowException)
                {

                    MessageBox.Show("Hesaplanamayacak kadar büyük sayılar girdiniz!");
                    return null;
                }
            }
        }

        // Panel1 
        private void panel1_calculate_Click(object sender, EventArgs e)
        {

            double[] numbers = get_Numbers(panel1_input1, panel1_input2 );

            if (numbers == null)
            {
                return;
            }
            else
            {

                double num_1 = numbers[0];
                double num_2 = numbers[1];

                string output = "";

                // Toplama
                if (panel1_additionCheck.Checked)
                {
                    output += Addition(num_1, num_2);
                    
                }

                //Çıkarma
                if (panel1_subtractionCheck.Checked)
                {
                    output += Subtraction(num_1, num_2);
                }

                //Çarpma
                if (panel1_multiplicationCheck.Checked)
                {
                    output += Multiplication(num_1, num_2);
                }

                //Bölme
                if (panel1_divisionCheck.Checked)
                {
                    output += Division(num_1, num_2);
                }

                if (output == "")
                {
                    output = "Lütfen bir işlem seçiniz!";
                }

                MessageBox.Show(output);             

            }



        }

        // tümü checkbox'u hepsini seçer
        private void panel1_selectAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (panel1_selectAll.Checked)
            {
                panel1_additionCheck.Checked = true;
                panel1_subtractionCheck.Checked = true;
                panel1_multiplicationCheck.Checked = true;
                panel1_divisionCheck.Checked = true;
            }
            else
            {
                panel1_additionCheck.Checked = false;
                panel1_subtractionCheck.Checked = false;
                panel1_multiplicationCheck.Checked = false;
                panel1_divisionCheck.Checked = false;
            }
        }

        // Panel2

        // operatör olarak seçilebilecek karakterleri belirtiyoruz ve aşşağıda IsMatch ile inputun bunlar ile eşleşip eşleşmediğine bakıyoruz
        string pattern = @"^[-/*+]{1}$";
        private void panel2_Add_Click(object sender, EventArgs e)
        {

            if (!(Regex.IsMatch(panel2_input.Text, pattern)))
            {
                MessageBox.Show("Lütfen geçerli bir operatör giriniz!");
            }
            else
            {
                string mathOperator = panel2_input.Text;

                if (!panel2_listBox.Items.Contains(mathOperator)) // operatör zaten var mı
                {
                    panel2_listBox.Items.Add(mathOperator);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz operatör zaten mevcut!");
                }
                
                
            }

            clearTextBox(panel2_input);
        }

        // bir operatörü listbox'dan silme
        private void panel2_Remove_Click(object sender, EventArgs e)
        {

            if (!(Regex.IsMatch(panel2_input.Text, pattern)))
            {
                MessageBox.Show("Lütfen geçerli bir operatör giriniz!");
            }
            else
            {
                string mathOperator = panel2_input.Text;

                if (panel2_listBox.Items.Contains(mathOperator)) // girilen operatör listbox'da var mı ?
                {
                    panel2_listBox.Items.Remove(mathOperator); // varsa kaldır
                }
                else
                {
                    MessageBox.Show("Girdiğiniz operatör mevcut değil!");
                }

            }
            clearTextBox(panel2_input);

        }

        // listboxu temizle
        private void panel2_ClearButton_Click(object sender, EventArgs e)
        {
            panel2_listBox.Items.Clear();
        }

        private void panel2_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Calculate_Click(object sender, EventArgs e)
        {
            double[] numbers = get_Numbers(panel1_input1, panel1_input2);

            if (numbers == null)
            {
                return;
            }
            else
            {
                double num_1 = numbers[0];
                double num_2 = numbers[1];
                string output = "";
                foreach (var selectedItem in panel2_listBox.SelectedItems)
                {
                    switch (selectedItem)
                    {

                        case "+":
                            output += Addition(num_1, num_2);
                            break;

                        case "-":
                            output += Subtraction(num_2, num_1);
                            break;

                        case "*":
                            output += Multiplication(num_2, num_1);
                            break;
                        case "/":
                            output += Division(num_2, num_1);
                            break;
                    }


                }

                if (output == "")
                {
                    output = "Lütfen bir işlem seçiniz!";
                }

                MessageBox.Show(output);
            }
            
        }

        // Panel3
 
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // combobox'a operatör ekleme
        private void panel3_Add_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(panel3_comboBox.Text, pattern)))
            {
                MessageBox.Show("Lütfen geçerli bir operatör giriniz!");
            }
            else
            {
                string mathOperator = panel3_comboBox.Text;

                if (!panel3_comboBox.Items.Contains(mathOperator)) // operatör zaten var mı
                {
                    panel3_comboBox.Items.Add(mathOperator);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz operatör zaten mevcut!");
                }
            }

            panel3_comboBox.Text = "";


        }
        //combobox operatör kaldırma
        private void panel3_Remove_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(panel3_comboBox.Text, pattern)))
            {
                MessageBox.Show("Lütfen geçerli bir operatör giriniz!");
            }
            else
            {
                string mathOperator = panel3_comboBox.Text;

                if (panel3_comboBox.Items.Contains(mathOperator)) // operatör zaten var mı
                {
                    panel3_comboBox.Items.Remove(mathOperator);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz operatör mevcut değil!");
                }
            }

            panel3_comboBox.Text = "";

        }

        private void panel3_Clear_Click(object sender, EventArgs e)
        {
            panel3_comboBox.Items.Clear();
        }

        private void panel3_Calculate_Click(object sender, EventArgs e)
        {
            double[] numbers = get_Numbers(panel1_input1, panel1_input2);

            if (numbers == null)
            {
                return;
            }
            else
            {
                double num_1 = numbers[0];
                double num_2 = numbers[1];
                string output = "";
                string mathOperator;

                if (panel3_comboBox.SelectedItem != null)
                {
                    mathOperator = panel3_comboBox.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("lütfen bir işlem seçin!");
                    return;
                }
                
                switch (mathOperator)
                {
                    case "+":
                        output += Addition(num_1, num_2);
                        break;

                    case "-":
                        output += Subtraction(num_2, num_1);
                        break;

                    case "*":
                        output += Multiplication(num_2, num_1);
                        break;
                    case "/":
                        output += Division(num_2, num_1);
                        break;
                }

                panel3_result.Text = output;

            }

        }
        // Panel4

        bool increase = true;  // artma/azalma
        bool paused = true;    // durdur/başlat

        //radio buton ile artma azalma durumu belirleme
        private void panel4_increase_CheckedChanged(object sender, EventArgs e)
        {
            increase = true;
        }

        private void panel4_decrease_CheckedChanged(object sender, EventArgs e)
        {
            increase = false;
        }

        // progressbar durdur başlat
        private void panel4_start_Click(object sender, EventArgs e)
        {
            if (paused)  // proggres bar duruyor ise başlatmak için
            {

                panel4_start.Text = "Durdur";
                paused = false;
                
                timer1.Start();

                

            }
            else
            {
                panel4_start.Text = "Başlat";
                paused = true;
                timer1.Stop();

            }
        }
        
        // timer_tick timer'ın her interval süresi geçtiğinde tetiklediği fonksiyondur
        // burada her 1000 ms de bir progressbar %10 arttırılır veya azaltılır buna increase değeri ile karar verilir
        // 

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(increase && panel4_progressBar.Value + 10 <= panel4_progressBar.Maximum)
            {
                panel4_progressBar.Value += 10;
            }
            else if (!increase && panel4_progressBar.Value - 10 >= panel4_progressBar.Minimum)
            {
                panel4_progressBar.Value -= 10;
            }

            if(panel4_progressBar.Value == 0 || panel4_progressBar.Value == 100) 
            {
                panel4_start.Text = "Başlat";
                paused = true;
                timer1.Stop();
            }

        }
    }
}
