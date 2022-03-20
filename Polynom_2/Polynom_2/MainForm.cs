using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Net.WebRequestMethods;




namespace WindowsFormsApp
{

    public partial class MainForm : Form
    {

        public string inputFirstZeroVector = "0";
        public string inputFirstZeroFunction = "0";
        public string[] bulFunction;//Булева функція
        public string[] vector;//Вектор поляризації
        public int OPERATION_COUNT = 0;
        public bool IS_OPERATION_COUNT = true;
        public int ADDITIONS_COUNT = 0;
        public bool IS_ADDITIONS_COUNT = false;
        public int CHANGE_COUNT = 0;
        public bool IS_CHANGE_COUNT = false;
        public int COUNT_QUESTIONS_FUNCTION;
        public int K;
        public int N;
        public int ROW_COUNT;
        public int[][] ARR_V;
        public string[] P_ARR;
        public string F_X;
        public UInt64 BEGIN_DIVISION_VALUE = (UInt64)Math.Pow(2, 16);//верхня межа для поділу всеможливих булевих функцій

        public MainForm()
        {
            InitializeComponent();
        }


        // Створення головної форми програми //
        private void MainForm_Load(object sender, EventArgs e)
        {
            panelForText.Margin = new Padding(10, 0, 0, 0);  //Відступ зліва в 10px            
            rtbResPolynom.RightMargin = rtbResPolynom.Size.Width - 55;//Відступ справа
            rtbResPolynom.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            BuiidBulFunction();
            BuindVector();
        }


        //Побудова таблиці істинності булевої функції//
        void BuiidBulFunction()
        {

            int columnCount = Convert.ToInt32(countBulChanges.Value);//Кількість булевих змінних
            int rowCount = Convert.ToInt32(Math.Pow(2, decimal.ToDouble(countBulChanges.Value)));
            int[,] x = new int[rowCount, columnCount];
            bulFunction = new string[rowCount];
            dgvBulFunction.RowCount = rowCount + 1;//Загальна кількість рядків у таблиці істиності
            dgvBulFunction.ColumnCount = columnCount + 1;//Загальна кількість стовпців у таблиці істиності           
            dgvBulFunction[0, 0].Selected = false;
            dgvBulFunction[Convert.ToInt32(countBulChanges.Value), 1].Selected = true;//Фокусування на першому елементі булевої функції            
            dgvBulFunction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//Пришвидшення побудови таблиці істиності
            dgvBulFunction.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Центрування вмісту комірок таблиці істинності

            //Визначення ширини та висоти таблиці//
            if (columnCount <= 4)
            {
                dgvBulFunction.Width = (columnCount + 1) * 24;
                if (columnCount == 4)
                {
                    dgvBulFunction.Height = 358;
                }
                else
                {
                    dgvBulFunction.Height = (rowCount + 1) * 24 + 3;

                }
            }
            else
            {
                dgvBulFunction.Width = (columnCount + 1) * 25 + 6;
                dgvBulFunction.Height = 358;
            }

            //Заповнення комірок першого рядка таблиці, не включаючи останнію. Визначення кольору фону і тексту за замовчуванням та при натисканні//
            for (int i = 0; i < columnCount; i++)
            {
                dgvBulFunction[i, 0].Value = "X" + (i + 1).ToString();
                dgvBulFunction[i, 0].Style.BackColor = grbFunction.BackColor;
                dgvBulFunction[i, 0].Style.SelectionBackColor = grbFunction.BackColor;
                dgvBulFunction[i, 0].Style.ForeColor = grbFunction.ForeColor;
                dgvBulFunction[i, 0].Style.SelectionForeColor = grbFunction.ForeColor;
            }

            //Заповнення останньої комірки першого рядка. Визначення кольору фону і тексту за замовчуванням та при натисканні//
            dgvBulFunction[columnCount, 0].Value = "F";
            dgvBulFunction[columnCount, 0].Style.BackColor = grbFunction.BackColor;
            dgvBulFunction[columnCount, 0].Style.SelectionBackColor = grbFunction.BackColor;
            dgvBulFunction[columnCount, 0].Style.ForeColor = grbFunction.ForeColor;
            dgvBulFunction[columnCount, 0].Style.SelectionForeColor = grbFunction.ForeColor;

            //Заповнення комірок останнього стовпчика таблиці, не включаючи першу. Визначення кольору фону і тексту за замовчуванням та при натисканні// 
            for (int i = 0; i < rowCount; i++)
            {
                bulFunction[i] = "0";
                dgvBulFunction[columnCount, i + 1].Value = bulFunction[i];
                if (i != 0)
                {
                    dgvBulFunction[columnCount, i + 1].Style.BackColor = Color.White;
                    dgvBulFunction[columnCount, i + 1].Style.SelectionBackColor = Color.White;
                    dgvBulFunction[columnCount, i + 1].Style.ForeColor = grbFunction.ForeColor;
                    dgvBulFunction[columnCount, i + 1].Style.SelectionForeColor = grbFunction.ForeColor;
                }
                if (i == 0)
                {
                    dgvBulFunction[columnCount, i + 1].Style.BackColor = Color.White;
                    dgvBulFunction[columnCount, i + 1].Style.SelectionBackColor = Color.RoyalBlue;
                    dgvBulFunction[columnCount, 1].Style.SelectionForeColor = Color.White;
                }
            }

            //Заповнення всіх комірок таблиці, не включаючи комірки першого рядка та останнього стовпчика. Визначення кольору фону і тексту за замовчуванням та при натисканні// 
            for (int i = 0; i < rowCount; i++)
            {
                if (i != 0)
                {

                    for (int j = columnCount - 1; j >= 0; j--)
                    { x[i, j] = x[i - 1, j]; }
                    for (int j = columnCount - 1; j >= 0; j--)
                    {
                        if (x[i, j] == 0)
                        {
                            x[i, j] = 1;
                            break;
                        }
                        else x[i, j] = 0;
                    }
                }
                for (int j = 0; j <= columnCount - 1; j++)
                {
                    dgvBulFunction[j, i + 1].Value = (x[i, j]);
                    dgvBulFunction[j, i + 1].Style.SelectionForeColor = grbFunction.ForeColor;
                    dgvBulFunction[j, i + 1].Style.BackColor = grbFunction.BackColor;
                    dgvBulFunction[j, i + 1].Style.SelectionBackColor = grbFunction.BackColor;
                    dgvBulFunction[j, i + 1].Style.ForeColor = grbFunction.ForeColor;
                }
            }

            dgvBulFunction.Rows[0].Frozen = true;//Фіксування першого рядка таблиці. Тобто, при прокручування таблиці, завжди буде видимий її перший рядок           

        }


