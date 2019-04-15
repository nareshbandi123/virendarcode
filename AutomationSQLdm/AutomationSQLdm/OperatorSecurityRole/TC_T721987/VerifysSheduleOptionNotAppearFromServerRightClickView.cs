/*
 * Created by Ranorex
 * User: administrator
 * Date: 4/9/2019
 * Time: 2:19 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace AutomationSQLdm.OperatorSecurityRole.TC_T721987
{
    /// <summary>
    /// Description of VerifysSheduleOptionNotAppearFromServerRightClickView.
    /// </summary>
    [TestModule("7C5115A7-E07E-481F-BEEC-6CF026A05A92", ModuleType.UserCode, 1)]
    public class VerifysSheduleOptionNotAppearFromServerRightClickView : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifysSheduleOptionNotAppearFromServerRightClickView()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
