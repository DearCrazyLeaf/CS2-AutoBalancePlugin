namespace AutoBalancePlugin;
using System;
using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

public class AutoBalancePluginConfig : BasePluginConfig
{
    [JsonPropertyName("ScrambleMode")]
    public bool ScrambleMode { get; set; } = false;
    
    [JsonPropertyName("KillPlayerOnSwitch")]
    public bool KillPlayerOnSwitch { get; set; } = false;
    
    [JsonPropertyName("BalanceOnRoundStart")]
    public bool BalanceOnRoundStart { get; set; } = false;
    
    [JsonPropertyName("BalanceBots")]
    public bool BalanceBots { get; set; } = true;
    
    [JsonPropertyName("MaximumAllowedDifference")]
    public int MaximumAllowedDifference { get; set; } = 1;
    
    [JsonPropertyName("AutoBalanceMessage")]
    public string AutoBalanceMessage { get; set; } = " {GOLD}鈼?[Auto Balance] {DEFAULT} -> {DEFAULT}Switched {GOLD}{_playerName} {DEFAULT}to {RED}{_switchedTeam}";

    [JsonPropertyName("AutoBalanceCommandUsageMessage")]
    public string AutoBalanceCommandUsageMessage { get; set; } = "{GREEN}[Auto Balance]{DEFAULT} Usage: css_autobalance <on|off>";

    [JsonPropertyName("AutoBalanceCommandOnMessage")]
    public string AutoBalanceCommandOnMessage { get; set; } = "{GREEN}[Auto Balance]{DEFAULT} Auto balance ON.";

    [JsonPropertyName("AutoBalanceCommandOffMessage")]
    public string AutoBalanceCommandOffMessage { get; set; } = "{GREEN}[Auto Balance]{DEFAULT} Auto balance OFF.";

    [JsonPropertyName("AutoBalanceCommandNoPermissionMessage")]
    public string AutoBalanceCommandNoPermissionMessage { get; set; } = "{RED}[Auto Balance]{DEFAULT} You do not have permission.";

    [JsonPropertyName("AutoBalanceCommandPermissions")]
    public string[] AutoBalanceCommandPermissions { get; set; } = Array.Empty<string>();
}
