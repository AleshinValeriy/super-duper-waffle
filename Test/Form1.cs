using System;
using System.Diagnostics;
using System.Windows.Forms;
using Test;

namespace Course_Work_Aleshin_24VP2_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OneWayLinkedList BaseList = new OneWayLinkedList();
        OneWayLinkedList ListShell = new OneWayLinkedList();
        OneWayLinkedList ListHeap = new OneWayLinkedList();
        OneWayLinkedList ListCount = new OneWayLinkedList();

        private void Form1_Load(object sender, EventArgs e)
        {
            UnorderedListCheck.Checked = true;

            ResultGraphics.ChartAreas[0].AxisX.Title = "Номер сортировки";
            ResultGraphics.ChartAreas[0].AxisY.Title = "Время сортировки";
            ResultGraphics.ChartAreas[0].AxisX.LabelStyle.Format = "P0";

            ResultTable.Rows.Add("Сортировка Шелла");
            ResultTable.Rows.Add("Пирамидальная сортировка");
            ResultTable.Rows.Add("Сортировка подсчётом");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            try
            {
                int size = (int)ListSize.Value;
                int percent = (int)PartlyOrderedListPercent.Value;

                throwExceptions(size,percent);

                ClearGraphics();

                chooseGenerateType(size, percent);

                FillTable(size);

                FillGraphics();
            }
            catch (Exception ex) {
                ErrorLabel.Text = "ОШИБКА: " + ex.Message;
            }
        }

        private void throwExceptions(int size, int percent)
        {
            string errorText = "";

            if(!PartlyOrderedListCheck.Checked)
            {
                if (size < 0)
                {
                    errorText += "Размер списка отрицательный!\n";
                }

                if (size == 0)
                {
                    errorText += "Размер списка равен нулю!\n";
                }
            }

            if (PartlyOrderedListCheck.Checked)
            {
                if (size < 0)
                {
                    errorText += "Размер списка отрицательный!\n";
                }

                if (size == 0)
                {
                    errorText += "Размер списка равен нулю!\n";
                }

                if (percent < 0)
                {
                    errorText += "Процент упорядоченности отрицательный!\n";
                }

                if (percent > 100)
                {
                    errorText += "Процент упорядоченности больше 100%!\n";
                }

                if (size < 0 && percent < 0)
                {
                    errorText += "Отрицательная размерность списка и процент упорядоченности!\n";
                }

                if (size == 0 && percent < 0)
                {
                    errorText += "Нулевая размерность списка и отрицательный процент упорядоченности!\n";
                }

                if (size == 0 && percent > 100)
                {
                    errorText += "Нулевая размерность списка и процент упорядоченности больше 100% !\n";
                }

                if (size < 0 && percent > 100)
                {
                    errorText += "Отрицательная размерность списка и процент упорядоченности больше 100% !\n";
                }
            }

            if ( errorText != "")
            {
                throw new InvalidParameterssExeption(errorText);
            }
        }
        private void chooseGenerateType(int size, int percent)
        {
            BaseList.Clear();

            string currentBtn = "";

            if (UnorderedListCheck.Checked)
                currentBtn = "UnorderedListCheck";
            else if (OrderedListCheck.Checked)
                currentBtn = "OrderedListCheck";
            else if (r_OrderedListCheck.Checked)
                currentBtn = "r_OrderedListCheck";
            else if (PartlyOrderedListCheck.Checked)
                currentBtn = "PartlyOrderedListCheck";

            switch (currentBtn)
            {
                case "UnorderedListCheck":
                    BaseList.Generate_Unordered(size);
                    break;

                case "OrderedListCheck":
                    BaseList.Generate_Ordered(size);
                    break;

                case "r_OrderedListCheck":
                    BaseList.Generate_rOrdered(size);
                    break;

                case "PartlyOrderedListCheck":
                    BaseList.Generate_PartlyOrdered(size,percent);
                    break;
            }
        }

        private void ClearGraphics()
        {
            for (int i = 0; i < 3; i++)
            {
                ResultGraphics.Series[i].Points.Clear();
            }
        }

        private void FillTable(int size)
        {
            for (int i = 1; i <= 10; i++)
            {
                int portion = (size * i) / 10;

                ListShell = BaseList.Clone();
                Stopwatch timer1 = Stopwatch.StartNew();
                ListShell.ShellSort(portion);
                timer1.Stop();
                ResultTable.Rows[0].Cells[i].Value = timer1.ElapsedMilliseconds;

                ListHeap = BaseList.Clone();
                Stopwatch timer2 = Stopwatch.StartNew();
                ListHeap.HeapSort(portion);
                timer2.Stop();
                ResultTable.Rows[1].Cells[i].Value = timer2.ElapsedMilliseconds;

                ListCount = BaseList.Clone();
                Stopwatch timer3 = Stopwatch.StartNew();
                ListCount.CountSort(portion);
                timer3.Stop();
                ResultTable.Rows[2].Cells[i].Value = timer3.ElapsedMilliseconds;
            }
        }

        private void FillGraphics()
        {
            for (int i = 0; i < 3; i++)
            {
                ResultGraphics.Series[i].Points.AddXY(0, 0);
                for (int j = 1; j <= 10; j++)
                {
                    double xValue = j / 10.0;
                    double yValue = Convert.ToDouble(ResultTable.Rows[i].Cells[j].Value);
                    ResultGraphics.Series[i].Points.AddXY(xValue, yValue);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Exception_outOfList()
        {
            ErrorLabel.Text = "Выход за границы списка";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
