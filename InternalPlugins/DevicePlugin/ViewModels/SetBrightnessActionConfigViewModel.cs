﻿using SuchByte.MacroDeck.Device;
using SuchByte.MacroDeck.InternalPlugins.DevicePlugin.Models;
using SuchByte.MacroDeck.Language;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Models;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Profiles;
using SuchByte.MacroDeck.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuchByte.MacroDeck.InternalPlugins.DevicePlugin.ViewModels
{
    public class SetBrightnessActionConfigViewModel : ISerializableConfigViewModel
    {
        private readonly PluginAction _action;

        public SetBrightnessActionConfigModel Configuration { get; set; }

        ISerializableConfiguration ISerializableConfigViewModel.SerializableConfiguration => Configuration;

        public string ClientId
        {
            get => this.Configuration.ClientId;
            set => this.Configuration.ClientId = value;
        }

        public float Brightness
        {
            get => this.Configuration.Brightness;
            set => this.Configuration.Brightness = value;
        }

        public SetBrightnessActionConfigViewModel(PluginAction action)
        {
            this.Configuration = SetBrightnessActionConfigModel.Deserialize(action.Configuration);
            this._action = action;
        }

        public bool SaveConfig()
        {
            try
            {
                SetConfig();
                MacroDeckLogger.Info($"{GetType().Name}: config saved");
            }
            catch (Exception ex)
            {
                MacroDeckLogger.Error( $"{GetType().Name}: Error while saving config: { ex.Message + Environment.NewLine + ex.StackTrace }");
                return false;
            }
            return true;
        }

        public void SetConfig()
        {
            _action.ConfigurationSummary = $"{(string.IsNullOrWhiteSpace(ClientId) ? LanguageManager.Strings.WhereExecuted : DeviceManager.GetKnownDevices().Find(x => x.ClientId.Equals(ClientId)).DisplayName)} -> {Math.Round(Brightness * 100)}%";
            _action.Configuration = Configuration.Serialize();
        }

    }
}