        //Побудова таблиці вектора поляризації//
        void BuindVector()
        {

            int columnCount = Convert.ToInt32(countBulChanges.Value);
            int rowCount = Convert.ToInt32(Math.Pow(2, decimal.ToDouble(countBulChanges.Value)));

            //Визначення ширини та висоти таблиці
            dgvVector.Width = (columnCount) * 25;
            if (columnCount >= 4)
            {
                dgvVector.Width = (columnCount) * 25 - columnCount + 1;
            }
            dgvVector.Height = (2) * 20 + 3;

            dgvVector.RowCount = 2;//Кількість рядків
            dgvVector.ColumnCount = columnCount;//Кількість стовпців  

            dgvVector[0, 0].Selected = false;
            dgvVector[0, 1].Selected = true;//Фокусування на першому елементі вектора поляризації

            //Визначення кольору фону і тексту за замовчуванням та при натисканні//
            dgvVector.Rows[0].DefaultCellStyle.BackColor = grbFunction.BackColor;
            dgvVector.Rows[0].DefaultCellStyle.ForeColor = grbFunction.ForeColor;
            dgvVector.Rows[0].DefaultCellStyle.SelectionBackColor = grbFunction.BackColor;
            dgvVector.Rows[0].DefaultCellStyle.SelectionForeColor = grbFunction.ForeColor;
            dgvVector.Rows[1].DefaultCellStyle.SelectionBackColor = Color.White;
            dgvVector.Rows[1].DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVector.Rows[1].DefaultCellStyle.BackColor = Color.White;
            dgvVector.Rows[1].DefaultCellStyle.ForeColor = Color.Black;

            dgvVector[0, 1].Style.SelectionBackColor = Color.RoyalBlue;
            dgvVector[0, 1].Style.SelectionForeColor = Color.White;

            vector = new string[columnCount];

            //Заповнення таблиці
            for (int x = 0; x < columnCount; x++)
            {
                dgvVector[x, 0].Value = "X" + (x + 1).ToString();
                vector[x] = inputFirstZeroVector;
                dgvVector[x, 1].Value = vector[x];
            }

            dgvVector.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Центрування вмісту комірок вектора поляризації
        }


        //Побудова поліному методом двійкового трикутника//
        private string BuildPolynom(int n, int k, int[] arrVector, int[] boolFunction, out int operationCount, out int someCount)
        {
            operationCount = 0;
            someCount = 0;
            int[] f = new int[k];
            int[] q = new int[n];
            int[,] A = new int[k, n];
            int[,] Af = new int[k, n + 1];
            int[,] Aq = new int[k, n + 1];
            int zeroFunct = 0;
            int oneFunct = 0;
            string s = " ";

            for (int i = 0; i < k; i++)
            {
                f[i] = boolFunction[i];
                if (f[i] == 0)
                {
                    zeroFunct += 1;
                }
                else
                {
                    oneFunct += 1;
                }
            }

            if (zeroFunct == k)
            {
                s += "0";
                if (IS_ADDITIONS_COUNT)
                {
                    operationCount = 1;
                }
                return s;
            }

            if (oneFunct == k)
            {
                s += "1";
                if (IS_ADDITIONS_COUNT)
                {
                    operationCount = 1;
                }
                return s;
            }

            for (int i = 0; i < n; i++)
            {
                q[i] = arrVector[i];
            }

            int step, j, k1 = k - 1;
            for (int i = 0; i < n; i++)
            {
                step = Convert.ToInt32(Math.Pow(2, (n - 1 - i)));
                j = 0;
                while (j <= Math.Pow(2, n) - 1)
                {
                    while (step >= 1)
                    {
                        A[j, i] = 0;
                        Af[j, i] = 0;
                        Aq[j, i] = 0;
                        j++;
                        step--;
                    }
                    step = Convert.ToInt32(Math.Pow(2, (n - 1 - i)));
                    while (step >= 1)
                    {
                        A[j, i] = 1;
                        Af[j, i] = 1;
                        Aq[j, i] = 1;
                        j++;
                        step--;
                    }
                    step = Convert.ToInt32(Math.Pow(2, (n - 1 - i)));
                }
            }

            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                Af[i, n] = f[i];
            }

            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                int[] temp1 = new int[n];
                for (int j1 = 0; j1 < n; j1++)
                {
                    if (q[j1] == 1)
                    {
                        if (Aq[i, j1] == 0)
                        {
                            temp1[j1] = 1;
                        }
                        else
                        {
                            temp1[j1] = 0;
                        }
                    }
                    else
                    {
                        temp1[j1] = Aq[i, j1];
                    }
                }

