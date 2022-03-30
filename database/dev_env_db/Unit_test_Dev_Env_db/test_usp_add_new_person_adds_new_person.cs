using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Unit_test_Dev_Env_db
{
    [TestClass()]
    public class test_usp_add_new_person_adds_new_person : SqlDatabaseTestClass
    {

        public test_usp_add_new_person_adds_new_person()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction docker_usp_add_new_personTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction docker_usp_add_new_personTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction docker_usp_add_new_personTest_PosttestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test_usp_add_new_person_adds_new_person));
            this.docker_usp_add_new_personTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            docker_usp_add_new_personTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            docker_usp_add_new_personTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            docker_usp_add_new_personTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // docker_usp_add_new_personTestData
            // 
            this.docker_usp_add_new_personTestData.PosttestAction = docker_usp_add_new_personTest_PosttestAction;
            this.docker_usp_add_new_personTestData.PretestAction = docker_usp_add_new_personTest_PretestAction;
            this.docker_usp_add_new_personTestData.TestAction = docker_usp_add_new_personTest_TestAction;
            // 
            // docker_usp_add_new_personTest_TestAction
            // 
            docker_usp_add_new_personTest_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(docker_usp_add_new_personTest_TestAction, "docker_usp_add_new_personTest_TestAction");
            // 
            // docker_usp_add_new_personTest_PretestAction
            // 
            resources.ApplyResources(docker_usp_add_new_personTest_PretestAction, "docker_usp_add_new_personTest_PretestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // docker_usp_add_new_personTest_PosttestAction
            // 
            resources.ApplyResources(docker_usp_add_new_personTest_PosttestAction, "docker_usp_add_new_personTest_PosttestAction");
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void docker_usp_add_new_personTest()
        {
            SqlDatabaseTestActions testActions = this.docker_usp_add_new_personTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions docker_usp_add_new_personTestData;
    }
}
