using System;
using NUnit.Framework;
using MySampleWinApp;

namespace WinAppUnitTest
{
    [TestFixture]
    public class TestSampleApp
    {
        [Test]
        public void CalulateLogicTC1_Input2And5_14()
        {
            Form1 frm = new Form1();
            var result = frm.CalulateLogicTC1(3, 5);

            Assert.That(result,Is.EqualTo(14));
        }

        [Test]
        public void CalulateLogicTC2_Input2And5_12()
        {
            Form1 frm = new Form1();
            var result = frm.CalulateLogicTC2(2, 5);
            Assert.That(result, Is.EqualTo(12));
        }
    }
}
