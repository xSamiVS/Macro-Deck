﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SuchByte.MacroDeck.Language
{
    public class Strings
    {

        public string __Language__  = "English";
        public string __LanguageCode__  = "en";
        public string __Author__  = "Macro Deck";

        public string NetworkAdapter  = "Network adapter";
        public string IPAddress  = "IP address";
        public string Port  = "Port";
        public string Info  = "Info";
        public string Error = "Error";
        public string Warning = "Warning";
        public string ConfigureNetworkInfo   = "It's really important to select the correct network adapter or otherwise you will not be able to connect with the client to the server. In most cases the name of the Network adapter looks like \"Ethernet\" or \"Wi-Fi\" and the ip address in most cases looks like \"192.168.178.xxx\".\r\n\r\nThe default port for Macro Deck is 8191. If some other application uses this port, you can change it.";
        public string AutomaticallyCheckUpdates  = "Automatically check for updates";
        public string AutomaticallyStartWithWindows  = "Automatically start with Windows";
        public string Show  = "Configure Macro Deck";
        public string Exit  = "Exit Macro Deck";
        public string XUpdatesAvailable = "{0} updates available";
        public string Profile = "Profile";
        public string Columns = "Columns";
        public string Rows = "Rows";
        public string Spacing = "Spacing";
        public string CornerRadius = "Corner radius";
        public string ButtonBackGround = "Button background";
        public string AreYouSure = "Are you sure?";
        public string Behaviour = "Behaviour";
        public string Plugins = "Plugins";
        public string IconPacks = "Icon packs";
        public string All = "All";
        public string Updates = "Updates";
        public string Installed = "Installed";
        public string Install = "Install";
        public string Search = "Search...";
        public string Name = "Name";
        public string Type = "Type";
        public string Value = "Value";
        public string Creator = "Creator";
        public string Ok = "Ok";
        public string FolderName = "Folder name";
        public string Never = "Never";
        public string OnApplicationFocus = "On application focus";
        public string Application = "Application";
        public string Devices = "Devices";
        public string Create = "Create";
        public string Save = "Save";
        public string Appearance = "Appearance";
        public string ButtonState = "Button state";
        public string Label = "Label";
        public string Top = "Top";
        public string Center = "Center";
        public string Bottom = "Bottom";
        public string Path = "Path";
        public string CurrentState = "Current state";
        public string Off = "Off";
        public string On = "On";
        public string DownloadAndInstall = "Download and install";
        public string Downloading = "Downloading...";
        public string Color = "Color";
        public string IconPack = "Icon pack";
        public string Size = "Size";
        public string CurrentProgress = "Current progress";
        public string TotalProgress = "Total progress";
        public string XDownloads = "{0} downloads";
        public string Update = "Update";
        public string Plugin = "Plugin";
        public string MacroDeckNeedsARestart = "Macro Deck needs a restart";
        public string MacroDeckMustBeRestartedForTheChanges = "Macro Deck must be restarted for the changes to take effect. Would you like to restart Macro Deck now?";
        public string Configure = "Configure";
        public string Uninstall = "Uninstall";
        public string NotLoaded = "Not loaded";
        public string Yes = "Yes";
        public string No = "No";
        public string Status = "Status";
        public string BlockConnection = "Block connection";
        public string Change = "Change";
        public string Id = "ID";
        public string Connected = "Connected";
        public string Disconnected = "Disconnected";
        public string Trigger = "Trigger";
        public string Action = "Action";
        public string Condition = "Condition";
        public string InstalledVersion = "Installed version";
        public string UpdateChannel = "Update channel";
        public string CheckForUpdatesNow = "Check for updates now";
        public string Author = "Author";
        public string Version = "Version";

        public string TheFolderWillBeDeleted = "The folder {0} with all its action buttons will be deleted.";

        public string TheProfileWillBeDeleted = "The profile {0} with all its folders and action buttons will be deleted.";

        public string ServerOffline = "Server offline";
        public string ServerRunning = "Server running";
        public string XPluginsLoaded = "{0} plugins loaded";
        public string XPluginsDisabled = "{0} plugins disabled";
        public string XClientsConnected = "{0} clients connected";
        public string IpAddressHostNamePort = "IP address/hostname : Port";

        public string InitialSetupButtonBack  = "<- Back";
        public string InitialSetupButtonNext  = "Next ->";
        public string InitialSetupButtonFinish  = "Finish";
        public string InitialSetupSelectLanguage = "Select your language";
        public string InitialSetupPage  = "Page {0}/{1}";
        public string InitialSetupWelcome  = "Welcome to Macro Deck 2!";
        public string InitialSetupLetsConfigure  = "Let's configure your Macro Deck experience";
        public string InitialSetupConfigureNetworkSettings  = "Configure your network settings";
        public string InitialSetupConfigureGridPreferences  = "Now let's configure the grid to your preferences";
        public string InitialSetupPickAllPluginsYouNeed  = "Pick all the plugins you need";
        public string InitialSetupDontWorryInstallUninstallPlugins  = "Don't worry, you can always install/uninstall plugins later in the package manager";
        public string InitialSetupWantSomeIcons  = "Do you want some icons?";
        public string InitialSetupInstallIconPacksPackageManager  = "You can also install icon packs later in the package manager";
        public string InitialSetupAlmostDone  = "We're almost done!";

        public string KnownDevices = "Known devices";
        public string AskOnNewConnections = "Ask on new connections";
        public string AllowAllNewConnections = "Allow all new connections (Not recommended)";
        public string BlockAllNewConnections = "Block all new connections";

        public string InstallDLL = "Install .dll (not recommended)";
        public string NeverInstallDLLFiles = "Never install .dll files from sources you don't trust! .dll files from unknown sources may harm your system, only install it when you know what you do! Do you really like to install a .dll plugin?";
        public string XWillBeUninstalled = "{0} will be uninstalled.";
        public string XSuccessfullyUninstalled = "{0} will be uninstalled. Macro Deck must be restarted to take the changes effect. Restart Macro Deck now?";

        public string CreateVariable = "Create variable";
        public string DeleteVariable = "Delete variable";

        public string SelectAPluginAndActionToBegin = "Select a plugin and a action to begin";
        public string ActionNeedsNoConfiguration = "This action needs no configuration";

        public string CantCreateFolder = "Can't create folder";
        public string FolderCalledXAlreadyExists = "A folder called {0} already exists";

        public string OnPress = "On press";
        public string OnEvent = "On event";
        public string CantCreateIconPack = "Can't create icon pack";
        public string IconPackCalledXAlreadyExists = "A icon pack called {0} already exists";
        public string CantCreateProfile = "Can't create profile";
        public string ProfileCalledXAlreadyExists = "A profile called {0} already exists";
        public string TheresAnUpdateForYou = "There's an update for you :)";
        public string VersionXIsNowAvailable = "Version {0} ({1}) is now available";
        public string ReadyToDownloadUpdate = "Ready to download update";
        public string DownloadingUpdate = "Downloading update... {0}% ({1}MB/{2}MB)";
        public string VerifyingUpdateFile = "Verifying update file...";
        public string MD5NotValid = "MD5 checksum is not valid";
        public string StartingInstaller = "Starting installer";
        public string FileNotFound = "File not found";
        public string TryAgainOrDownloadManually = "Try again or download the update manually";
        public string Trending = "Trending";
        public string Layers = "Layers";
        public string AddImage = "Add image";
        public string IconImportQualityInfo = "High quality icons can lead to an increase of memory usage and loading times especially when using many big animated gifs. \n\r\n\rFor gifs it is recommended to use the low or the lowest preset.";
        public string Original = "Original";
        public string High350px = "High (350px)";
        public string Normal200px = "Normal (200px)";
        public string Low150px = "Low (150px)";
        public string Lowest100px = "Lowest (100px)";
        public string ImportIconPack = "Import icon pack";
        public string ExportIconPack = "Export icon pack";
        public string CreateIcon = "Create icon";
        public string ImportIcon = "Import icon";
        public string DeleteIcon = "Delete icon";
        public string IconSelectorManagedInfo = "This icon pack is managed by the plugin manager";
        public string DownloadingXPackages = "Downloading {0} packages";
        public string PluginCouldNotBeLoaded = "Plugin could not be loaded. Perhaps the installed version of this plugin is not compatible with this version of Macro Deck.";
        public string CantChangeName = "Can't change name";
        public string DeviceCalledXAlreadyExists = "A device called {0} already exists";
        public string NewConnection = "New connection";
        public string XIsAnUnknownDevice = "{0} is an unknown device and wants to connect to Macro Deck. Allow connection?";
        public string ShouldMacroDeckBlockConnectionsFromX = "Should Macro Deck automatically block future connections from {0}?";
        public string FailedToStartServer = "Failed to start the server. Perhaps the configured port is already in use or you set the incorrect network adapter. Confirm you set the correct network adapter in the settings and try to change the port.";
        public string ErrorWhileLoadingPlugins = "Error while loading plugins";
        public string PluginXCouldNotBeLoaded = "{0} version {1} could not be loaded.Perhaps it is not compatible with this version of Macro Deck. Actions that uses this plugin, will not work until the plugin is updated.";
        public string InstallationSuccessfull = "Installation successfull";
        public string PluginXInstalledSuccessfully = "{0} was installed successfully";
        public string ErrorWhileInstallingPlugin = "Error while installing plugin";
        public string PluginXCouldNotBeInstalled = "{0} could not be installed. Perhaps it is not compatible with this version of Macro Deck";
        public string Settings = "Settings";
        public string Language = "Language";
        public string General = "General";
        public string Connection = "Connection";
        public string Backup = "Backup";
        public string About = "About";
        public string NoUpdatesAvailable = "No updates available";
        public string LatestVersionInstalled = "The latest version is already installed";
        public string WarningDevVersions = "Dev versions can be really instable and can cause crashes or data loss (configured action buttons, folders and profiles). You really want to enable the Dev update channel?";
        public string WarningBetaVersions = "Beta versions can sometimes be instable and can cause crashes. You really want to enable the Beta update channel?";
        public string VariableXGetsDeleted = "The variable {0} gets deleted";
        public string DeckTitle = "Deck";
        public string DeviceManagerTitle = "Device manager";
        public string PackageManagerTitle = "Package manager";
        public string SettingsTitle = "Settings";
        public string VariablesTitle = "Global variables";
        public string Edit = "Edit";
        public string Delete = "Delete";
        public string Run = "Run";
        public string Copy = "Copy";
        public string Paste = "Paste";
        public string WebSocketAPIVersion = "Websocket API version";
        public string PluginAPIVersion = "Plugin API version";
        public string InstalledPlugins = "Installed plugins";
        public string OperatingSystem = "Operating system";
        public string DevelopedByX = "Developed by {0} in Germany";
        public string XTranslationByX = "{0} translation by {1}";
        public string PackageManagerTabAvailable = "Available";
        public string PackageManagerTabInstalled = "Installed";
        public string Event = "Event";
        public string AutomaticallySwitchToFolder = "Automatically switch to folder";
        public string Restart = "Restart Macro Deck";
        public string Delay = "Delay";
        public string If = "If";
        public string Else = "Else";
        public string Online = "Online";
        public string By = "By";
        public string StateBinding = "Bind state to";
        public string ErrorWhileLoadingPackageManager = "Error while loading package manager. Perhaps you are not connected to the internet or Macro Deck is blocked by your firewall.";
        public string UpdatesAvailable = "Updates available";
        public string EnableIconCache = "Enable icon cache (faster; higher memory usage)";
        public string WebClient = "Web client";
        public string AndroidApp = "Android client";
        public string IOSApp = "iOS client";
        public string PluginMacroDeckFolder = "Macro Deck folder";
        public string ActionChangeFolder = "Change folder";
        public string ActionChangeFolderDescription = "Change the current folder on the current device to the configured folder";
        public string ActionGoToParentFolder = "Go to parent folder";
        public string ActionGoToParentFolderDescription = "Change the current folder on the current device to the folders parent folder";
        public string ActionGoToRootFolder = "Go to root folder";
        public string ActionGoToRootFolderDescription = "Change the current folder on the current device to the root folder";
        public string PluginMacroDeckVariables = "Macro Deck variables";
        public string ActionChangeVariableValue = "Change variable value";
        public string ActionChangeVariableValueDescription = "Count up, count down, set a variable value and toggle variable value";
        public string CountUp = "Count up";
        public string CountDown = "Count down";
        public string Set = "Set";
        public string Toggle = "Toggle";
        public string Variable = "Variable";
        public string PluginActionButton = "This action button";
        public string ActionToggleActionButtonState = "Toggle button state";
        public string ActionToggleActionButtonStateDescription = "Toggles the state of this button";
        public string ActionSetActionButtonStateOff = "Set button state to off";
        public string ActionSetActionButtonStateOffDescription = "Sets the state of this button to \"off\"";
        public string ActionSetActionButtonStateOn = "Set button state to on";
        public string ActionSetActionButtonStateOnDescription = "Sets the state of this button to \"on\"";
        public string Description = "Description";
        public string License = "License";
        public string AnimatedGifImported = "Animated gif imported";
        public string GenerateStaticIcon = "Also generate a static icon of the GIFs first frame?";
        public string XSuccessfullyExportedToX = "{0} was successfully exported to {1}";
        public string SelectedIconWillBeDeleted = "The selected icon will be deleted from the icon pack {0}";
        public string SuccessfullyImportedIconPack = "Successfully imported the icon pack {0}";
        public string SelectedIconPackWillBeDeleted = "The selected icon pack {0} with all its icons will be deleted";
        public string GenerateStatic = "Generate static";
        public string OnlyUserCreatedVariablesVisible = "Only user-created variables are visible";
        public string MacroDeckUsesCottleTemplateEngine = "Macro Deck uses the Cottle template engine. Click here for more information.";
        public string Result = "Result";
        public string InstallDevVersions = "Install Dev versions";
        public string InstallBetaVersions = "Install Beta versions";
        public string WhatDoYouWantToRestore = "What do you want to restore from the backup?";
        public string Configuration = "Configuration";
        public string Profiles = "Profiles";
        public string Variables = "Variables";
        public string PluginConfigurations = "Plugin configurations";
        public string PluginCredentials = "Plugin credentials";
        public string InstalledIconPacks = "Installed icon packs";
        public string Restore = "Restore";
        public string ActionCannotBeReversed = "This action can not be reversed";
        public string ThisWillDeleteBackupPermanently = "This will delete the backup permanently";
        public string Created = "Created";
        public string PleaseWait = "Please wait...";
        public string Backups = "Backups";
        public string CreateBackup = "Create backup";
        public string BackupFailed = "Backup failed";
        public string BackupSuccessfullyCreated = "Backup successfully created";
        public string CreateBackupBeforeUpdate = "Do you want to create a backup before the update?";
        public string CreatingBackup = "Creating backup...";
        public string PluginNeedsConfiguration = "This plugin needs to be configured";
        public string ConfigureNow = "Do you want to configure {0} now?";
        public string Hotkey = "Hotkey";
        public string PressTheKeysNow = "Press the keys you want to assign now";
        public string XAction = "{0} action";
        public string XActions = "{0} actions";
        public string OnRelease = "On release";
        public string OnLongPress = "On long press";
        public string OnLongPressRelease = "On long press release";
        public string SimulateOnPress = "Simulate \"On press\"";
        public string SimulateOnRelease = "Simulate \"On release\"";
        public string SimulateOnLongPress = "Simulate \"On long press\"";
        public string SimulateOnLongPressRelease = "Simulate \"On long press release\"";
        public string HotkeyExecutesOnPress = "The hotkey executes the \"On press\" actions when pressed";
        public string Important = "Important";
        public string FirewallAlertInfo = "After starting Macro Deck, a dialog from Windows Defender Firewall will appear.\r\nPlease check all boxes (Private networks, Public networks and if it exists, Domain networks).\r\n\r\nIf this dialog does not appear and you still experience connection problems, please visit the wiki or the discord server for help. ";
        public string GotIt = "Got it!";
        public string DeviceSettings = "Device settings";
        public string Brightness = "Brightness";
        public string AutoConnect = "Connect automatically";
        public string DiscordSupport = "Discord support";
        public string Wiki = "Wiki";
        public string ExportLatestLog = "Export latest log";
        public string LogSuccessfullyExportedToX = "Log successfully exported to {0}";
        public string Help = "Help";
        public string XWarningsXErrors = "{0} warning(s), {1} error(s)";
        public string TrimBlankLines = "Trim blank lines";
        public string Extensions = "Extensions";
        public string InstallFromFile = "Install from file";
        public string AllExtensionsUpToDate = "All extensions are up-to-date";
        public string UpdateAll = "Update all";
        public string UpdateAvailable = "Update available";
        public string PendingRestart = "Pending restart";
        public string Enabled = "Enabled";
        public string Disabled = "Disabled";
        public string ActionSaveVariableToFile = "Save variable to file";
        public string ActionSaveVariableToFileDescription = "Saves the value of the variable to a file";
        public string Folders = "Folders";
        public string Grid = "Grid";
        public string ActionReadVariableFromFile = "Read variable from file";
        public string ActionReadVariableFromFileDescription = "Reads a file and sets the content as value for a variable";
        public string ActionSetProfile = "Set profile";
        public string ActionSetProfileDescription = "Sets the profile on a device";
        public string Device = "Device";
        public string WhereExecuted = "Where executed";
        public string ActionSetBrightness = "Set brightness";
        public string ActionSetBrightnessDescription = "Sets the display brightness (Only on the Android app!)";
        public string BindableVariable = "Bindable variable";
        public string BindableVariableInfo = "The state of this button can be bound to the variable {0}. Do you want to bind the state?";
        public string Cancelled = "Cancelled";
        public string Preparing = "Preparing...";
        public string Installing = "Installing...";
        public string Completed = "Completed";
        public string ExtensionStoreDownloaderPackageIdVersion = "{0} version {1}";
        public string DownloadingAndInstallingXPackages = "Downloading and installing {0} package(s)";
        public string InstallationOfXPackagesDone = "Installation of {0} package(s) done";
        public string ActionSetBackgroundColor = "Set background color";
        public string ActionSetBackgroundColorDescription = "Changes the background color of a action button";
        public string Fixed = "Fixed";
        public string Random = "Random";
        public string NewConnectionRequest = "New connection request";
        public string ClientId = "Client id";
        public string Accept = "Accept";
        public string Deny = "Deny";
        public string VersionBuild = "Build";
        public string OpenExtensionManager = "Open Extension Manager";
        public string OpenSettings = "Open settings";
    }
}
