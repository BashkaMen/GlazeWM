﻿namespace GlazeWM.Domain.UserConfigs
{
  /// <summary>
  /// A component to display information about the battery of the device, namely the battery level and
  /// whether the device is connected to power or is in power saving mode.
  /// 
  /// There are 3 labels that are used depending on the situation, and the variable
  /// <c>{battery_level}</c> is replaced with the current battery level of the device.
  /// 
  /// When the device does not have a dedicated battery, the battery level is displayed
  /// as 100% at all times.
  /// </summary>
  public class BatteryComponentConfig : BarComponentConfig
  {
    /// <summary>
    /// Formatted text to display when the device is draining battery power.
    /// </summary>
    public string Draining { get; set; } = " {battery_level}% ";
    /// <summary>
    /// Formatted text to display when the device is in power saving mode.
    /// </summary>
    public string PowerSaver { get; set; } = " {battery_level}% (power saver) ";
    /// <summary>
    /// Formatted text to display when the device is connected to power.
    /// </summary>
    public string Charging { get; set; } = " {battery_level}% (charging) ";
  }
}