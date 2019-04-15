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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AutomationSQLdm.Grooming_Modifications
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the GroomingRepo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("16a56f01-8f73-4e50-8864-86e658161df7")]
    public partial class GroomingRepo : RepoGenBaseFolder
    {
        static GroomingRepo instance = new GroomingRepo();
        GroomingRepoFolders.ApplicationAppFolder _application;
        GroomingRepoFolders.GroomingOptionWindowAppFolder _groomingoptionwindow;

        /// <summary>
        /// Gets the singleton class instance representing the GroomingRepo element repository.
        /// </summary>
        [RepositoryFolder("16a56f01-8f73-4e50-8864-86e658161df7")]
        public static GroomingRepo Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public GroomingRepo() 
            : base("GroomingRepo", "/", null, 0, false, "16a56f01-8f73-4e50-8864-86e658161df7", ".\\RepositoryImages\\GroomingRepo16a56f01.rximgres")
        {
            _application = new GroomingRepoFolders.ApplicationAppFolder(this);
            _groomingoptionwindow = new GroomingRepoFolders.GroomingOptionWindowAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("16a56f01-8f73-4e50-8864-86e658161df7")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Application folder.
        /// </summary>
        [RepositoryFolder("6541cc49-166c-4209-a267-3f050f9794f8")]
        public virtual GroomingRepoFolders.ApplicationAppFolder Application
        {
            get { return _application; }
        }

        /// <summary>
        /// The GroomingOptionWindow folder.
        /// </summary>
        [RepositoryFolder("45d6f264-a0b9-4d39-b07c-41e3680e69d5")]
        public virtual GroomingRepoFolders.GroomingOptionWindowAppFolder GroomingOptionWindow
        {
            get { return _groomingoptionwindow; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class GroomingRepoFolders
    {
        /// <summary>
        /// The ApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("6541cc49-166c-4209-a267-3f050f9794f8")]
        public partial class ApplicationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _toolsInfo;

            /// <summary>
            /// Creates a new Application  folder.
            /// </summary>
            public ApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Application", "/form[@title~'^Idera\\ SQL\\ diagnostic\\ mana']", parentFolder, 30000, null, true, "6541cc49-166c-4209-a267-3f050f9794f8", "")
            {
                _toolsInfo = new RepoItemInfo(this, "Tools", ".//list[@automationid='toolsMenu']/picture[@automationid='HeaderPresenter']/text[@caption='Tools']", 30000, null, "eb5102cb-9ffe-4187-a21a-7bfb33aeacd0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6541cc49-166c-4209-a267-3f050f9794f8")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6541cc49-166c-4209-a267-3f050f9794f8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Tools item.
            /// </summary>
            [RepositoryItem("eb5102cb-9ffe-4187-a21a-7bfb33aeacd0")]
            public virtual Ranorex.Text Tools
            {
                get
                {
                    return _toolsInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Tools item info.
            /// </summary>
            [RepositoryItemInfo("eb5102cb-9ffe-4187-a21a-7bfb33aeacd0")]
            public virtual RepoItemInfo ToolsInfo
            {
                get
                {
                    return _toolsInfo;
                }
            }
        }

        /// <summary>
        /// The GroomingOptionWindowAppFolder folder.
        /// </summary>
        [RepositoryFolder("45d6f264-a0b9-4d39-b07c-41e3680e69d5")]
        public partial class GroomingOptionWindowAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _aggregatetextboxInfo;
            RepoItemInfo _groomforecasttextboxInfo;
            RepoItemInfo _cancelbuttonInfo;
            RepoItemInfo _combineolderdataInfo;
            RepoItemInfo _aggregationincurrenttimeInfo;
            RepoItemInfo _aggregationincurrentgroomingInfo;
            RepoItemInfo _groomstandardmetrixandbaselineInfo;
            RepoItemInfo _aggregatequerydataintoInfo;
            RepoItemInfo _groominactivealertInfo;
            RepoItemInfo _groomprescriptiveanalysisInfo;
            RepoItemInfo _groomingoncedailyatInfo;
            RepoItemInfo _aggregaiononcedailyatInfo;
            RepoItemInfo _groomsessionsqueriesInfo;
            RepoItemInfo _groomchangelogInfo;

            /// <summary>
            /// Creates a new GroomingOptionWindow  folder.
            /// </summary>
            public GroomingOptionWindowAppFolder(RepoGenBaseFolder parentFolder) :
                    base("GroomingOptionWindow", "/form[@controlname='GroomingOptionsDialog']", parentFolder, 30000, null, true, "45d6f264-a0b9-4d39-b07c-41e3680e69d5", "")
            {
                _aggregatetextboxInfo = new RepoItemInfo(this, "AggregateTextbox", ".//container[@controlname='tableLayoutPanel4']/container[@controlname='auditGroomingThresholdNumericUpDown']/text[@controlname='upDownEdit' and @text='1095']", 30000, null, "bb7bc07f-fdce-435d-a9ac-c0a43ae7aa8e");
                _groomforecasttextboxInfo = new RepoItemInfo(this, "GroomForecastTextbox", ".//container[@controlname='tableLayoutPanel4']/container[@controlname='GroomForecastNumericUpDown']/text[@controlname='upDownEdit' and @text='1095']", 30000, null, "628b3592-d551-45fb-ac4c-09da6d84873f");
                _cancelbuttonInfo = new RepoItemInfo(this, "CancelButton", ".//button[@controlname='cancelButton']", 30000, null, "f32922fa-0f10-43c9-bf8b-635762c36ac8");
                _combineolderdataInfo = new RepoItemInfo(this, "CombineOlderData", ".//container[@controlname='groupBox2']/text[@controlname='label15']", 30000, null, "b11a9e64-8b5f-4df3-8bfd-9c6af34e45f8");
                _aggregationincurrenttimeInfo = new RepoItemInfo(this, "AggregationInCurrentTime", ".//container[@controlname='containerPanel']/?/?/container[@controlname='groupBox2']", 30000, null, "4535d7a1-d40a-4b9f-9e94-eff8ebb581df");
                _aggregationincurrentgroomingInfo = new RepoItemInfo(this, "AggregationInCurrentGrooming", ".//container[@controlname='containerPanel']/?/?/container[@controlname='groupBox4']", 30000, null, "0da66b40-2bde-452d-a086-997be0f58733");
                _groomstandardmetrixandbaselineInfo = new RepoItemInfo(this, "GroomStandardMetrixAndBaseline", ".//container[@controlname='tableLayoutPanel4']/container[@controlname='metricsGroomingThresholdNumericUpDown']/text[@controlname='upDownEdit']", 30000, null, "cb98d8c0-d2f4-4450-b009-3532ca0073e0");
                _aggregatequerydataintoInfo = new RepoItemInfo(this, "AggregateQueryDataInto", ".//container[@controlname='tableLayoutPanel4']/container[@controlname='aggregationThresholdNumericUpDown']/text[@controlname='upDownEdit']", 30000, null, "de5fbc57-3a2c-4f81-9e5c-abc2a430930a");
                _groominactivealertInfo = new RepoItemInfo(this, "GroomInactiveAlert", ".//container[@controlname='tableLayoutPanel4']/container[@controlname='alertsGroomingThresholdNumericUpDown']/text[@controlname='upDownEdit']", 30000, null, "3fb2ebda-cce5-4ac4-b199-394653d2665c");
                _groomprescriptiveanalysisInfo = new RepoItemInfo(this, "GroomPrescriptiveAnalysis", ".//container[@controlname='tableLayoutPanel4']/container[@controltypename='NumericUpDown' and @instance='5']/text[@controlname='upDownEdit']", 30000, null, "75d1eb55-600b-44fc-ac08-9fc009910a61");
                _groomingoncedailyatInfo = new RepoItemInfo(this, "GroomingOnceDailyAt", ".//container[@controlname='containerPanel']//container[@controlname='groupBox1']//combobox//text[@accessiblename='Text area']", 30000, null, "1c880ec9-e930-4ccc-ace1-fd289843f3a2");
                _aggregaiononcedailyatInfo = new RepoItemInfo(this, "AggregaionOnceDailyAt", ".//container[@controlname='containerPanel']//container[@controlname='groupBox2']//combobox//text[@accessiblename='Text area']", 30000, null, "0b029e11-c7a7-423e-a20e-586adb6c05cf");
                _groomsessionsqueriesInfo = new RepoItemInfo(this, "GroomSessionsQueries", ".//container[@controlname='tableLayoutPanel4']/container[@controlname='activityGroomingThresholdNumericUpDown']/text[@controlname='upDownEdit']", 30000, null, "8d4e12ef-38a7-4191-8a37-9ebf6461b612");
                _groomchangelogInfo = new RepoItemInfo(this, "GroomChangeLog", ".//container[@controlname='tableLayoutPanel4']/container[@controltypename='NumericUpDown' and @instance='4']/text[@controlname='upDownEdit']", 30000, null, "ee387910-4f33-4868-8ab2-40e6f12661af");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("45d6f264-a0b9-4d39-b07c-41e3680e69d5")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("45d6f264-a0b9-4d39-b07c-41e3680e69d5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AggregateTextbox item.
            /// </summary>
            [RepositoryItem("bb7bc07f-fdce-435d-a9ac-c0a43ae7aa8e")]
            public virtual Ranorex.Text AggregateTextbox
            {
                get
                {
                    return _aggregatetextboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AggregateTextbox item info.
            /// </summary>
            [RepositoryItemInfo("bb7bc07f-fdce-435d-a9ac-c0a43ae7aa8e")]
            public virtual RepoItemInfo AggregateTextboxInfo
            {
                get
                {
                    return _aggregatetextboxInfo;
                }
            }

            /// <summary>
            /// The GroomForecastTextbox item.
            /// </summary>
            [RepositoryItem("628b3592-d551-45fb-ac4c-09da6d84873f")]
            public virtual Ranorex.Text GroomForecastTextbox
            {
                get
                {
                    return _groomforecasttextboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomForecastTextbox item info.
            /// </summary>
            [RepositoryItemInfo("628b3592-d551-45fb-ac4c-09da6d84873f")]
            public virtual RepoItemInfo GroomForecastTextboxInfo
            {
                get
                {
                    return _groomforecasttextboxInfo;
                }
            }

            /// <summary>
            /// The CancelButton item.
            /// </summary>
            [RepositoryItem("f32922fa-0f10-43c9-bf8b-635762c36ac8")]
            public virtual Ranorex.Button CancelButton
            {
                get
                {
                    return _cancelbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The CancelButton item info.
            /// </summary>
            [RepositoryItemInfo("f32922fa-0f10-43c9-bf8b-635762c36ac8")]
            public virtual RepoItemInfo CancelButtonInfo
            {
                get
                {
                    return _cancelbuttonInfo;
                }
            }

            /// <summary>
            /// The CombineOlderData item.
            /// </summary>
            [RepositoryItem("b11a9e64-8b5f-4df3-8bfd-9c6af34e45f8")]
            public virtual Ranorex.Text CombineOlderData
            {
                get
                {
                    return _combineolderdataInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The CombineOlderData item info.
            /// </summary>
            [RepositoryItemInfo("b11a9e64-8b5f-4df3-8bfd-9c6af34e45f8")]
            public virtual RepoItemInfo CombineOlderDataInfo
            {
                get
                {
                    return _combineolderdataInfo;
                }
            }

            /// <summary>
            /// The AggregationInCurrentTime item.
            /// </summary>
            [RepositoryItem("4535d7a1-d40a-4b9f-9e94-eff8ebb581df")]
            public virtual Ranorex.Container AggregationInCurrentTime
            {
                get
                {
                    return _aggregationincurrenttimeInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The AggregationInCurrentTime item info.
            /// </summary>
            [RepositoryItemInfo("4535d7a1-d40a-4b9f-9e94-eff8ebb581df")]
            public virtual RepoItemInfo AggregationInCurrentTimeInfo
            {
                get
                {
                    return _aggregationincurrenttimeInfo;
                }
            }

            /// <summary>
            /// The AggregationInCurrentGrooming item.
            /// </summary>
            [RepositoryItem("0da66b40-2bde-452d-a086-997be0f58733")]
            public virtual Ranorex.Container AggregationInCurrentGrooming
            {
                get
                {
                    return _aggregationincurrentgroomingInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The AggregationInCurrentGrooming item info.
            /// </summary>
            [RepositoryItemInfo("0da66b40-2bde-452d-a086-997be0f58733")]
            public virtual RepoItemInfo AggregationInCurrentGroomingInfo
            {
                get
                {
                    return _aggregationincurrentgroomingInfo;
                }
            }

            /// <summary>
            /// The GroomStandardMetrixAndBaseline item.
            /// </summary>
            [RepositoryItem("cb98d8c0-d2f4-4450-b009-3532ca0073e0")]
            public virtual Ranorex.Text GroomStandardMetrixAndBaseline
            {
                get
                {
                    return _groomstandardmetrixandbaselineInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomStandardMetrixAndBaseline item info.
            /// </summary>
            [RepositoryItemInfo("cb98d8c0-d2f4-4450-b009-3532ca0073e0")]
            public virtual RepoItemInfo GroomStandardMetrixAndBaselineInfo
            {
                get
                {
                    return _groomstandardmetrixandbaselineInfo;
                }
            }

            /// <summary>
            /// The AggregateQueryDataInto item.
            /// </summary>
            [RepositoryItem("de5fbc57-3a2c-4f81-9e5c-abc2a430930a")]
            public virtual Ranorex.Text AggregateQueryDataInto
            {
                get
                {
                    return _aggregatequerydataintoInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AggregateQueryDataInto item info.
            /// </summary>
            [RepositoryItemInfo("de5fbc57-3a2c-4f81-9e5c-abc2a430930a")]
            public virtual RepoItemInfo AggregateQueryDataIntoInfo
            {
                get
                {
                    return _aggregatequerydataintoInfo;
                }
            }

            /// <summary>
            /// The GroomInactiveAlert item.
            /// </summary>
            [RepositoryItem("3fb2ebda-cce5-4ac4-b199-394653d2665c")]
            public virtual Ranorex.Text GroomInactiveAlert
            {
                get
                {
                    return _groominactivealertInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomInactiveAlert item info.
            /// </summary>
            [RepositoryItemInfo("3fb2ebda-cce5-4ac4-b199-394653d2665c")]
            public virtual RepoItemInfo GroomInactiveAlertInfo
            {
                get
                {
                    return _groominactivealertInfo;
                }
            }

            /// <summary>
            /// The GroomPrescriptiveAnalysis item.
            /// </summary>
            [RepositoryItem("75d1eb55-600b-44fc-ac08-9fc009910a61")]
            public virtual Ranorex.Text GroomPrescriptiveAnalysis
            {
                get
                {
                    return _groomprescriptiveanalysisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomPrescriptiveAnalysis item info.
            /// </summary>
            [RepositoryItemInfo("75d1eb55-600b-44fc-ac08-9fc009910a61")]
            public virtual RepoItemInfo GroomPrescriptiveAnalysisInfo
            {
                get
                {
                    return _groomprescriptiveanalysisInfo;
                }
            }

            /// <summary>
            /// The GroomingOnceDailyAt item.
            /// </summary>
            [RepositoryItem("1c880ec9-e930-4ccc-ace1-fd289843f3a2")]
            public virtual Ranorex.Text GroomingOnceDailyAt
            {
                get
                {
                    return _groomingoncedailyatInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomingOnceDailyAt item info.
            /// </summary>
            [RepositoryItemInfo("1c880ec9-e930-4ccc-ace1-fd289843f3a2")]
            public virtual RepoItemInfo GroomingOnceDailyAtInfo
            {
                get
                {
                    return _groomingoncedailyatInfo;
                }
            }

            /// <summary>
            /// The AggregaionOnceDailyAt item.
            /// </summary>
            [RepositoryItem("0b029e11-c7a7-423e-a20e-586adb6c05cf")]
            public virtual Ranorex.Text AggregaionOnceDailyAt
            {
                get
                {
                    return _aggregaiononcedailyatInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AggregaionOnceDailyAt item info.
            /// </summary>
            [RepositoryItemInfo("0b029e11-c7a7-423e-a20e-586adb6c05cf")]
            public virtual RepoItemInfo AggregaionOnceDailyAtInfo
            {
                get
                {
                    return _aggregaiononcedailyatInfo;
                }
            }

            /// <summary>
            /// The GroomSessionsQueries item.
            /// </summary>
            [RepositoryItem("8d4e12ef-38a7-4191-8a37-9ebf6461b612")]
            public virtual Ranorex.Text GroomSessionsQueries
            {
                get
                {
                    return _groomsessionsqueriesInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomSessionsQueries item info.
            /// </summary>
            [RepositoryItemInfo("8d4e12ef-38a7-4191-8a37-9ebf6461b612")]
            public virtual RepoItemInfo GroomSessionsQueriesInfo
            {
                get
                {
                    return _groomsessionsqueriesInfo;
                }
            }

            /// <summary>
            /// The GroomChangeLog item.
            /// </summary>
            [RepositoryItem("ee387910-4f33-4868-8ab2-40e6f12661af")]
            public virtual Ranorex.Text GroomChangeLog
            {
                get
                {
                    return _groomchangelogInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GroomChangeLog item info.
            /// </summary>
            [RepositoryItemInfo("ee387910-4f33-4868-8ab2-40e6f12661af")]
            public virtual RepoItemInfo GroomChangeLogInfo
            {
                get
                {
                    return _groomchangelogInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}