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

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");
            try
            {
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT contract.ContractId, student.FIO, student.DateOfBirth, vacancy.VacancyId, vacancy.VacancyName, contract.DateOfRequest, contract.Status FROM contract JOIN student ON contract.StudentId = student.StudentId join vacancy on contract.VacancyId = vacancy.VacancyId WHERE contract.Status = 'Запрос сформирован';", connection);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                requests.DataSource = DATA;
                connection.Close();

                foreach (DataGridViewRow row in requests.SelectedRows)
                {
                    if (!row.IsNewRow)
                        requests.Rows.Remove(row);
                    
                }
                foreach (DataRow row in DATA.Rows)
                {
                    requestBox.Items.Add(row[0].ToString());
                    
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        public void GetInfoAboutRequest()
        {

            GetInfoAboutUser();
            getCompanies();
            getVacancies();


        }

        public void GetInfoAboutUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("SELECT student.FIO, student.DateOfBirth, personaldata.Series, personaldata.Number, personaldata.WhoAndWhen, personaldata.Adress FROM student JOIN personaldata ON student.PersonalDataId = personaldata.PersonalDataId WHERE StudentId = (SELECT StudentId FROM contract WHERE ContractId = @contractId);", db.GetConnection());// запрос

            command.Parameters.Add("@contractId", MySqlDbType.VarChar).Value = requestBox.Text;

            adapter.SelectCommand = command;// установка адаптера на новый запрос
            adapter.Fill(table);// заполнение таблицы

            DataRow row = table.Rows[0];
            String FIO = row["FIO"].ToString();
            var ListFio = FIO.Split(' ');
            nameBox.Text = ListFio[0];
            surnameBox.Text = ListFio[1];
            secondSurnameBox.Text = ListFio[2];
            dateOfBirth.Text = row["DateOfBirth"].ToString().Substring(0,10);
            series.Text = row["Series"].ToString();
            number.Text= row["Number"].ToString();
            whoAndWhenTextBox.Text = row["WhoAndWhen"].ToString();
            adressBox.Text = row["Adress"].ToString();


        }
        
        private void getCompanies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT CompanyName FROM company WHERE (SELECT CompanyId FROM vacancy WHERE VacancyId = (SELECT VacancyId FROM contract WHERE ContractId = @contractId));", db.GetConnection());

            command.Parameters.Add("@contractId", MySqlDbType.VarChar).Value = requestBox.Text;

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            DataRow row = table.Rows[0];
                companiesBox.Text=row[0].ToString();

        }

        private void getVacancies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");

            MySqlCommand command = new MySqlCommand("SELECT VacancyName, Competencies, Requierements FROM vacancy WHERE VacancyId = (SELECT VacancyId FROM contract WHERE ContractId = @contractId) ;", db.GetConnection());

            command.Parameters.Add("@contractId", MySqlDbType.VarChar).Value = requestBox.Text;

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            DataRow row = table.Rows[0];
            vacanciesBox.Text = row[0].ToString();
            competenciesBox.Text = row[1].ToString();
            requerementsBox.Text = row[2].ToString();

        }

        private void formContractButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();// таблица с данными

            MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

            MySqlCommand command = new MySqlCommand("INSERT INTO `personaldata` (`Series`, `Number`, `WhoAndWhen`,`Adress`) VALUES (@series, @number, @whoAndWhen, @adress);" +
                    "SELECT @@identity;" +
                    "UPDATE `student` SET `PersonalDataId`=@@identity WHERE `AccountId`=@accountId", db.GetConnection());// запрос

            var seriesAndNum = series.Text.Split(' ');

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

        private void requestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInfoAboutRequest();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;user=root;password=root;database=student_contract");
            try
            {
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT contract.ContractId, student.FIO, student.DateOfBirth, vacancy.VacancyId, vacancy.VacancyName, contract.DateOfRequest, contract.Status FROM contract JOIN student ON contract.StudentId = student.StudentId join vacancy on contract.VacancyId = vacancy.VacancyId WHERE contract.Status = 'Запрос сформирован';", connection);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                requests.DataSource = DATA;
                connection.Close();
                requestBox.Items.Clear();

                foreach (DataGridViewRow row in requests.SelectedRows)
                {
                    if (!row.IsNewRow)
                        requests.Rows.Remove(row);

                }
                foreach (DataRow row in DATA.Rows)
                {

                    requestBox.Items.Add(row[0].ToString());


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
