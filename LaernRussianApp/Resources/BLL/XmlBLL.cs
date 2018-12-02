using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AppLearnRussian.Resources.Model;
using System.Data;
using System.IO;
namespace AppLearnRussian.Resources.BLL
{
    class XmlBLL
    {

        private static string filenameXmlQuestion = @"Data\DataBase\XmlQuestions.xml";
        private static string filenameXmlUserName = @"Data\DataBase\XmlUserName.xml";
        private static string filenameXmlGrammar = @"Data\DataBase\XmlGrammar.xml";
        private static string filenameXmlGameLearnNewWords = @"Data\DataBase\XmlGameLearnNewWords.xml";
        private static string filenameXmlSysteminfo = @"Data\DataBase\XmlSystem.xml";
        XDocument XmlDocument;
        #region Data Questions
        // Lấy Dữ liệu từ XmlQuestions
        public List<OjQuestion> DataQuestions()
        {

            XmlDocument = XDocument.Load(filenameXmlQuestion);

            //truy vẫn linq
            List<OjQuestion> TableQuestion = (from q in XmlDocument.Element("Questions").Elements("Question")
                                                 select new OjQuestion
                                                 {
                                                     Number1 = int.Parse(q.Element("Number").Value),
                                                     Lever1 = q.Element("Lever").Value,
                                                     Question1 = q.Element("ContentQuestion").Value,
                                                     AnswerTrue1 = q.Element("AnswerTrue").Value,
                                                     A1 = q.Element("A").Value,
                                                     B1 = q.Element("B").Value,
                                                     C1 = q.Element("C").Value,
                                                     D1 = q.Element("D").Value,
                                                     Grammar1 = q.Element("Grammar").Value
                                                 }).ToList();
            return TableQuestion;
        }

        public List<OjQuestion> DataQuestionsByLever(String Lever)
        {

            XmlDocument = XDocument.Load(filenameXmlQuestion);

            //truy vẫn linq
            List<OjQuestion> TableQuestion = (from q in XmlDocument.Element("Questions").Elements("Question")
                                              where(q.Element("Lever").Value.ToString() == Lever)
                                              select new OjQuestion
                                              {
                                                  Number1 = int.Parse(q.Element("Number").Value),
                                                  Lever1 = q.Element("Lever").Value,
                                                  Question1 = q.Element("ContentQuestion").Value,
                                                  AnswerTrue1 = q.Element("AnswerTrue").Value,
                                                  A1 = q.Element("A").Value,
                                                  B1 = q.Element("B").Value,
                                                  C1 = q.Element("C").Value,
                                                  D1 = q.Element("D").Value,
                                                  Grammar1 = q.Element("Grammar").Value
                                              }).ToList();
            return TableQuestion;
        }
        // Insert  Dữ liệu vào XmlQuestions
        public void InsertQuestion(OjQuestion tablequestion)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlQuestion);
                XElement NewQuestion = new XElement("Question", new XElement("Number", tablequestion.Number1.ToString()),
                                         new XElement("Lever", tablequestion.Lever1),
                                         new XElement("ContentQuestion", tablequestion.Question1),
                                         new XElement("AnswerTrue", tablequestion.AnswerTrue1),
                                         new XElement("A", tablequestion.A1),
                                         new XElement("B", tablequestion.B1),
                                         new XElement("C", tablequestion.C1),
                                         new XElement("D", tablequestion.D1),
                                         new XElement("Grammar", tablequestion.Grammar1));
                XmlDocument.Root.Add(NewQuestion);

