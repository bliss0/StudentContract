using MySql.Data.MySqlClient;
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
using Word = Microsoft.Office.Interop.Word;

namespace Kursovaya
{
    public partial class FormStudentContract : Form
    {
        String id;
        public FormStudentContract(String accountId)
        {
            InitializeComponent();
            id = accountId;
            GetInfoAboutUser();
            getCompanies();
        }

        public void GetInfoAboutUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `AccountId` = @accountId", db.GetConnection());// запрос

            command.Parameters.Add("@accountId", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;// установка адаптера на новый запрос
            adapter.Fill(table);// заполнение таблицы

            DataRow row = table.Rows[0];
            String FIO = row["FIO"].ToString();
            var ListFio = FIO.Split(' ');
            nameBox.Text = ListFio[0];
            surnameBox.Text = ListFio[1];
            secondSurnameBox.Text = ListFio[2];
            dateOfBirth.Text = row["DateOfBirth"].ToString().Substring(0,10);

        }
        
        private void getCompanies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT CompanyName FROM company;", db.GetConnection());

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                companiesBox.Items.Add(row[0].ToString());// добавление всех вариантов удаления из БД
            }

        }

        private void getVacancies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT VacancyName FROM vacancy WHERE CompanyId = (SELECT CompanyId FROM company WHERE CompanyName	= @companyId) ;", db.GetConnection());

            command.Parameters.Add("@companyId", MySqlDbType.VarChar).Value = companiesBox.Text;

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                vacanciesBox.Items.Add(row[0].ToString());// добавление всех вариантов удаления из БД
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formContractButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("INSERT INTO `personaldata` (`Series`, `Number`, `WhoAndWhen`,`Adress`) VALUES (@series, @number, @whoAndWhen, @adress);" +
                    "SELECT @@identity;" +
                    "UPDATE `student` SET `PersonalDataId`=@@identity WHERE `AccountId`=@accountId", db.GetConnection());// запрос

            var seriesAndNum = seriesAndNumber.Text.Split(' ');

            command.Parameters.Add("@series", MySqlDbType.VarChar).Value = seriesAndNum[0];
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = seriesAndNum[1];
            command.Parameters.Add("@whoAndWhen", MySqlDbType.VarChar).Value = whoAndWhenTextBox.Text;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adressBox.Text;
            command.Parameters.Add("@accountId", MySqlDbType.VarChar).Value = id;

            db.openConnection();// открываем подключение к БД

            if (command.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Договор был сформирован и отправлен на почту предприятия");

            }
            else
                MessageBox.Show("Ошибка формирования договора");
            db.closeConnection();

        }

        private void companiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vacanciesBox.Items.Clear();
            getVacancies();
        }

        private void vacanciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT Competencies,Requierements FROM vacancy WHERE VacancyName = @vacancyName ;", db.GetConnection());

            command.Parameters.Add("@vacancyName", MySqlDbType.VarChar).Value = vacanciesBox.Items[vacanciesBox.SelectedIndex];

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                competenciesBox.Text = row[0].ToString();
                requerementsBox.Text = row[1].ToString();
            }

        }

        private void preViewButton_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("example.docx");

            var items = new Dictionary<string, string>
            {
                {"$companyName", companiesBox.Text},
                {"$FIO",nameBox.Text+" "+surnameBox.Text+" "+secondSurnameBox }

            };

            try
            {
                var app = new Word.Application();
                Object file = fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,Replace: replace);
                }
                Object newFileName = Path.Combine(fileInfo.DirectoryName, fileInfo.Name + "new");
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

           /* Word.Application wordapp = new Word.Application();
            Word.Document worddocument;
            wordapp.Visible = true;
            Object template = Type.Missing;
            Object newTemplate = false;
            Object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;
            //Создаем документ 1
            wordapp.Documents.Add(
           ref template, ref newTemplate, ref documentType, ref visible);
            //Меняем шаблон
            String currentDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug","");
            template = $@"{currentDirectory}\inventory\1.docx";
            MessageBox.Show(template.ToString());
            //Создаем документ 2 worddocument в данном случае создаваемый объект   E:\C#Projects\Диплом\Kursovaya\inventiory\ 
            worddocument =
            wordapp.Documents.Add(
             ref template, ref newTemplate, ref documentType, ref visible);*/


        }
    }
}
