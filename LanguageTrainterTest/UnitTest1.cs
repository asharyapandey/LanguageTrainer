using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using LanguageTrainer.BLL;

namespace LanguageTrainterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            LoginBLL bll = new LoginBLL();
            bool actualResult, expectedResult;
            bll._username = "ashray";//Test Data
            bll._password = "1234"; //Test Data
            DataTable dtCheck = bll.CheckLogin();
            expectedResult = true;
            if (dtCheck.Rows.Count>0)
            {
                actualResult = true;
            }
            else
            {
                actualResult = false;
            }

            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]

        public void TestOpponent()
        {
            //name of opponents is retrived
            ChooseOpponentBLL bll = new ChooseOpponentBLL();
            bool actualResult, expectedResult;
            DataTable dtCheck = bll.RetriveUsers();
            expectedResult = true;
            if (dtCheck.Rows.Count > 0)
            {
                actualResult = true;
            }
            else
            {
                actualResult = false;
            }

            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestWord()
        {
            //checking if the word is retrived
            GameBLL bll = new GameBLL();
            bool actualResult, expectedResult;
            bll._wordSet= "a";
            DataTable dtCheck = bll.RetriveWords();
            expectedResult = true;
            if (dtCheck.Rows.Count > 0)
            {
                actualResult = true;
            }
            else
            {
                actualResult = false;
            }

            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestAddUsers()
        {
            SignupBLL bll = new SignupBLL();
            bool actualResult, expectedResult;
            bll._fName = "admin";
            bll._lName = "admin";
            bll._password = "admin";
            bll._username = "admin";
            expectedResult = true;
            actualResult = bll.InsertUsers();
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestAddWords()
        {
            AddWordsBLL bll = new AddWordsBLL();
            bool actualResult, expectedResult;
            bll._word = "Dream";
            bll._translation = "सपना";
            bll._wordSet = "a";
            expectedResult = true;
            actualResult = bll.InsertWords();
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
