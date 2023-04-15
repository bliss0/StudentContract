using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Kursovaya
{
    public partial class FormStudentContract : Form
    {
        String cipher;
        String companyAdress;
        String companyEmail;
        String INN;
        String KPP;
        String BIK;
        String ORGN;
        String OKTMO;
        String KaznSchet;

        public FormStudentContract()
        {
            InitializeComponent();

            ReloadTable();

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

            MySqlCommand command = new MySqlCommand("SELECT student.FIO, student.DateOfBirth, personaldata.Series, personaldata.Number, personaldata.WhoAndWhen, personaldata.Adress, groups.Cipher FROM `student` JOIN `personaldata` ON student.PersonalDataId = personaldata.PersonalDataId JOIN `groups` ON student.GroupId = groups.GroupId WHERE `StudentId` = (SELECT `StudentId` FROM `contract` WHERE `ContractId` = @contractId);", db.GetConnection());// запрос

            command.Parameters.Add("@contractId", MySqlDbType.VarChar).Value = requestBox.Text;

            adapter.SelectCommand = command;// установка адаптера на новый запрос
            adapter.Fill(table);// заполнение таблицы

            DataRow row = table.Rows[0];
            String FIO = row["FIO"].ToString();
            var ListFio = FIO.Split(' ');
            nameBox.Text = ListFio[1];
            surnameBox.Text = ListFio[0];
            secondSurnameBox.Text = ListFio[2];
            dateOfBirth.Text = row["DateOfBirth"].ToString().Substring(0,10);
            series.Text = row["Series"].ToString();
            number.Text= row["Number"].ToString();
            whoAndWhenTextBox.Text = row["WhoAndWhen"].ToString();
            adressBox.Text = row["Adress"].ToString();
            cipher = row["Cipher"].ToString();


        }
        
        private void getCompanies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=91.211.52.148;port=3356;user=developer;password=SgmZ9mZ2LcVEJS8w;database=db_develop");

            MySqlCommand command = new MySqlCommand("SELECT CompanyName, Email FROM company WHERE CompanyId = (SELECT CompanyId FROM vacancy WHERE VacancyId = (SELECT VacancyId FROM contract WHERE ContractId = @contractId));", db.GetConnection());

            command.Parameters.Add("@contractId", MySqlDbType.VarChar).Value = requestBox.Text;

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            DataRow row = table.Rows[0];
                companiesBox.Text=row[0].ToString();
                companyEmail = row[1].ToString();
                

        }

        private void getVacancies()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=91.211.52.148;port=3356;user=developer;password=SgmZ9mZ2LcVEJS8w;database=db_develop");

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
            FileInfo fileInfo = new FileInfo(@"example.docx");

            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ @"\Ученические_договоры\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


            var items = new Dictionary<string, string>
            {
                {"$companyName", companiesBox.Text},
                {"$FIO",surnameBox.Text+" "+nameBox.Text+" "+secondSurnameBox.Text },
                {"$dateOfBirth", dateOfBirth.Text},
                {"$series",series.Text },
                {"$number",number.Text },
                {"$whoAndWhen",whoAndWhenTextBox.Text },
                {"$cipher",cipher },
                {"$studentAdress",adressBox.Text},
                {"$companyAdress",companyAdress},
                {"$INN",INN},
                {"$KPP",KPP},
                {"$BIK",BIK},
                {"$ORGN",ORGN},
                {"$OKTMO",OKTMO},
                {"$kazhSchet",KaznSchet},
                {"$initials", surnameBox.Text+' '+nameBox.Text.Substring(0,1)+'.'+secondSurnameBox.Text.Substring(0,1)+'.'}

            };
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
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
                        ReplaceWith: missing, Replace: replace);
                }
                Object newFileName = Path.Combine(path, surnameBox.Text + '_' + nameBox.Text +'_'+DateTime.Now.ToString("yyyyMMdd")+ ".docx");
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            try
            {
                SendEmailAsync(Path.Combine(path, surnameBox.Text + '_' + nameBox.Text + '_' + DateTime.Now.ToString("yyyyMMdd") + ".docx"), companyEmail, companiesBox.Text).GetAwaiter();


                DB db = new DB();

                DataTable table = new DataTable();// таблица с данными

                MySqlDataAdapter adapter = new MySqlDataAdapter();// адаптер данных

                MySqlCommand command = new MySqlCommand("UPDATE `contract` SET `Status`=@status,`File`=@file,`DateOfForming`=@date WHERE `ContractId`=@contractId", db.GetConnection());// запрос

                byte[] rawData = File.ReadAllBytes(Path.Combine(path, surnameBox.Text + '_' + nameBox.Text + '_' + DateTime.Now.ToString("yyyyMMdd") + ".docx").ToString());


                command.Parameters.Add("@contractId", MySqlDbType.VarChar).Value = requestBox.Text;
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Запрос отправлен".ToString();
                command.Parameters.Add("@file", MySqlDbType.Blob, rawData.Length).Value = rawData;
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd");


                db.openConnection();// открываем подключение к БД

                if (command.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Договор был сформирован и отправлен на почту предприятия");

                }
                else
                    MessageBox.Show("Ошибка формирования договора");
                db.closeConnection();


                ReloadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }

        }

        private void preViewButton_Click(object sender, EventArgs e)
        {

            FileInfo fileInfo = new FileInfo(@"example.docx");

            var items = new Dictionary<string, string>
            {
                {"$companyName", companiesBox.Text},
                {"$FIO",surnameBox.Text+" "+nameBox.Text+" "+secondSurnameBox.Text },
                {"$dateOfBirth", dateOfBirth.Text},
                {"$series",series.Text },
                {"$number",number.Text },
                {"$whoAndWhen",whoAndWhenTextBox.Text },
                {"$cipher",cipher },
                {"$companyAdress",companyAdress},
                {"$studentAdress",adressBox.Text},
                {"$INN",INN},
                {"$KPP",KPP},
                {"$BIK",BIK},
                {"$ORGN",ORGN},
                {"$OKTMO",OKTMO},
                {"$kazhSchet",KaznSchet},
                {"$initials",surnameBox.Text+' '+nameBox.Text.Substring(0,1)+'.'+secondSurnameBox.Text.Substring(0,1)+'.'}


            };
            Word.Application app=null;
            try
            {
                app = new Word.Application();
                app.Visible = true;
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
                //Object newFileName = Path.Combine(path, surnameBox.Text + '_' + nameBox.Text + '_' + DateTime.Now.ToString("yyyyMMdd") + ".docx");

                //app.ActiveDocument.SaveAs2(newFileName);
                //app.ActiveDocument.Close();
                //app.Quit();
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }


        }

        private void requestBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInfoAboutRequest();
            GetInfoAboutCompany();

        }

        private static async Task SendEmailAsync(Object path, String companyEmail, String companyName)
        { 
            MailAddress from = new MailAddress("andrej.kozhan00@mail.ru", "Andrey");
            MailAddress to = new MailAddress(companyEmail);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Ученический договор студента";
            m.Body = $"Добрый день, уважаемые {companyName}! Прикрепляем ученический договор студента для рассмотрения Вами." +
                $"В случае заинтересованности просьба прислать ответное письмо на этот адрес.";
            m.Attachments.Add(new Attachment(path.ToString()));
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("andrej.kozhan00@mail.ru", "HAGYJWiuccGUX2BLnmth");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
            //MessageBox.Show($"Письмо отправлено ({m.Subject})");
        }

        public void GetInfoAboutCompany()
        {
            DB db = new DB();// класс БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlConnection connection = new MySqlConnection("server=91.211.52.148;port=3356;user=developer;password=SgmZ9mZ2LcVEJS8w;database=db_develop");

            MySqlCommand command = new MySqlCommand("SELECT Adress,INN,KPP,BIK,ORGN,OKTMO,KaznSchet FROM company WHERE CompanyName = @companyName", db.GetConnection());

            command.Parameters.Add("@companyName", MySqlDbType.VarChar).Value = companiesBox.Text;

            adapter.SelectCommand = command;// выполение запроса

            adapter.Fill(table);

            DataRow row = table.Rows[0];
            companyAdress= row[0].ToString();
            INN= row[1].ToString();
            KPP= row[2].ToString();
            BIK = row[3].ToString();
            ORGN = row[4].ToString();
            OKTMO = row[5].ToString();
            KaznSchet = row[6].ToString();

        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void ReloadTable()
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            secondSurnameBox.Text = "";
            dateOfBirth.Text = "";
            series.Text = "";
            number.Text = "";
            whoAndWhenTextBox.Text = "";
            adressBox.Text = "";
            requestBox.Text = "";
            companiesBox.Text = "";
            vacanciesBox.Text = "";
            requerementsBox.Text = "";
            competenciesBox.Text = "";


            MySqlConnection connection = new MySqlConnection("server=91.211.52.148;port=3356;user=developer;password=SgmZ9mZ2LcVEJS8w;database=db_develop");
            try
            {
                connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT contract.ContractId, student.FIO, student.DateOfBirth, vacancy.VacancyId, vacancy.VacancyName, contract.DateOfRequest, contract.Status FROM contract JOIN student ON contract.StudentId = student.StudentId join vacancy on contract.VacancyId = vacancy.VacancyId WHERE contract.Status = 'Запрос сформирован' ORDER BY contract.ContractId ASC;", connection);
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

        private void FormStudentContract_Load(object sender, EventArgs e)
        {

        }
    }
}
