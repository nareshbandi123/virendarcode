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

namespace AutomationSQLdm.BVT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the BVTRepo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("89e1bd47-219c-49ba-b76b-07e3f5b33a94")]
    public partial class BVTRepo : RepoGenBaseFolder
    {
        static BVTRepo instance = new BVTRepo();
        BVTRepoFolders.ApplicationAppFolder _application;
        BVTRepoFolders.SQLdmDesktopClientAppFolder _sqldmdesktopclient;
        BVTRepoFolders.MonitoredSqlServerInstancePropertiesDialAppFolder _monitoredsqlserverinstancepropertiesdial;
        BVTRepoFolders.ExceptionMessageBoxFormAppFolder _exceptionmessageboxform;

        /// <summary>
        /// Gets the singleton class instance representing the BVTRepo element repository.
        /// </summary>
        [RepositoryFolder("89e1bd47-219c-49ba-b76b-07e3f5b33a94")]
        public static BVTRepo Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public BVTRepo() 
            : base("BVTRepo", "/", null, 0, false, "89e1bd47-219c-49ba-b76b-07e3f5b33a94", ".\\RepositoryImages\\BVTRepo89e1bd47.rximgres")
        {
            _application = new BVTRepoFolders.ApplicationAppFolder(this);
            _sqldmdesktopclient = new BVTRepoFolders.SQLdmDesktopClientAppFolder(this);
            _monitoredsqlserverinstancepropertiesdial = new BVTRepoFolders.MonitoredSqlServerInstancePropertiesDialAppFolder(this);
            _exceptionmessageboxform = new BVTRepoFolders.ExceptionMessageBoxFormAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("89e1bd47-219c-49ba-b76b-07e3f5b33a94")]
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
        [RepositoryFolder("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
        public virtual BVTRepoFolders.ApplicationAppFolder Application
        {
            get { return _application; }
        }

        /// <summary>
        /// The SQLdmDesktopClient folder.
        /// </summary>
        [RepositoryFolder("e140d4dc-2ddc-406e-830c-583124931599")]
        public virtual BVTRepoFolders.SQLdmDesktopClientAppFolder SQLdmDesktopClient
        {
            get { return _sqldmdesktopclient; }
        }

        /// <summary>
        /// The MonitoredSqlServerInstancePropertiesDial folder.
        /// </summary>
        [RepositoryFolder("cdc48991-0ebd-482b-9b79-ed5a0ff93a99")]
        public virtual BVTRepoFolders.MonitoredSqlServerInstancePropertiesDialAppFolder MonitoredSqlServerInstancePropertiesDial
        {
            get { return _monitoredsqlserverinstancepropertiesdial; }
        }

        /// <summary>
        /// The ExceptionMessageBoxForm folder.
        /// </summary>
        [RepositoryFolder("5dc6a578-8823-4687-9328-acb0b68d03c0")]
        public virtual BVTRepoFolders.ExceptionMessageBoxFormAppFolder ExceptionMessageBoxForm
        {
            get { return _exceptionmessageboxform; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class BVTRepoFolders
    {
        /// <summary>
        /// The ApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
        public partial class ApplicationAppFolder : RepoGenBaseFolder
        {
            ElementBrInfoClass _elementbrInfo;
            RepoItemInfo _elementbr1Info;

            /// <summary>
            /// Creates a new Application  folder.
            /// </summary>
            public ApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Application", "/form[@title~'^Idera\\ SQL\\ diagnostic\\ mana']", parentFolder, 30000, null, true, "1a73f651-c755-42fc-8b6e-622d9bbcf5f6", "")
            {
                _elementbrInfo = new ElementBrInfoClass(this);
                _elementbr1Info = new RepoItemInfo(this, "ElementBr1", "statusbar[@automationid='statusBar']/?/?/container[@automationid='viewContainer']/container[@automationid='viewHost']/container[@automationid='windowsFormsHostControl']/?/?/container[@controlname='_child']//container[@controlname='dashboardTableLayoutPanel']/container[@controlname='CpuControl']//element[@controlname='callRatesChart']/element[@controlname='br']", 30000, null, "857edc88-4c04-4db0-acd2-165ce78a8dd8");
            }

            /// <summary>
            /// The ElementBrInfoClass folder.
            /// </summary>
            [RepositoryItemInfo("f50023fb-90bd-41a4-89e6-e5ec4644f21e")]
            public class ElementBrInfoClass : RepoItemInfo
            {
                /// <summary>
                /// ElementBrInfoClass class constructor.
                /// </summary>
                public ElementBrInfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "ElementBr", "statusbar[@automationid='statusBar']/?/?/container[@automationid='viewContainer']/container[@automationid='viewHost']/container[@automationid='windowsFormsHostControl']/?/?/container[@controlname='_child']//container[@controlname='dashboardTableLayoutPanel']/container[@controlname='CpuControl']//element[@controlname='br']", 30000, null, "f50023fb-90bd-41a4-89e6-e5ec4644f21e")
                { }

                /// <summary>
                /// Gets the CPU item image.
                /// </summary>
                /// <returns>The CPU image.</returns>
                [RepositoryImage("a50c8111-5f42-4088-9abd-c5e3291d1562")]
                public CompressedImage GetCPU()
                {
                    return GetImage("a50c8111-5f42-4088-9abd-c5e3291d1562");
                }

                /// <summary>
                /// Gets the CPU item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("a50c8111-5f42-4088-9abd-c5e3291d1562")]
                public CompressedImage GetCPU(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("a50c8111-5f42-4088-9abd-c5e3291d1562", cropRect);
                }
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
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
            [RepositoryItemInfo("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ElementBr item.
            /// </summary>
            [RepositoryItem("f50023fb-90bd-41a4-89e6-e5ec4644f21e")]
            public virtual Ranorex.Unknown ElementBr
            {
                get
                {
                    return _elementbrInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The ElementBr item info.
            /// </summary>
            [RepositoryItemInfo("f50023fb-90bd-41a4-89e6-e5ec4644f21e")]
            public virtual ElementBrInfoClass ElementBrInfo
            {
                get
                {
                    return _elementbrInfo;
                }
            }

            /// <summary>
            /// The ElementBr1 item.
            /// </summary>
            [RepositoryItem("857edc88-4c04-4db0-acd2-165ce78a8dd8")]
            public virtual Ranorex.Unknown ElementBr1
            {
                get
                {
                    return _elementbr1Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The ElementBr1 item info.
            /// </summary>
            [RepositoryItemInfo("857edc88-4c04-4db0-acd2-165ce78a8dd8")]
            public virtual RepoItemInfo ElementBr1Info
            {
                get
                {
                    return _elementbr1Info;
                }
            }
        }

        /// <summary>
        /// The SQLdmDesktopClientAppFolder folder.
        /// </summary>
        [RepositoryFolder("e140d4dc-2ddc-406e-830c-583124931599")]
        public partial class SQLdmDesktopClientAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _propertiesInfo;

            /// <summary>
            /// Creates a new SQLdmDesktopClient  folder.
            /// </summary>
            public SQLdmDesktopClientAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SQLdmDesktopClient", "/contextmenu[@processname='SQLdmDesktopClient']", parentFolder, 30000, null, true, "e140d4dc-2ddc-406e-830c-583124931599", "")
            {
                _propertiesInfo = new RepoItemInfo(this, "Properties", "menuitem[@accessiblename='Properties...']", 30000, null, "7ce3a534-ef11-4faf-8c9d-a4677b844a08");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e140d4dc-2ddc-406e-830c-583124931599")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e140d4dc-2ddc-406e-830c-583124931599")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Properties item.
            /// </summary>
            [RepositoryItem("7ce3a534-ef11-4faf-8c9d-a4677b844a08")]
            public virtual Ranorex.MenuItem Properties
            {
                get
                {
                    return _propertiesInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Properties item info.
            /// </summary>
            [RepositoryItemInfo("7ce3a534-ef11-4faf-8c9d-a4677b844a08")]
            public virtual RepoItemInfo PropertiesInfo
            {
                get
                {
                    return _propertiesInfo;
                }
            }
        }

        /// <summary>
        /// The MonitoredSqlServerInstancePropertiesDialAppFolder folder.
        /// </summary>
        [RepositoryFolder("cdc48991-0ebd-482b-9b79-ed5a0ff93a99")]
        public partial class MonitoredSqlServerInstancePropertiesDialAppFolder : RepoGenBaseFolder
        {
            BVTRepoFolders.OsPropertyPageFolder _ospropertypage;
            RepoItemInfo _osmetrixInfo;

            /// <summary>
            /// Creates a new MonitoredSqlServerInstancePropertiesDial  folder.
            /// </summary>
            public MonitoredSqlServerInstancePropertiesDialAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MonitoredSqlServerInstancePropertiesDial", "/form[@controlname='MonitoredSqlServerInstancePropertiesDialog']", parentFolder, 30000, null, true, "cdc48991-0ebd-482b-9b79-ed5a0ff93a99", "")
            {
                _ospropertypage = new BVTRepoFolders.OsPropertyPageFolder(this);
                _osmetrixInfo = new RepoItemInfo(this, "OSMetrix", "container[@controlname='propertiesControl']//list[@controlname='propertyPageListBox']//listitem[@index='8']", 30000, null, "e0720cb8-acdc-4c56-b62e-12b4b2365c19");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cdc48991-0ebd-482b-9b79-ed5a0ff93a99")]
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
            [RepositoryItemInfo("cdc48991-0ebd-482b-9b79-ed5a0ff93a99")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The OSMetrix item.
            /// </summary>
            [RepositoryItem("e0720cb8-acdc-4c56-b62e-12b4b2365c19")]
            public virtual Ranorex.ListItem OSMetrix
            {
                get
                {
                    return _osmetrixInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The OSMetrix item info.
            /// </summary>
            [RepositoryItemInfo("e0720cb8-acdc-4c56-b62e-12b4b2365c19")]
            public virtual RepoItemInfo OSMetrixInfo
            {
                get
                {
                    return _osmetrixInfo;
                }
            }

            /// <summary>
            /// The OsPropertyPage folder.
            /// </summary>
            [RepositoryFolder("133ae619-d314-4cda-8854-f8168b347457")]
            public virtual BVTRepoFolders.OsPropertyPageFolder OsPropertyPage
            {
                get { return _ospropertypage; }
            }
        }

        /// <summary>
        /// The OsPropertyPageFolder folder.
        /// </summary>
        [RepositoryFolder("133ae619-d314-4cda-8854-f8168b347457")]
        public partial class OsPropertyPageFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sqldmserviceaccountInfo;
            RepoItemInfo _usernameInfo;
            RepoItemInfo _optionwmidirectInfo;
            RepoItemInfo _passwordInfo;
            RepoItemInfo _wmitestbuttonInfo;

            /// <summary>
            /// Creates a new OsPropertyPage  folder.
            /// </summary>
            public OsPropertyPageFolder(RepoGenBaseFolder parentFolder) :
                    base("OsPropertyPage", "container[@controlname='propertiesControl']//container[@controlname='osPropertyPage']", parentFolder, 30000, null, false, "133ae619-d314-4cda-8854-f8168b347457", "")
            {
                _sqldmserviceaccountInfo = new RepoItemInfo(this, "SqldmServiceAccount", ".//container[@controlname='wmiCredentialsSecondaryContainer']//checkbox[@controlname='optionWmiCSCreds']", 30000, null, "10cb1136-2861-42e8-a2f8-3c6fa73eaafd");
                _usernameInfo = new RepoItemInfo(this, "UserName", ".//container[@controlname='wmiCredentialsSecondaryContainer']//text[@controlname='directWmiUserName']/text[@accessiblerole='Text']", 30000, null, "48b8b1e2-c2e9-4f09-a983-b03d1bc44a29");
                _optionwmidirectInfo = new RepoItemInfo(this, "OptionWmiDirect", ".//radiobutton[@controlname='optionWmiDirect']", 30000, null, "cf61cbff-d218-4cc7-9ffe-b70c7ba05912");
                _passwordInfo = new RepoItemInfo(this, "Password", ".//container[@controlname='wmiCredentialsSecondaryContainer']//text[@controlname='directWmiPassword']/text[@accessiblerole='Text']", 30000, null, "f3d8a65a-76d1-427d-be97-02e89d2a6453");
                _wmitestbuttonInfo = new RepoItemInfo(this, "WmiTestButton", ".//container[@controlname='wmiCredentialsSecondaryContainer']///button[@controlname='wmiTestButton']", 30000, null, "b69e423f-19ea-4d62-ada1-891b31aeb7bb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("133ae619-d314-4cda-8854-f8168b347457")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("133ae619-d314-4cda-8854-f8168b347457")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SqldmServiceAccount item.
            /// </summary>
            [RepositoryItem("10cb1136-2861-42e8-a2f8-3c6fa73eaafd")]
            public virtual Ranorex.CheckBox SqldmServiceAccount
            {
                get
                {
                    return _sqldmserviceaccountInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The SqldmServiceAccount item info.
            /// </summary>
            [RepositoryItemInfo("10cb1136-2861-42e8-a2f8-3c6fa73eaafd")]
            public virtual RepoItemInfo SqldmServiceAccountInfo
            {
                get
                {
                    return _sqldmserviceaccountInfo;
                }
            }

            /// <summary>
            /// The UserName item.
            /// </summary>
            [RepositoryItem("48b8b1e2-c2e9-4f09-a983-b03d1bc44a29")]
            public virtual Ranorex.Text UserName
            {
                get
                {
                    return _usernameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The UserName item info.
            /// </summary>
            [RepositoryItemInfo("48b8b1e2-c2e9-4f09-a983-b03d1bc44a29")]
            public virtual RepoItemInfo UserNameInfo
            {
                get
                {
                    return _usernameInfo;
                }
            }

            /// <summary>
            /// The OptionWmiDirect item.
            /// </summary>
            [RepositoryItem("cf61cbff-d218-4cc7-9ffe-b70c7ba05912")]
            public virtual Ranorex.RadioButton OptionWmiDirect
            {
                get
                {
                    return _optionwmidirectInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The OptionWmiDirect item info.
            /// </summary>
            [RepositoryItemInfo("cf61cbff-d218-4cc7-9ffe-b70c7ba05912")]
            public virtual RepoItemInfo OptionWmiDirectInfo
            {
                get
                {
                    return _optionwmidirectInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("f3d8a65a-76d1-427d-be97-02e89d2a6453")]
            public virtual Ranorex.Text Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("f3d8a65a-76d1-427d-be97-02e89d2a6453")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The WmiTestButton item.
            /// </summary>
            [RepositoryItem("b69e423f-19ea-4d62-ada1-891b31aeb7bb")]
            public virtual Ranorex.Button WmiTestButton
            {
                get
                {
                    return _wmitestbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The WmiTestButton item info.
            /// </summary>
            [RepositoryItemInfo("b69e423f-19ea-4d62-ada1-891b31aeb7bb")]
            public virtual RepoItemInfo WmiTestButtonInfo
            {
                get
                {
                    return _wmitestbuttonInfo;
                }
            }
        }

        /// <summary>
        /// The ExceptionMessageBoxFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("5dc6a578-8823-4687-9328-acb0b68d03c0")]
        public partial class ExceptionMessageBoxFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonyesInfo;

            /// <summary>
            /// Creates a new ExceptionMessageBoxForm  folder.
            /// </summary>
            public ExceptionMessageBoxFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ExceptionMessageBoxForm", "/form[@controlname='ExceptionMessageBoxForm']", parentFolder, 30000, null, true, "5dc6a578-8823-4687-9328-acb0b68d03c0", "")
            {
                _buttonyesInfo = new RepoItemInfo(this, "ButtonYes", "container[@controlname='pnlForm']//button[@controlname='button1']", 30000, null, "65600686-fcf9-4595-9568-6fb9f3bf3ba0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5dc6a578-8823-4687-9328-acb0b68d03c0")]
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
            [RepositoryItemInfo("5dc6a578-8823-4687-9328-acb0b68d03c0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonYes item.
            /// </summary>
            [RepositoryItem("65600686-fcf9-4595-9568-6fb9f3bf3ba0")]
            public virtual Ranorex.Button ButtonYes
            {
                get
                {
                    return _buttonyesInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonYes item info.
            /// </summary>
            [RepositoryItemInfo("65600686-fcf9-4595-9568-6fb9f3bf3ba0")]
            public virtual RepoItemInfo ButtonYesInfo
            {
                get
                {
                    return _buttonyesInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}