                for (int t = 0; t < Math.Pow(2, n); t++)
                {
                    int m = 0;
                    if (m >= n)
                    { break; }
                    while (Af[t, m] == temp1[m])
                    {
                        m++;
                        if (m >= n)
                        { break; }
                    }
                    if (m > n - 1)
                    {
                        Aq[i, n] = Af[t, n];
                        break;
                    }
                }
            }

            int l = Convert.ToInt32(Math.Pow(2, n));
            int[] mas = new int[l];
            int[] res = new int[l];
            int kount = 0;
            int temp = Convert.ToInt32(Math.Pow(2, n));
            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                mas[i] = Aq[i, n];
            }

            res[kount] = mas[kount];
            kount++;
            while (temp >= 1)
            {
                int[] t = new int[temp];
                int[] t2 = new int[temp - 1];
                t = mas;
                for (int i = 0; i < temp - 1; i++)
                {
                    if (t[i] != t[i + 1])
                    { t2[i] = 1; }
                    else
                    { t2[i] = 0; }
                }
                res[kount] = t2[0];
                kount++;

                if (kount >= l)
                    break;
                mas = t2;
                temp--;

            }

            string[] x = new string[n];
            string[] unicodeCharacters = new string[]
                                        { "\u2081",
                                          "\u2082",
                                          "\u2083",
                                          "\u2084",
                                          "\u2085",
                                          "\u2086",
                                          "\u2087",
                                          "\u2088",
                                          "\u2089",};
            for (int i = 0; i < n; i++)
            {

                if (q[i] == 1)
                {
                    x[i] = "x̄" + unicodeCharacters[i];
                }
                else
                {
                    x[i] = "x" + unicodeCharacters[i];

                }
            }


            int opCount = 0;//кількість операцій в поліномі
            int dobCount = 0;//кількість добутків у кожній кон'юнкції
            int desCount = 0;//кількість доданків в поліномі
            int minusCount = 0;//кількість заперечень
            int generalChangeCount = 0;//загальна кількість змінних в поліномі


            if (res[0] == 1)
            { s = " 1⊕"; ; desCount += 1; }
            for (int i = 1; i < Math.Pow(2, n); i++)
            {
                if (res[i] != 0)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (A[i, j] != 0)
                        {
                            s = s + x[j];
                            generalChangeCount += 1;
                            if (q[j] == 1)
                            {
                                minusCount += 1;
                            }
                            dobCount += 1;
                        }
                    }
                    if (dobCount >= 1)
                    {
                        opCount += dobCount - 1;
                    }
                    s = s + "⊕";
                    desCount += 1;
                    dobCount = 0;
                }
            }

            char[] s_temp = s.ToCharArray();
            if (s_temp[s_temp.Length - 1] == '⊕')
            {
                s = "";
                desCount -= 1;
                for (int c = 0; c < s_temp.Length - 1; c++)
                {
                    s = s + s_temp[c];
                }
            }
            opCount += desCount;
            opCount += minusCount;
            if (IS_OPERATION_COUNT == true)
            {
                operationCount = opCount;
            }
            else if (IS_ADDITIONS_COUNT == true)
            {
                operationCount = desCount + 1;
            }
            else if (IS_CHANGE_COUNT == true)
            {
                operationCount = generalChangeCount;
            }

            return s;
        }


        //Обробка зміни значення функції//
        private void DGVBulFunction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBulFunction[e.ColumnIndex, e.RowIndex].Style.WrapMode = DataGridViewTriState.NotSet;
            if (e.ColumnIndex == dgvBulFunction.ColumnCount - 1 && e.RowIndex != 0)
            {
                rtbResPolynom.Text = "";
                if (dgvBulFunction[e.ColumnIndex, e.RowIndex].Value == "0")
                {
                    dgvBulFunction[e.ColumnIndex, e.RowIndex].Value = "1";
                }
                else if (dgvBulFunction[e.ColumnIndex, e.RowIndex].Value == "1")
                {
                    dgvBulFunction[e.ColumnIndex, e.RowIndex].Value = "?";
                }
                else
                {
                    dgvBulFunction[e.ColumnIndex, e.RowIndex].Value = "0";
                }
            }
        }


        // Обробка зміни значення вектора поляризації //
        private void DGVVector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 1)
            {
                rtbResPolynom.Text = "";
                if (dgvVector[e.ColumnIndex, e.RowIndex].Value == "0")
                {
                    dgvVector[e.ColumnIndex, e.RowIndex].Value = "1";
                }
                else if (dgvVector[e.ColumnIndex, e.RowIndex].Value == "1")
                {
                    dgvVector[e.ColumnIndex, e.RowIndex].Value = "?";
                }
                else
                {
                    dgvVector[e.ColumnIndex, e.RowIndex].Value = "0";
                }
            }
        }


        //Перебудова булевої функції для всіх 0 або всіх 1//
        private void RebuildFunction()
        {
            int rowCount = Convert.ToInt32(Math.Pow(2, Convert.ToDouble(countBulChanges.Value)));
            for (int i = 1; i <= rowCount; i++)
            {
                dgvBulFunction[Convert.ToInt32(countBulChanges.Value), i].Value = inputFirstZeroFunction;
            }
        }


        //Перебудова вектора поляризації для всіх 0 або всіх 1//
        private void RebuildVector()
        {
            for (int i = 0; i < dgvVector.ColumnCount; i++)
            {
                dgvVector[i, 1].Value = inputFirstZeroVector;
            }
        }


        //Обробка зміни кількості змінних//
        private void BuildFunctionAndVector_ValueChanged(object sender, EventArgs e)
        {
            dgvVector.ClearSelection();
            dgvBulFunction.ClearSelection();
            inputFirstZeroVector = "0";
            inputFirstZeroFunction = "0";
            BuindVector();
            BuiidBulFunction();
        }


        // Обробка натискання кнопки заповнення стовпчика значень функції нулями //
        private void AllZeroesFunction_Click(object sender, EventArgs e)
        {
            BuildFunctionSameValue("0");
        }


        // Обробка натискання кнопки заповнення стовпчика значень функції одиницями //
        private void AllOnesFunction_Click(object sender, EventArgs e)
        {
            BuildFunctionSameValue("1");
        }
        private void allQuestionsFunction_Click(object sender, EventArgs e)
        {
            BuildFunctionSameValue("?");
        }

        private void BuildFunctionSameValue(string value)
        {
            rtbResPolynom.Text = "";
            inputFirstZeroFunction = value;
            RebuildFunction();
        }


        // Обробка натискання кнопки заповнення вектора поляризації нулями //
        private void AllZeroesVector_Click(object sender, EventArgs e)
        {
            rtbResPolynom.Text = "";
            inputFirstZeroVector = "0";
            RebuildVector();
        }


        // Обробка натискання кнопки заповнення вектора поляризації одиницями //
        private void AllOnesVector_Click(object sender, EventArgs e)
        {
            rtbResPolynom.Text = "";
            inputFirstZeroVector = "1";
            RebuildVector();
        }
        private void AllQuestionsVector_Click(object sender, EventArgs e)
        {
            rtbResPolynom.Text = "";
            inputFirstZeroVector = "?";
            RebuildVector();
        }


        // Обробка натискання кнопки побудови поліному //
        private async void BtnBuildPolynom_Click(object sender, EventArgs e)
        {
            AnalizeData();
            int n, k;
            int countQuestionsVector = 0;
            int countQuestionsFunction = 0;
            int someCount;
            int operations;
            n = Convert.ToInt32(countBulChanges.Value);
            k = Convert.ToInt32(Math.Pow(2, n));
            int[] arrVector = new int[n];
            int[] arrFunction = new int[k];
            string questionAnalysis;
            string p = "", s = "";
            for (int i = 0; i < k; i++)
            {
                questionAnalysis = Convert.ToString(dgvBulFunction[Convert.ToInt32(countBulChanges.Value), i + 1].Value);
                if (questionAnalysis == "?")
                {
                    countQuestionsFunction += 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                p += dgvVector[i, 1].Value;
            }



            for (int i = 0; i < n; i++)
            {
                questionAnalysis = Convert.ToString(dgvVector[i, 1].Value);
                if (questionAnalysis == "?")
                {
                    countQuestionsVector += 1;
                }
            }
            if (countQuestionsVector == 0 && countQuestionsFunction == 0)
            {
                string searchCriterious = "";
                p = "";
                if (IS_OPERATION_COUNT == true)
                {
                    searchCriterious = "операцій";
                }
                else if (IS_ADDITIONS_COUNT == true)
                {
                    searchCriterious = "доданків";
                }
                else if (IS_CHANGE_COUNT == true)
                {
                    searchCriterious = "входжень змінних";
                }
                s = "\nМінімальний" + " (за кількістю " + searchCriterious + ") поляризований" + " поліном Ріда - Маллера:\n";
                //s = "\nПоляризований поліном Ріда-Маллера:\n\n" + "P [" + p + "] F = ";
                for (int i = 0; i < n; i++)
                {
                    arrVector[i] = Convert.ToInt32(dgvVector[i, 1].Value);
                    p += arrVector[i];
                }
                for (int i = 0; i < k; i++)
                {
                    arrFunction[i] = Convert.ToInt32(dgvBulFunction[Convert.ToInt32(countBulChanges.Value), i + 1].Value);
                }
                string tmpRes = BuildPolynom(n, k, arrVector, arrFunction, out operations, out someCount);
                s += "P[" + p + "] F = " + tmpRes + "     L(P[" + p + "])F = " + operations + "\n";
                rtbResPolynom.Text = s;
                rtbResPolynom.SelectAll();
                rtbResPolynom.SelectionCharOffset = 8;//міжрядковий інтервал
                rtbResPolynom.SelectionAlignment = HorizontalAlignment.Left;//горизонтальне вирівнювання тексту
            }

            else if (countQuestionsFunction == 0)
            {
                for (int i = 0; i < k; i++)
                {
                    arrFunction[i] = Convert.ToInt32(dgvBulFunction[Convert.ToInt32(countBulChanges.Value), i + 1].Value);
                }
                int columnCount = countQuestionsVector;//Кількість булевих змінних
                int rowCount = Convert.ToInt32(Math.Pow(2, countQuestionsVector));
                int[,] arrQuestion = new int[rowCount, columnCount];
                for (int i = 0; i < rowCount; i++)
                {
                    if (i != 0)
                    {

                        for (int j = columnCount - 1; j >= 0; j--)
                        { arrQuestion[i, j] = arrQuestion[i - 1, j]; }
                        for (int j = columnCount - 1; j >= 0; j--)
                        {
                            if (arrQuestion[i, j] == 0)
                            {
                                arrQuestion[i, j] = 1;
                                break;
                            }
                            else arrQuestion[i, j] = 0;
                        }
                    }

                }
                string resPolynom = "";
                int polynomCout = 0;
                int currOpVector = 0;//змінна, що визначає кількісь операцій/доданків/змінних
                for (int i = 0; i < rowCount; i++)
                {
                    p = "";

                    int questionNumber = 0;
                    for (int j = 0; j < n; j++)
                    {
                        questionAnalysis = Convert.ToString(dgvVector[j, 1].Value);
                        if (questionAnalysis == "?")
                        {
                            arrVector[j] = arrQuestion[i, questionNumber];
                            questionNumber += 1;
                        }
                        else
                        {
                            arrVector[j] = Convert.ToInt32(dgvVector[j, 1].Value);
                        }
                        p += arrVector[j];
                    }
                    string tmpRes = BuildPolynom(n, k, arrVector, arrFunction, out operations, out someCount);
                    string polynomRes = "P[" + p + "] F = " + tmpRes + "     L(P[" + p + "])F = " + operations + "\n";
                    if (currOpVector == 0 && i == 0)
                    {
                        currOpVector = operations;
                        resPolynom += polynomRes;
                        polynomCout += 1;
                    }
                    else if (currOpVector > operations)
                    {
                        currOpVector = operations;
                        resPolynom = polynomRes;
                        polynomCout = 1;
                    }
                    else if (currOpVector == operations)
                    {
                        resPolynom += polynomRes;
                        polynomCout += 1;
                    }
                }
                string searchCriterious = "";
                if (IS_OPERATION_COUNT == true)
                {
                    searchCriterious = "операцій";
                }
                else if (IS_ADDITIONS_COUNT == true)
                {
                    searchCriterious = "доданків";
                }
                else if (IS_CHANGE_COUNT == true)
                {
                    searchCriterious = "входжень змінних";
                }
                rtbResPolynom.Text = "\nМінімальн" + (polynomCout > 1 ? "і" : "ий") + " (за кількістю " + searchCriterious + ") поляризован" + (polynomCout > 1 ? "і" : "ий") + " поліном" + (polynomCout > 1 ? "и" : "") + " Ріда - Маллера:\n";

                //rtbResPolynom.Text = "\nПоляризован" + (polynomCout > 1 ? "і" : "ий") + " поліном" + (polynomCout > 1 ? "и" : "") + " Ріда - Маллера:\n\n";
                rtbResPolynom.Text += resPolynom;
                rtbResPolynom.SelectAll();
                rtbResPolynom.SelectionCharOffset = 8;//міжрядковий інтервал
                rtbResPolynom.SelectionAlignment = HorizontalAlignment.Left;//горизонтальне вирівнювання тексту

            }
            else
            {
               
                    //утворюємо всеможливі набори із ? для вектора поляризації
                    int columnCount = countQuestionsVector;//Кількість булевих змінних
                    int rowCount = Convert.ToInt32(Math.Pow(2, countQuestionsVector));
                    int[][] arrQuestion;
                    int[][] arrV = new int[rowCount][];
                    string[] pArr = new string[rowCount];
                    int questionNumber = 0;
                    if (countQuestionsVector != 0)
                    {
                        arrQuestion = BitSetArr(0, Convert.ToUInt32(rowCount - 1), columnCount);
                        //всеможливі вектори
                        for (int i = 0; i < rowCount; i++)
                        {
                            arrV[i] = new int[n];
                            questionNumber = 0;
                            pArr[i] = "";
                            for (int j = 0; j < n; j++)
                            {
                                questionAnalysis = Convert.ToString(dgvVector[j, 1].Value);

                                if (questionAnalysis == "?")
                                {
                                    arrV[i][j] = arrQuestion[i][questionNumber];
                                    questionNumber += 1;
                                }
                                else
                                {
                                    arrV[i][j] = Convert.ToInt32(dgvVector[j, 1].Value);
                                }
                                pArr[i] += arrV[i][j];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            arrV[i] = new int[n];
                            pArr[i] = "";
                            for (int j = 0; j < n; j++)
                            {
                                arrV[i][j] = Convert.ToInt32(dgvVector[j, 1].Value);
                                pArr[i] += arrV[i][j];
                            }
                        }
                    }

                    string[] upIndex = new string[] { "\u00B9", "\u00B2", "\u00B3", "\u2074", "\u2075", "\u2076", "\u2077", "\u2078", "\u2079" };
                    string fX = "x̃" + upIndex[n - 1];
                    int columnCountFunction = countQuestionsFunction;//Кількість булевих змінних                
                    int[] arrF = new int[k];
                COUNT_QUESTIONS_FUNCTION = countQuestionsFunction;
                K = k;
                N = n;
                ROW_COUNT = rowCount;
                ARR_V = arrV;
                P_ARR = pArr;
                F_X = fX;
                // UInt64 end = ((UInt64)(Math.Pow(2, countQuestionsFunction))) / ((UInt64)(Math.Pow(2, countQuestionsFunction/2)));
                // var range = Range.UInt64(0, end-1L, 1L);                
                // var Queue = new ConcurrentQueue<UInt64>(range);
                // var tasks = new List<Task<List<Polynom>>>();


                // int minimum = int.MaxValue;
                // for (int i = 0; i < System.Environment.ProcessorCount; i++)
                // {
                //     var t = Task.Run(() => DequeueAndRun());
                //     tasks.Add(t);
                // }


                //var ResArr= await Task.WhenAll(tasks);
                // List<Polynom> DequeueAndRun()
                // {
                //     var someResult = new List<Polynom>();
                //     while (Queue.TryDequeue(out UInt64 number))
                //     {
                //         var polinom = GetMinPolynomFromCurrentContext(number);//(number)
                //         if (polinom.OperationCount < minimum)
                //         {
                //             someResult = new List<Polynom> { polinom };
                //             minimum = polinom.OperationCount;
                //         }
                //         else if (polinom.OperationCount == minimum)
                //         {
                //             someResult.Add(polinom);
                //         }

                //     }
                //     return someResult;
                // }

                // Polynom resPol = new Polynom();
                // resPol.OperationCount = minimum;
                // foreach (Polynom polynom in ResArr.SelectMany(x=>x))
                // {
                //     resPol.ResPolynom += polynom.ResPolynom;
                // }
                //////
                //
                //UInt64 start1 = (UInt64)(Math.Pow(2, countQuestionsFunction))-1L;
                //UInt64 end1 = ((UInt64)(Math.Pow(2, countQuestionsFunction)));
                //var range1 = Range.UInt64(start1, end1 - 1L, 1L);
                //var Queue1 = new ConcurrentQueue<UInt64>(range1);
                //var tasks1 = new List<Task<List<Polynom>>>();

                //var someResult1 = new List<Polynom>();
                //int minimum1 = int.MaxValue;
                //for (int i = 0; i < System.Environment.ProcessorCount; i++)
                //{
                //    var t = Task.Run(() => DequeueAndRun1());
                //    tasks1.Add(t);
                //}


                //var ResArr1 = await Task.WhenAll(tasks1);
                //List<Polynom> DequeueAndRun1()
                //{
                //    var someResult2 = new List<Polynom>();
                //    while (Queue1.TryDequeue(out UInt64 number))
                //    {
                //        var polinom = GetMinPolynomFromCurrentContext(number);//(number)
                //        if (polinom.OperationCount < minimum1)
                //        {
                //            someResult2 = new List<Polynom> { polinom };
                //            minimum1 = polinom.OperationCount;
                //        }
                //        else if (polinom.OperationCount == minimum1)
                //        {
                //            someResult2.Add(polinom);
                //        }

                //    }
                //    return someResult2;
                //}

                //Polynom resPol1 = new Polynom();
                //resPol1.OperationCount = minimum1;
                //foreach (Polynom polynom in ResArr1.SelectMany(x => x))
                //{
                //    resPol1.ResPolynom += polynom.ResPolynom;
                //}
                UInt64 START = 0;
               
                UInt64 FINAL_VALUE = (UInt64)(Math.Pow(2, countQuestionsFunction));
                UInt64 END = BEGIN_DIVISION_VALUE < FINAL_VALUE?BEGIN_DIVISION_VALUE:FINAL_VALUE;
                List<Polynom> RESULT_POLYNOM = new List<Polynom>();
                do
                {
                    RESULT_POLYNOM.Add(await GetAsyncPolynomAsync(START, END));
                    START = END;
                    END += BEGIN_DIVISION_VALUE;
                }
                while (END <= FINAL_VALUE);
                Polynom RES = new Polynom();
                RES.ResPolynom = "";
                RES.OperationCount = RESULT_POLYNOM.Select(x => x.OperationCount).Min();
                foreach (Polynom polynom in RESULT_POLYNOM)
                {
                        if (polynom.OperationCount == RES.OperationCount)
                        RES.ResPolynom += "\n" + polynom.ResPolynom;
                }

                string searchCriterious = "";
                if (IS_OPERATION_COUNT == true)
                {
                    searchCriterious = "операцій";
                }
                else if (IS_ADDITIONS_COUNT == true)
                {
                    searchCriterious = "доданків";
                }
                else if (IS_CHANGE_COUNT == true)
                {
                    searchCriterious = "входжень змінних";
                }
                int countOp = 0;
                rtbResPolynom.Text += "\nМінімальн" + (countOp > 1 ? "і" : "ий") + " (за кількістю " + searchCriterious + ") поляризован" + (countOp > 1 ? "і" : "ий") + " поліном" + (countOp > 1 ? "и" : "") + " Ріда - Маллера:\n\n";
                rtbResPolynom.Text += RES.ResPolynom;
                rtbResPolynom.SelectAll();
                rtbResPolynom.SelectionCharOffset = 8;//міжрядковий інтервал
                rtbResPolynom.SelectionAlignment = HorizontalAlignment.Left;//горизонтальне вирівнювання тексту

            }
        }
        private async Task<Polynom> GetAsyncPolynomAsync(UInt64 start, UInt64 end)
        {
            //UInt64 end = ((UInt64)(Math.Pow(2, countQuestionsFunction))) / ((UInt64)(Math.Pow(2, countQuestionsFunction / 2)));
            var range = Range.UInt64(start, end - 1L, 1L);
            var Queue = new ConcurrentQueue<UInt64>(range);
            var tasks = new List<Task<List<Polynom>>>();


            int minimum = int.MaxValue;
            for (int i = 0; i < System.Environment.ProcessorCount; i++)
            {
                var t = Task.Run(() => DequeueAndRun());
                tasks.Add(t);
            }


            var ResArr = await Task.WhenAll(tasks);
            List<Polynom> DequeueAndRun()
            {
                var someResult = new List<Polynom>();
                while (Queue.TryDequeue(out UInt64 number))
                {
                    var polinom = GetMinPolynomFromCurrentContext(number);//(number)
                    if (polinom.OperationCount < minimum)
                    {
                        someResult = new List<Polynom> { polinom };
                        minimum = polinom.OperationCount;
                    }
                    else if (polinom.OperationCount == minimum)
                    {
                        someResult.Add(polinom);
                    }

                }
                return someResult;
            }

            Polynom resPol = new Polynom();
            resPol.OperationCount = minimum;
            foreach (Polynom polynom in ResArr.SelectMany(x => x))
            {
                resPol.ResPolynom += polynom.ResPolynom;
            }
            return resPol;

        }
        private Polynom GetMinPolynomFromCurrentContext(UInt64 start)
        {
            Polynom resPolynom = new Polynom();
            int currOp = 0;
            string resPol = "";
            int firstOp = 0;
            int polynomCount = 0;
            string boolFunction;
            string questionAnalysis;
            int[] arrQuestionFunction;
            int[] arrF = new int[K];
            int operations = 0;
            int someCount = 0;
            string value = $@"{firstOp} jjjj
jjjjj";
            //while (tmpfunc <= end)
            //{

            arrQuestionFunction = bitSetArrFromNumber(Convert.ToUInt32(start), COUNT_QUESTIONS_FUNCTION);

            int numberQuestion = 0;
            boolFunction = string.Empty;
            for (int l = 0; l < K; l++)
            {
                questionAnalysis = Convert.ToString(dgvBulFunction[Convert.ToInt32(countBulChanges.Value), l + 1].Value);
                if (questionAnalysis == "?")
                {
                    arrF[l] = arrQuestionFunction[numberQuestion];
                    numberQuestion += 1;
                }
                else
                {
                    arrF[l] = Convert.ToInt32(dgvBulFunction[Convert.ToInt32(countBulChanges.Value), l + 1].Value);
                }
                boolFunction += arrF[l];
            }
            for (int i = 0; i < ROW_COUNT; i++)
            {
                string tmpRes = BuildPolynom(N, K, ARR_V[i], arrF, out operations, out someCount);
                
                string functionRes = "F(" + F_X + ") = (" + boolFunction + "):\n";//stringBuilder//interpolatio@
                string polynomRes = "P[" + P_ARR[i] + "] F = " + tmpRes + "     L(P[" + P_ARR[i] + "])F = " + operations + "\n";
                if (currOp == 0 && firstOp == 0 && i == 0)
                {
                    currOp = operations;
                    resPol = functionRes;
                    resPol += polynomRes;
                    polynomCount += 1;
                }
                else if (currOp > operations)
                {
                    currOp = operations;
                    resPol = functionRes;
                    resPol += polynomRes;
                    polynomCount = 1;
                }
                else if (currOp == operations)
                {
                    if (i == 0)
                    {
                        resPol += "\n" + functionRes;
                    }
                    resPol += polynomRes;
                    polynomCount += 1;
                }
                firstOp = 1;

            }
            //tmpfunc += 1;
            //}



            resPolynom.OperationCount = currOp;
            resPolynom.ResPolynom = resPol;


            return resPolynom;
        }

        //метод, що додає два числа побітово
        private uint AddBitData(uint x, uint y)
        {
            uint keep = (x & y) << 1;
            uint res = x ^ y;
            if (keep == 0)
                return res;

            return AddBitData(keep, res);
        }
        //метод, що утворює всеможливі двійкові набори із діапазону [start,end], n-кількість 0 і 1 у одному двійковому наборі
        private int[][] BitSetArr(uint start, uint end, int n)
        {

            char[] charArr;
            //int k=Convert.ToInt32(Math.Pow(2,n));
            uint k = end - start + 1;
            int[][] arr = new int[k][];
            uint i = start;
            int varrIndex;
            int index = 0;
            while (index < k)
            {
                charArr = Convert.ToString(i, toBase: 2).ToCharArray();
                arr[index] = new int[n];
                Array.Clear(arr[index], 0, arr[index].Length);
                varrIndex = n - charArr.Length;
                for (int j = 0; j < charArr.Length; j++)
                {
                    arr[index][varrIndex + j] = (int)charArr[j] - '0';
                }
                i = AddBitData(i, 1);
                index++;
            }

            return arr;
        }
        //функція, що повертає двійковий набір одного числа, n-кількість 0 і 1 у двійковому наборі
        int[] bitSetArrFromNumber(uint number, int n)
        {

            char[] charArr;

            int[] arr = new int[n];
            uint i = number;
            int varrIndex;
            charArr = Convert.ToString(i, toBase: 2).ToCharArray();

            Array.Clear(arr, 0, arr.Length);
            varrIndex = n - charArr.Length;
            for (int j = 0; j < charArr.Length; j++)
            {
                arr[varrIndex + j] = (int)charArr[j] - '0';
            }
            return arr;
        }


        // Збереження результатів у файлі //
        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            int n, k;
            n = Convert.ToInt32(countBulChanges.Value);
            k = Convert.ToInt32(Math.Pow(2, n));
            String[] s = new string[8000];
            s[0] = "Кількість змінних:";
            s[1] = Convert.ToString(n) + "\n";
            s[2] = "Функція:";
            s[3] = "(";

            for (int i = 1; i <= k; i++)
            {
                s[3] += dgvBulFunction[Convert.ToInt32(countBulChanges.Value), i].Value;
            }

            s[3] += ")\n";
            s[4] = "Вектор поляризації:";
            s[5] = "[";

            for (int i = 0; i < n; i++)
            {
                s[5] += dgvVector[i, 1].Value;
            }

            s[5] += "]\n";

            for (int i = 0; i < rtbResPolynom.Lines.Count(); i++)
            {
                s[6 + i] = rtbResPolynom.Lines[i];
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = saveFileDialog.FileName;
                System.IO.File.WriteAllLines(saveFileDialog.FileName, s);
            }
        }


        //Обробка натискання кнопки очистки//
        private void Clean_Click(object sender, EventArgs e)
        {
            rtbResPolynom.Text = "";
            inputFirstZeroFunction = "0";
            inputFirstZeroVector = "0";
            radioBtnTheLeastCountOperations.Checked = true;
            IS_OPERATION_COUNT = true;
            OPERATION_COUNT = 0;
            BuiidBulFunction();
            BuindVector();
        }


        //Обробка натискання кнопки виходу//
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Вивід довідкової інформації//
        private void AboutProgramTSMI_Click(object sender, EventArgs e)
        {
            HelpForm myNewForm = new HelpForm();
            myNewForm.Visible = true;
        }


        //Створення 3D-ефекту для елементів керування
        void D_effect(Button button, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button.ClientRectangle,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
            Color.Gray, 2, ButtonBorderStyle.Inset,
            Color.Gray, 2, ButtonBorderStyle.Inset);
        }


        //Визначення стилів для елементів керування//
        private void BtnBuildPolynom_Paint(object sender, PaintEventArgs e)
        {
            D_effect(BtnBuildPolynom, e);
        }

        private void allZeroesVector_Paint(object sender, PaintEventArgs e)
        {
            D_effect(allZeroesVector, e);
        }

        private void allOnesVector_Paint(object sender, PaintEventArgs e)
        {
            D_effect(allOnesVector, e);
        }

        private void allQuestionsVector_Paint(object sender, PaintEventArgs e)
        {
            D_effect(allQuestionsVector, e);
        }

        private void allZeroesFunction_Paint(object sender, PaintEventArgs e)
        {
            D_effect(allZeroesFunction, e);
        }

        private void allOnesFunction_Paint(object sender, PaintEventArgs e)
        {
            D_effect(allOnesFunction, e);
        }
        private void allQuestionsFunction_Paint(object sender, PaintEventArgs e)
        {
            D_effect(allQuestionsFunction, e);
        }

        private void Save_Paint(object sender, PaintEventArgs e)
        {
            D_effect(Save, e);
        }

        private void Clean_Paint(object sender, PaintEventArgs e)
        {
            D_effect(Clean, e);
        }

        private void Exit_Paint(object sender, PaintEventArgs e)
        {
            D_effect(Exit, e);
        }

        private void BtnBuildPolynom_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.BtnBuildPolynom, "Метод двійкового трикутника");
        }

        private void PanelForText_Paint(object sender, PaintEventArgs e)
        {
            panelForText.BorderStyle = BorderStyle.None;
            ControlPaint.DrawBorder(e.Graphics, panelForText.ClientRectangle,
            Color.Gray, 2, ButtonBorderStyle.Outset,
            Color.Gray, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
            SystemColors.ControlLight, 1, ButtonBorderStyle.Inset);
        }


        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                //Очищення тексту і рамки
                g.Clear(this.BackColor);

                //Вивід тексту
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + 8, 0);

                //Побудова рамки               
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));//Ліва сторона               
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));//Права сторона                
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));//Низ                
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left + 6, rect.Y));//Верх до тексту
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + 6 + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));//Верх після тексту
            }
        }

        private void GRBVector_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkGray);
        }

        private void PNLCountChanges_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlCountChanges.ClientRectangle,
               SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
               SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset,
               Color.Gray, 1, ButtonBorderStyle.Inset,
               Color.Gray, 1, ButtonBorderStyle.Inset);
        }

        private void GRBFunction_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkGray);
        }

        private void GRBFunctionOneZero_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkGray);
        }

        private void GRBSaveCleanExit_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkGray);
        }

        private void GRBVectorOneZero_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.DarkGray);
        }


        public void AnalizeData()
        {
            OPERATION_COUNT = 0;
            ADDITIONS_COUNT = 0;
            CHANGE_COUNT = 0;
            if (radioBtnTheLeastCountOperations.Checked == true)
            {
                //radioBtnTheLeastCountOperations.Checked = false;
                IS_OPERATION_COUNT = true;
            }
            if (radioBtnTheLeastCountAdditions.Checked == true)
            {
                //radioBtnTheLeastCountAdditions.Checked = false;
                IS_ADDITIONS_COUNT = true;
            }
            if (radioBtnTheLeastCountChanges.Checked == true)
            {

                IS_CHANGE_COUNT = true;
            }
        }
        public void CleanCriterious()//повертає у початкове(дефолтне положення) критеріЇ відбору та поле виводу
        {
            rtbResPolynom.Text = "";
            OPERATION_COUNT = 0;
            ADDITIONS_COUNT = 0;
            CHANGE_COUNT = 0;
        }
        private void radioBtnTheLeastCountOperations_Click(object sender, EventArgs e)
        {
            CleanCriterious();
            if (radioBtnTheLeastCountOperations.Checked == true)
            {
                radioBtnTheLeastCountOperations.Checked = false;
                IS_OPERATION_COUNT = false;
            }
            if (radioBtnTheLeastCountOperations.Checked == false)
            {
                radioBtnTheLeastCountChanges.Checked = false;
                IS_CHANGE_COUNT = false;
                radioBtnTheLeastCountAdditions.Checked = false;
                IS_ADDITIONS_COUNT = false;
                radioBtnTheLeastCountOperations.Checked = true;
                IS_OPERATION_COUNT = true;
            }

        }

        private void radioBtnTheLeastCountAdditions_Click(object sender, EventArgs e)
        {
            CleanCriterious();
            if (radioBtnTheLeastCountAdditions.Checked == true)
            {
                radioBtnTheLeastCountAdditions.Checked = false;
                IS_ADDITIONS_COUNT = false;
            }
            if (radioBtnTheLeastCountAdditions.Checked == false)
            {
                radioBtnTheLeastCountChanges.Checked = false;
                IS_CHANGE_COUNT = false;
                radioBtnTheLeastCountOperations.Checked = false;
                IS_OPERATION_COUNT = false;
                radioBtnTheLeastCountAdditions.Checked = true;
                IS_ADDITIONS_COUNT = true;
            }
        }

        private void radioBtnTheLeastCountChanges_Click(object sender, EventArgs e)
        {
            CleanCriterious();
            if (radioBtnTheLeastCountChanges.Checked == true)
            {
                radioBtnTheLeastCountChanges.Checked = false;
                IS_CHANGE_COUNT = false;
            }
            if (radioBtnTheLeastCountAdditions.Checked == false)
            {
                radioBtnTheLeastCountOperations.Checked = false;
                IS_OPERATION_COUNT = false;
                radioBtnTheLeastCountAdditions.Checked = false;
                IS_ADDITIONS_COUNT = false;
                radioBtnTheLeastCountChanges.Checked = true;
                IS_CHANGE_COUNT = true;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}


