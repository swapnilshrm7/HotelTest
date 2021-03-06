﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HotelManagementSystem.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Add hotel")]
    public partial class AddHotelFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add hotel", "\tIn order to simulate hotel management system\r\n\tAs api consumer\r\n\tI want to be ab" +
                    "le to add hotel,get hotel details and book hotel", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User adds hotel in database by providing valid inputs")]
        [NUnit.Framework.CategoryAttribute("AddHotel")]
        [NUnit.Framework.TestCaseAttribute("4", "hotel4", null)]
        [NUnit.Framework.TestCaseAttribute("5", "hotel5", null)]
        [NUnit.Framework.TestCaseAttribute("6", "hotel6", null)]
        public virtual void UserAddsHotelInDatabaseByProvidingValidInputs(string id, string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddHotel"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User adds hotel in database by providing valid inputs", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("User provided valid Id \'{0}\'  and \'{1}\' for hotel", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("User has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("User calls AddHotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("Hotel with name \'{0}\' should be present in the response", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User adds a hotel and checks for the presence of that hotel by ID as an input")]
        [NUnit.Framework.CategoryAttribute("GetHotelById")]
        [NUnit.Framework.TestCaseAttribute("1", "hotel1", null)]
        [NUnit.Framework.TestCaseAttribute("2", "hotel2", null)]
        [NUnit.Framework.TestCaseAttribute("3", "hotel3", null)]
        public virtual void UserAddsAHotelAndChecksForThePresenceOfThatHotelByIDAsAnInput(string id, string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GetHotelById"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User adds a hotel and checks for the presence of that hotel by ID as an input", @__tags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given(string.Format("User provided valid Id \'{0}\'  and \'{1}\' for hotel", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And("User has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User calls AddHotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And(string.Format("User provides Id \'{0}\' of hotel to be searched", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("User calls GetHotelByID api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then(string.Format("The result of the search should be \'{0}\'", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User adds multiple hotels and checks for the presence of those hotels by ID as an" +
            " input")]
        [NUnit.Framework.CategoryAttribute("AddAndGetMultipleHotels")]
        [NUnit.Framework.TestCaseAttribute("7", "hotel7", "8", "hotel8", "9", "hotel9", null)]
        public virtual void UserAddsMultipleHotelsAndChecksForThePresenceOfThoseHotelsByIDAsAnInput(string id, string name, string id1, string name1, string id2, string name2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddAndGetMultipleHotels"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User adds multiple hotels and checks for the presence of those hotels by ID as an" +
                    " input", @__tags);
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
 testRunner.Given(string.Format("User provided valid Id \'{0}\'  and \'{1}\' for hotel", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.And("User has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("User calls AddHotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And(string.Format("User provided valid Id \'{0}\'  and \'{1}\' for hotel", id1, name1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("User calls AddHotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And(string.Format("User provided valid Id \'{0}\'  and \'{1}\' for hotel", id2, name2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User calls AddHotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("User calls GetAllHotels api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("The result of the call should contain all the hotels should be \'present\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
