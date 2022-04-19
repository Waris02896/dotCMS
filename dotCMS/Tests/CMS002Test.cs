using dotCMS.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotCMS.Tests
{
    public class CMS002Test
    {
        LoginSteps loginSteps = new LoginSteps();
        CMS002Steps cMS001Steps = new CMS002Steps();

        [SetUp]
        public void SetupTest()
        {
            BaseFunctions.Start();
            loginSteps.LoginStep();
            Thread.Sleep(4000);
        }

        [TearDown]
        public void TearDownTest()
        {
            BaseFunctions.End();
        }

        [Test]
        public void VerifyThatFiltersWorkingProperly()
        {
            cMS001Steps.ClickContectButton();
            cMS001Steps.ChangeTypeToPersona();
        }
    }
}
