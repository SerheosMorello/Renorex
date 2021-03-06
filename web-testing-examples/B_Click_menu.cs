﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace web_testing_examples
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_Click_menu recording.
    /// </summary>
    [TestModule("2cf9e796-d548-4cee-aef1-f1c04f6c053f", ModuleType.Recording, 1)]
    public partial class B_Click_menu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the web_testing_examplesRepository repository.
        /// </summary>
        public static web_testing_examplesRepository repo = web_testing_examplesRepository.Instance;

        static B_Click_menu instance = new B_Click_menu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_Click_menu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_Click_menu Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexTestPage.Menu1' at 24;13.", repo.RanorexTestPage.Menu1Info, new RecordItemIndex(0));
            repo.RanorexTestPage.Menu1.Click("24;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexTestPage.Subitem2' at 36;9.", repo.RanorexTestPage.Subitem2Info, new RecordItemIndex(1));
            repo.RanorexTestPage.Subitem2.Click("36;9");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