                XmlDocument.Save(filenameXmlQuestion);
            }
            catch (Exception)
            {

            }

        }
        // UpDate Dữ liệu vào XmlQuestions
        public void UpdateQuestion(OjQuestion tableQuestion)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlQuestion);
                IEnumerable<XElement> old = (from q in XmlDocument.Element("Questions").Elements("Question") where (q.Element("Number").Value.ToString() == tableQuestion.Number1.ToString()) select q);

                foreach (XElement item in old)
                {
                    item.SetElementValue("ContentQuestion", tableQuestion.Question1);
                    item.SetElementValue("Lever", tableQuestion.Lever1);
                    item.SetElementValue("AnswerTrue", tableQuestion.AnswerTrue1);
                    item.SetElementValue("B", tableQuestion.B1);
                    item.SetElementValue("C", tableQuestion.C1);
                    item.SetElementValue("D", tableQuestion.D1);
                    item.SetElementValue("Grammar", tableQuestion.Grammar1);
                }
                XmlDocument.Save(filenameXmlQuestion);
            }
            catch (Exception ) { }

        }

        // Search dữ liệu từ XmlQuestions
        public OjQuestion Search(int Number)
        {
            XmlDocument = XDocument.Load(filenameXmlQuestion);
            List<OjQuestion> tableQuestion = (from q in XmlDocument.Element("Questions").Elements("Question")
                                                 where (q.Element("Number").Value.ToString() == Number.ToString())
                                                 select new OjQuestion
                                                 {
                                                     Lever1 = q.Element("Lever").Value,
                                                     Question1 = q.Element("ContentQuestion").Value,
                                                     AnswerTrue1 = q.Element("AnswerTrue").Value,
                                                     A1 = q.Element("A").Value,
                                                     B1 = q.Element("B").Value,
                                                     C1 = q.Element("C").Value,
                                                     D1 = q.Element("D").Value,
                                                     Grammar1 = q.Element("Grammar").Value
                                                 }).ToList();
            return tableQuestion[0];

        }

        // Lấy bảng Grammar từ XmlGrammar
        public List<OjGrammar> DataGrammars()
        {
            XmlDocument = XDocument.Load(filenameXmlGrammar);

            List<OjGrammar> tableGrammars = (from q in XmlDocument.Element("Grammars").Elements("Grammar")
                                                select new OjGrammar
                                                {
                                                    Grammar1 = q.Element("GrammarName").Value,
                                                    Content1 = q.Element("CONTENT").Value

                                                }).ToList();
            return tableGrammars;
        }
        #endregion
        #region Login SignUp
        public void SignUp(User user)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlUserName);
                XElement User = new XElement("User", new XElement("UserName", user.UserName1),
                                    new XElement("Email", user.Email1),
                                    new XElement("Pass", Md5hasd.ToMD5(user.Pass1)),
                                    new XElement("DateSignUp", user.DateSignUp1.ToString()),
                                    new XElement("FileImage", user.FileImage1),
                                    new XElement("Lever", user.Lever1),
                                    new XElement("Admin", user.Admin1.ToString()),
                                    new XElement("Point", user.Point1.ToString()),
                                    new XElement("Remember", "false"));
                XmlDocument.Root.Add(User);
                XmlDocument.Save(filenameXmlUserName);
            }

            catch (Exception)
            {

            }
        }
        public bool CheckExistUser(string UserName)
        {
            XmlDocument = XDocument.Load(filenameXmlUserName);
            bool check = false;
            try
            {
                List<string> a = (from q in XmlDocument.Element("Users").Elements("User") where (q.Element("UserName").Value.ToString() == UserName) select q.Element("UserName").Value).ToList();
                if (a.Count != 0)
                    check = true;
            }

            catch (Exception )
            {
            }
            return check;
        }
       
        /// <summary>
        /// CheckRememberUser
        /// </summary>
        /// R

       public void ForgetUser( User oldUser )
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlUserName);
                IEnumerable<XElement> User = (from q in XmlDocument.Element("Users").Elements("User")
                                              where (q.Element("UserName").Value.ToString() == oldUser.UserName1)
                                              select q);
                foreach (XElement item in User)
                    item.SetElementValue("Remember", "false");

                XmlDocument.Save(filenameXmlUserName);
            }
            catch(Exception ) { }
           
        }

        public void RememberUser(User user)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlUserName);
                IEnumerable<XElement> User = (from q in XmlDocument.Element("Users").Elements("User")
                                              where (q.Element("UserName").Value.ToString() == user.UserName1)
                                              select q);
                foreach (XElement item in User)
                    item.SetElementValue("Remember", "true");

                XmlDocument.Save(filenameXmlUserName);
            }
            catch (Exception ) { }

        }
        public User CheckRemember()
        {
            List<User> Users = null;
          
               
                XmlDocument = XDocument.Load(filenameXmlUserName);
                Users = (from q in XmlDocument.Element("Users").Elements("User")
                                    where (q.Element("Remember").Value.ToString() == "true")
                                    select new User
                                    {
                                        UserName1 = q.Element("UserName").Value,
                                        Pass1 = q.Element("Pass").Value,
                                        DateSignUp1 = DateTime.Parse(q.Element("DateSignUp").Value),
                                        FileImage1 = q.Element("FileImage").Value,
                                        Lever1 = q.Element("Lever").Value,
                                        Admin1 = bool.Parse(q.Element("Admin").Value),
                                        Point1 = int.Parse(q.Element("Point").Value)
                                    }).ToList();
           
          
            return  Users[0]  ;
        }
        /// <summary>
        /// login
        /// </summary>
       
        public User Login(string UserName, string Pass)
        {
            XmlDocument = XDocument.Load(filenameXmlUserName);
            List<User> Users = (from q in XmlDocument.Element("Users").Elements("User")
                                                  where (q.Element("UserName").Value.ToString() == UserName && q.Element("Pass").Value.ToString() == Md5hasd.ToMD5(Pass) )
                                                  select new User
                                                  {
                                                      UserName1 = q.Element("UserName").Value,
                                                      Pass1 = q.Element("Pass").Value,
                                                      DateSignUp1 = DateTime.Parse(q.Element("DateSignUp").Value),
                                                      FileImage1 = q.Element("FileImage").Value,
                                                      Lever1 = q.Element("Lever").Value,
                                                      Admin1 = bool.Parse(q.Element("Admin").Value),
                                                       Point1 = int.Parse(q.Element("Point").Value)
                                                  }).ToList();
            return Users[0];
        }

        public void Save_point(string UserName, int Point)
        {
            XmlDocument = XDocument.Load(filenameXmlUserName);
            XElement xElement = (from q in XmlDocument.Element("Users").Elements("User")
                                where (q.Element("UserName").Value.ToString() == UserName)
                                select q).SingleOrDefault();
            xElement.SetElementValue("Point",Point.ToString());
            XmlDocument.Save(filenameXmlUserName);
        }
        #endregion
     
        #region Data New words
        public void InsertWords(OjWord ojWord)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlGameLearnNewWords);

                XElement Word = new XElement("OjWord",new XAttribute("ID",ojWord.ID1),
                                                       new XElement("Word", ojWord.Word1),
                                                       new XElement("FileNameWord", ojWord.FileNameword1),
                                                       new XElement("LocationStress", ojWord.LocationStress1.ToString()),
                                                       new XElement("Purport", ojWord.Purport1),
                                                       new XElement("Topic", ojWord.Topic1));
                XmlDocument.Root.Add(Word);
                XmlDocument.Save(filenameXmlGameLearnNewWords);
            }
            catch(Exception ) { }
        }

        public List<OjWord> ListWords(string Topic)
        {
            XmlDocument = XDocument.Load(filenameXmlGameLearnNewWords);

            List<OjWord> listWords = (from q in XmlDocument.Element("Words").Elements("OjWord")
                                      where (q.Element("Topic").Value ==Topic)
                                       select new OjWord
                                       {
                                           ID1= q.Attribute("ID").Value.ToString(),
                                           Word1 = q.Element("Word").Value.ToString(),
                                           FileNameword1 = q.Element("FileNameWord").Value.ToString(),
                                           LocationStress1 = Int16.Parse(q.Element("LocationStress").Value),
                                           Purport1 = q.Element("Purport").Value.ToString(),
                                           Topic1 = q.Element("Topic").Value.ToString()
                                       }).ToList();
            return listWords;

        }
        public void UpdateWord(string ID, OjWord newojWord)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlGameLearnNewWords);
                IEnumerable<XElement> oldElement = from q in XmlDocument.Element("Words").Elements("OjWord")
                                                   where (q.Attribute("ID").Value.ToString() == ID)
                                                   select q;
                foreach (XElement item in oldElement)
                {
                    item.SetElementValue("Word", newojWord.Word1);
                    item.SetElementValue("FileNameWord", newojWord.FileNameword1);
                    item.SetElementValue("LocationStress", newojWord.LocationStress1);
                    item.SetElementValue("Purport", newojWord.Purport1);
                    item.SetElementValue("Topic", newojWord.Topic1);

                }

                XmlDocument.Save(filenameXmlGameLearnNewWords);
            }
            catch(Exception ) {}
        }

        public void DeleteWord (string ID)
        {
            try
            {
                XmlDocument = XDocument.Load(filenameXmlGameLearnNewWords);
                IEnumerable<XElement> oldElement = from q in XmlDocument.Element("Words").Elements("OjWord")
                                                   where (q.Attribute("ID").Value.ToString() == ID)
                                                   select q;
                foreach (XElement item in oldElement)
                {
                    item.Remove();
                }
                XmlDocument.Save(filenameXmlGameLearnNewWords);
            }
            catch (Exception ) { }
        }
        #endregion

        public void SetSysteminfo (string FileName, bool Status)
        {
            XmlDocument = XDocument.Load(filenameXmlSysteminfo);
            XElement xElements = XmlDocument.Element("Systeminfo");
            xElements.SetElementValue("FileNameSound", FileName);
            xElements.SetElementValue("Status", Status.ToString());
            XmlDocument.Save(filenameXmlSysteminfo);
        }

        public void GetSysteminfo()
        {
            XmlDocument = XDocument.Load(filenameXmlSysteminfo);
            XElement xElements = XmlDocument.Element("Systeminfo");
            Systeminfo.FileNameSound = xElements.Element("FileNameSound").Value;
            Systeminfo.Status = bool.Parse(xElements.Element("Status").Value);
        }
    }

}
