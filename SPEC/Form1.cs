using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SPEC
{
    public partial class Form1 : Form
    {
        int arraysize;
        double[] Ampl;
        double[] Freq;
        double[] Phase;
        double[] signal;
        double ff1, ff2;
        double noise;
        int mod_m;
        Random rand = new Random();
        double[] U;
        double[] V;
        double[] Sigm;
        double[] AUTO;
        double[,] V_matr;
        double[,] V_matr_trans;
        double[,] U_matr;
        double[,] Sigm_matr;
        double[,] Multy1 ;
        double[,] Obr_Matr;
        int s = 0;
        double epss;
        double[] minmax;
        double[] spec;
        double [] signal1;
        bool animation;
        bool stop_animation;
        int q;
        double shag_shum;
        double max1, max2;
        double f1, f2;
        double[] raz_spo;
        double mmm;
        double R;
        double py;
        int Q;
        double sred;

        double min;

        double proverka;
        public Form1()
        {
            InitializeComponent();
            Ampl = new double[2];
            Freq = new double[2];
            Phase = new double[2];
            animation = true;
            stop_animation = false;

        }

        private void InitiateModel()
        {
            Ampl[0] = Convert.ToDouble(A1.Text);
            Ampl[1] = Convert.ToDouble(A2.Text);
            Freq[0] = Convert.ToDouble(F1.Text);
            Freq[1] = Convert.ToDouble(F2.Text);
            arraysize = Convert.ToInt32(ARR.Text);
            noise = Convert.ToDouble(NOISE.Text);
            mod_m = Convert.ToInt32(CMESH.Text);
            shag_shum = Convert.ToDouble(SHAG_SHUM.Text);
            U = new double[mod_m * mod_m];
            V = new double[mod_m * mod_m];
            Sigm = new double[mod_m * mod_m];
            AUTO = new double[mod_m * mod_m];
            V_matr = new double[mod_m, mod_m];
            signal = new double[arraysize];
            V_matr_trans = new double[mod_m, mod_m];
            U_matr = new double[mod_m, mod_m];
            Sigm_matr = new double[mod_m, mod_m];
            Multy1 = new double[mod_m, mod_m];
            Obr_Matr = new double[mod_m, mod_m];
            spec = new double[arraysize];
            signal1 = new double[arraysize];
            proverka = 5;
            sred = Convert.ToDouble(SRED.Text);

            signal1 = new double[arraysize];
            
           proverka = 0;

        }

        private double PoligarmFunc( double step, double[] Amp, double[] Frequency, double[] Phas) 
        {
            double result = 0;
            for (int i = 0; i < 2; i++)
            {
                result += Amp[i] * Math.Sin(2 * Math.PI * Frequency[i] * step + Phas[i]);
            }
            return result;
        }

        private double[] AKM(int mod_m, double num, double[]func )
        {
            
            double[] r_xx = new double[mod_m*mod_m];
            for (int m=0; m<mod_m; m++)
            {
                double y = 0;
                for (int n=0; n<num-m; n++)
                {
                    y += func[n] * func[n+m];
                }
                r_xx[m] = y / (num - m);
            }

            for (int i = 0; i < mod_m; i++)
            {
                for (int j = 0; j < mod_m; j++)
                {
                    r_xx[i * mod_m + j] = r_xx[Math.Abs(j- i)];
                }
            }
            return r_xx;
        }
        private int svd_hestenes(int m_m, int n_n, double[] a, double[] u, double[] v, double[] sigma)
        {
            double thr = 1e-4f, nul = 1e-16f;
            int n, m, i, j, l, k, iter, inn, ll, kk;
            bool lort;
            double alfa, betta, hamma, eta, t, cos0, sin0, buf, s;
            n = n_n;
            m = m_m;
            for (i = 0; i < n; i++)
            {

                inn = i * n;
                for (j = 0; j < n; j++)
                    if (i == j) v[inn + j] = 1.0;
                    else v[inn + j] = 0.0;
            }
            for (i = 0; i < m; i++)
            {
                inn = i * n;
                for (j = 0; j < n; j++)
                {
                    u[inn + j] = a[inn + j];
                }
            }

            iter = 0;
            while (true)
            {
                lort = false;
                iter++;
                for (l = 0; l < n - 1; l++)
                    for (k = l + 1; k < n; k++)
                    {
                        alfa = 0.0; betta = 0.0; hamma = 0.0;
                        for (i = 0; i < m; i++)
                        {
                            inn = i * n;
                            ll = inn + l;
                            kk = inn + k;
                            alfa += u[ll] * u[ll];
                            betta += u[kk] * u[kk];
                            hamma += u[ll] * u[kk];
                        }

                        if (Math.Sqrt(alfa * betta) < nul) continue;
                        if (Math.Abs(hamma) / Math.Sqrt(alfa * betta) < thr) continue;

                        lort = true;
                        eta = (betta - alfa) / (2f * hamma);
                        t = (double)((eta / Math.Abs(eta)) / (Math.Abs(eta) + Math.Sqrt(1.0 + eta * eta)));
                        cos0 = (double)(1.0 / Math.Sqrt(1.0 + t * t));
                        sin0 = t * cos0;

                        for (i = 0; i < m; i++)
                        {
                            inn = i * n;
                            buf = u[inn + l] * cos0 - u[inn + k] * sin0;
                            u[inn + k] = u[inn + l] * sin0 + u[inn + k] * cos0;
                            u[inn + l] = buf;

                            if (i >= n) continue;
                            buf = v[inn + l] * cos0 - v[inn + k] * sin0;
                            v[inn + k] = v[inn + l] * sin0 + v[inn + k] * cos0;
                            v[inn + l] = buf;
                        }
                    }

                if (!lort) break;
            }

            for (i = 0; i < n; i++)
            {
                s = 0.0;
                for (j = 0; j < m; j++) s += u[j * n + i] * u[j * n + i];
                s = (double)Math.Sqrt(s);
                sigma[i] = s;
                if (s < nul) continue;
                for (j = 0; j < m; j++) u[j * n + i] /= s;
            }
            //======= Sortirovka ==============
            for (i = 0; i < n - 1; i++)
                for (j = i; j < n; j++)
                    if (sigma[i] < sigma[j])
                    {
                        s = sigma[i]; sigma[i] = sigma[j]; sigma[j] = s;
                        for (k = 0; k < m; k++)
                        { s = u[i + k * n]; u[i + k * n] = u[j + k * n]; u[j + k * n] = s; }
                        for (k = 0; k < n; k++)
                        { s = v[i + k * n]; v[i + k * n] = v[j + k * n]; v[j + k * n] = s; }
                    }
                    
            return iter;
        }
       

        
        private double [,] Multiplication(double[,] a, double[,] b,int mod_m )
        {
            double[,] r = new double[mod_m, mod_m];
            for (int i = 0; i < mod_m; i++)
            {
                for (int j = 0; j < mod_m; j++)
                {
                    for (int k = 0; k < mod_m; k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }

        private double [] Matrix( double [] sig)
        {

            AUTO = AKM(mod_m, arraysize, sig);

            svd_hestenes(mod_m, mod_m, AUTO, U, V, Sigm);

            for (int i = 0; i < mod_m; i++)
            {
                for (int j = 0; j < mod_m; j++)
                {
                    V_matr[i, j] = V[i * mod_m + j];

                }
            }

            for (int i = 0; i < mod_m; i++)
            {
                for (int j = 0; j < mod_m; j++)
                {
                    V_matr_trans[i, j] = V_matr[j, i];
                }
            }

            for (int i = 0; i < mod_m; i++)
            {
                for (int j = 0; j < mod_m; j++)
                {
                    U_matr[i, j] = U[i * mod_m + j];

                }

            }

            for (int i = 0; i < mod_m; i++)
            {
                for (int j = 0; j < mod_m; j++)
                {
                    if (i == j)
                    {
                        if (Sigm[i] > 0.00000002* Sigm[0])
                        {
                            Sigm_matr[i, j] = 1 / Sigm[i];
                        }
                        else Sigm_matr[i, j] = 0;
                    }

                    else Sigm_matr[i, j] = 0;
                }
            }

            Multy1 = Multiplication(U_matr, Sigm_matr, mod_m);

            Obr_Matr = Multiplication(Multy1, V_matr_trans, mod_m);

            double rrr;
            double pod_sum;
            rrr = 0;
            int l = 0;
            
            chart1.Series[0].Points.Clear();
            using (var sw = new StreamWriter("multy1.txt"))
            {
                for (double nada3 = 1.0 / arraysize; nada3 < 0.5; nada3 += 1.0 / arraysize)
                {
                    pod_sum = 0;
                    for (int k = 0; k < mod_m; k++)
                    {

                        for (int a = 0; a < mod_m; a++)
                        {
                            pod_sum += Obr_Matr[k, a] * (Math.Cos(2 * Math.PI * Math.Abs((a-k)) * nada3));

                        }
                    }
                    rrr = 1.0 / pod_sum;
                    l++;
                    spec[l] = rrr;
                    
                    sw.Write(spec[l] + " ");
                    chart1.Series[0].Points.AddXY(nada3, spec[l]);
                }
                sw.Flush();
                sw.Close();
            }
            return spec;
        }
        private void Graph_Click(object sender, EventArgs e)
        {
            InitiateModel();
            
            SIGNAL_CHART.Series[0].Points.Clear();

            for (int i = 0; i < arraysize; i++)
            {
                signal[i] = PoligarmFunc( i, Ampl, Freq, Phase);
            }

            double f;
            double en_signal = 0;
            double en_shum = 0;
            double[] n = new double[arraysize];
            for (int t = 0; t < arraysize; t++)
            {
                f = 0;
                for (int j = 0; j < 12; j++)
                {
                    f += Convert.ToDouble(rand.Next(-2000, 2000)) / 2000 / 12;
                }
                n[t] = f;
                en_signal += signal[t] * signal[t];
                en_shum += n[t] * n[t];
            }

            //подсчёт коэфициента альфа
            double alfa = Math.Sqrt((noise+2) * en_signal / en_shum / 100);

            for (int t = 0; t < arraysize; t++)
            {
                signal[t] = signal[t] + (float)(alfa * n[t]);
            }

            for (int i = 1; i < arraysize; i++)
            {
                SIGNAL_CHART.Series[0].Points.AddXY(i, signal[i]);

            }
            animation = false;
            stop_animation = false;
            Matrix(signal);
        }
        private void auto_sinus(int ur_shum, double f1nadada, double f2nadada)
        {
            

            for (int i = 0; i < arraysize; i++)
            {
                signal1[i] = Math.Sin(2 * Math.PI * f1nadada * i + Phase[0]) + Math.Sin(2 * Math.PI * f2nadada * i + Phase[1]);    //чистый синус
                                                                                                    //signal[i] = sin(f1*i + fi1) + sin(f2*i + fi2);
            }
            //////////создание шума/////////////////
            double f;
            double en_signal = 0;
            double en_shum = 0;
            double[] n = new double[arraysize];
            for (int t = 0; t < arraysize; t++)
            {
                f = 0;
                for (int j = 0; j < 12; j++)
                {
                    f += Convert.ToDouble(rand.Next(-2000, 2000)) / 2000 / 12;
                }
                n[t] = f;
                en_signal += signal1[t] * signal1[t];
                en_shum += n[t] * n[t];
            }

            //подсчёт коэфициента альфа
            double alfa = Math.Sqrt((ur_shum +3)* en_signal / en_shum / 100);

            for (int t = 0; t < arraysize; t++)
            {
                signal1[t] = signal1[t] + (float)(alfa * n[t]);
            }

        }
       

        private void ZAVICIMOCT_Click(object sender, EventArgs e)
        {
            raz_spo = new double[100];
            //s_1 = new double[N];
            minmax = new double[arraysize];
            //lyambda = new double[M];
            //Rxx = new double[M];
            animation = true;
           // shag_shum = 10;
            epss = 0.4;
            proverka = 5;
            for (int v = 0; v < 100; v++)
            {
                raz_spo[v] = 0;
            }
            q = 0;
            f1 = 0.15;
            f2 = 0.4;
            Q = 0;
            s = 0;
            ff1 = f1; ff2 = f2;
            chart2.Series[0].Points.Clear();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (proverka == 100) stop_animation = true;
            else
            {
                
                if (s < sred)
                {
                    // delete[] Rxx;
                    // delete[] lyambda;

                    max1 = 0; mmm = 0; min = 0; max2 = 0; py = 0;
                    for (int i = 0; i < arraysize; i++)
                    {
                        signal1[i] = 0;
                        minmax[i] = 0;
                        spec[i] = 0;
                    }
                    auto_sinus((int)proverka, f1, f2);
                   
                    Matrix(signal1);


                    /////здесь надо посчитать два максимума/////////////
                    max1 = spec[0];
                    for (int i = 0; i < arraysize; i++)
                        if (max1 < spec[i]) max1 = spec[i];
                    mmm = max1;// mmm-самый большой максимум

                    min = max1 / 2.7;//порог
                    for (int i = 0; i < arraysize; i++)
                    {
                        if (spec[i] > min) minmax[i] = spec[i];
                        else minmax[i] = min;
                    }


                    int mf1 = 1; max1 = minmax[0];
                    while (minmax[mf1] >= max1)
                    {
                        max1 = minmax[mf1];
                        mf1++;
                    }
                    mf1 -= 1;

                    int mf2 = arraysize / 2 - 1; max2 = minmax[arraysize / 2];
                    while (minmax[mf2] >= max2)
                    {
                        max2 = minmax[mf2];
                        mf2--;
                    }
                    mf2 += 1;

                    if (mf1 > mf2)
                    {
                        py = mf1;
                        mf1 = mf2;
                        mf2 = (int)py;
                    }

                    min = spec[mf1];
                    for (int i = mf1 + 1; i < mf2; i++)
                    {
                        if (spec[i] < min) min = spec[i];
                    }
                    ///////////////////////////////////////////////


                    if ((min / mmm) < (1 / Math.Sqrt(2)) + epss && (min / mmm) > (1 / Math.Sqrt(2)) - epss)
                    {
                        R = (f2 - f1);
                        raz_spo[q] += R / sred;//(mf2 - mf1) / sred;


                        s++;

                        f1 = ff1;
                        f2 = ff2;

                    }
                    else
                    {
                        f1 += 0.002;
                        f2 -= 0.002;
                       
                    }
                    
                }
                else
                {
                    chart2.Series[0].Points.AddXY(proverka, raz_spo[q]);
                    proverka +=shag_shum;

                    NOISE.Text = Convert.ToString(proverka);
                    noise = proverka;
                    s = 0;

                    Q++;
                    q++;
                    raz_spo[q] = 0;
                   
                   // f1 = ff1;
                   // f2 = ff2;
                }
               
            }
        }
    }
}
;
