using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Pollard_s_algorithm
{
    public partial class Form1 : Form
    {
        public string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя";
        Stopwatch time = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        public List<BigInteger> euclid(BigInteger a, BigInteger b)
        {
            List<BigInteger> bxy = new List<BigInteger> { };
            BigInteger c = 1;
            List<BigInteger> div_list = new List<BigInteger> { };
            List<BigInteger> x_list = new List<BigInteger> { 0 };
            List<BigInteger> y_list = new List<BigInteger> { 1 };
            if (a % b != 0)
            {
                while (true)
                {
                    div_list.Add(a / b);
                    c = a % b;
                    a = b;
                    b = c;
                    if (a % b == 0)
                    {
                        div_list.Add(a / b);
                        break;
                    }

                }
                bxy.Add(b);
                for (int i = 1; i < div_list.Count; i++)
                {
                    x_list.Add(y_list[i - 1]);
                    y_list.Add(x_list[i - 1] - y_list[i - 1] * div_list[div_list.Count - i - 1]);
                }
            }
            else
            {
                bxy.Add(b);
            }
            bxy.Add(x_list[x_list.Count - 1]);
            bxy.Add(y_list[y_list.Count - 1]);
            return bxy;
        }
        public BigInteger exp(BigInteger a, BigInteger e, BigInteger n)
        {
            BigInteger cloneE = e;
            BigInteger divisor = 2;
            List<BigInteger> c_exp = new List<BigInteger> { a };
            List<BigInteger> degreeToBinary = new List<BigInteger> { };
            while (true)
            {
                BigInteger trash;
                BigInteger.DivRem(cloneE, divisor, out trash);
                degreeToBinary.Add(trash);
                if (cloneE == 1)
                    break;
                cloneE /= 2;
            }
            degreeToBinary.Reverse();
            for (int i = 1; i < degreeToBinary.Count; i++)
            {
                c_exp.Add((c_exp[i - 1] * c_exp[i - 1] * BigInteger.Pow(a, int.Parse(degreeToBinary[i].ToString()))) % n);
            }
            BigInteger result = c_exp[c_exp.Count - 1];
            return result;
        }
        public bool millerRabin(BigInteger r_mr)
        {

            if (r_mr == 2 || r_mr == 3)
                return true;
            if (r_mr < 2 || r_mr % 2 == 0)
                return false;
            BigInteger k_mr = (BigInteger)BigInteger.Log(r_mr, 2.0);
            BigInteger t = r_mr - 1;
            BigInteger s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }
            for (BigInteger i = 0; i < k_mr; i++)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] forA = new byte[r_mr.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    rng.GetBytes(forA);
                    a = new BigInteger(forA);
                }
                while (a < 2 || a > r_mr - 2);

                if (r_mr % a == 0)
                    return false;

                BigInteger b = exp(a, t, r_mr);
                if (b == 1)
                    continue;
                for (BigInteger j = 1; j < s; j++)
                {
                    b = exp(b, 2, r_mr);
                    if (b == r_mr - 1)
                        break;
                }
                if (b != r_mr - 1)
                    return false;

            }
            return true;
        }
        private BigInteger pollard(BigInteger n)
        {
            
            BigInteger i = 1, xi = 2, y = 1,gcd = 1, next_y = 1, diff; 
            int k = 0;
            while (gcd <= 1)
            {
                if (i == 1)
                {                  
                    diff = BigInteger.Abs(xi - y);
                    gcd = BigInteger.GreatestCommonDivisor(n, diff);
                    i++;
                    next_y = xi;
                    k++;
                }
                else
                {
                    xi = (BigInteger.Pow(xi, 2) - 1) % n;
                    y = next_y;
                    diff = BigInteger.Abs(xi - y);
                    try
                    {
                        gcd = BigInteger.GreatestCommonDivisor(n, diff);
                    }
                    catch
                    {
                        MessageBox.Show("Попытка деления на 0, неверные значения для расшифровки!");
                        return 1;
                    }
                    if (i == BigInteger.Pow(2, k))
                    {
                        next_y = xi;
                        k++;
                    }
                    i++;
                }
            }
            iterations_label.Text ="Iterations: " + (i - 1).ToString();
            return gcd;
        }

        private void hack_button_Click(object sender, EventArgs e)
        {
            result_textBox.Text = string.Empty;
            BigInteger N,E,crypto;
            try
            {
                E = BigInteger.Parse(e_textBox.Text);
                N = BigInteger.Parse(n_textBox.Text);
                crypto = BigInteger.Parse(crypto_textBox.Text);
                if (E <= 0 || N <= 999)
                {
                    MessageBox.Show("E > 0, N>999");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные e,N и Crypto");
                return;
            }
            string result = string.Empty;
            time.Reset();
            time.Start();
            BigInteger p = pollard(N);
            BigInteger q = N / p;
            BigInteger Fn = (p - 1) * (q - 1);
            BigInteger d = euclid(Fn, E)[2];
            d = (d < 0) ? d + Fn : d;
            BigInteger y = exp(crypto, d, N);
            result = y.ToString() + ' ';
            time.Stop();

            time_label.Text = time.Elapsed.ToString();
            p_textBox.Text = p.ToString();
            q_textBox.Text = q.ToString();
            d_textBox.Text = d.ToString();

            if (y.ToString().Length % 2 == 0)
            {
                int iter = y.ToString().Length;
                for (int i = (iter / 2) - 1; i >= 0; i--)
                {
                    BigInteger index = (BigInteger.Divide(y, BigInteger.Pow(100, i)) - 16) % alphabet.Length;
                    if (index < 0) index += alphabet.Length;
                    result += alphabet[Int32.Parse(index.ToString())];
                    BigInteger new_y;
                    BigInteger.DivRem(y, BigInteger.Pow(100, i), out new_y);
                    y = new_y;
                }
            }
            result_textBox.Text = result;


        }
    }
}
