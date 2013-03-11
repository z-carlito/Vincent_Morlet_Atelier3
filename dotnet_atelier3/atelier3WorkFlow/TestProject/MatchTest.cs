using atelierTroisLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest()
        {
            Match target = new Match();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            Club actual;
            actual = target.Away;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour AwayForfeit
        ///</summary>
        [TestMethod()]
        public void AwayForfeitTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.AwayForfeit;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.AwayGoals;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.Draw;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            Club actual;
            actual = target.Home;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour HomeForfeit
        ///</summary>
        [TestMethod()]
        public void HomeForfeitTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            bool actual;
            actual = target.HomeForfeit;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Match target = new Match(); // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.HomeGoals;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
