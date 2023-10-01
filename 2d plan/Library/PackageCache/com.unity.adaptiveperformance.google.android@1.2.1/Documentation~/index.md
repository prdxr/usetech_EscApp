# Adaptive Performance Android provider

The Adaptive Performance Android provider extends [Adaptive Performance](https://docs.unity3d.com/Packages/com.unity.adaptiveperformance@latest/index.html) to Android devices. To do this, it sends device-specific information from Android devices to the Adaptive Performance package. This enables you to retrieve data about the thermal state and performance mode of Android devices.

This package integrates with the following Android frameworks and APIs:
* Android Dynamic Performance Framework (ADPF) ([more info](https://developer.android.com/games/optimize/adpf))
  * The following APIs are integrated into Adaptive Performance `ITheramlStatus` to retrieve thermal information about the device.
    * [getThermalHeadroom](https://developer.android.com/reference/android/os/PowerManager#getThermalHeadroom(int))
    * [getCurrentThermalStatus](https://developer.android.com/reference/android/os/PowerManager#getCurrentThermalStatus())
    * [ThermalStatusChangedListener](https://developer.android.com/reference/android/os/PowerManager.OnThermalStatusChangedListener)
  * The following APIs are integrated into the game loop to retrieve and send performance related details to Android.
    * [createHintSession](https://developer.android.com/reference/android/os/PerformanceHintManager#createHintSession(int[],%20long))
    * [getPreferredUpdateRateNanos](https://developer.android.com/reference/android/os/PerformanceHintManager#getPreferredUpdateRateNanos())
    * [reportActualWorkDuration](https://developer.android.com/reference/android/os/PerformanceHintManager.Session#reportActualWorkDuration(long))
* GameMode API ([more info](https://developer.android.com/games/gamemode))
  * The Android [GetGameMode](https://developer.android.com/reference/android/app/GameManager#getGameMode()) API is integrated into Adaptive Performance `IPerformanceModeStatus`
  * There is also a `Android.AndroidGame.GameMode` property available in the Unity API.
* GameState API
  * On Adaptive Performance initialization, the Android [SetGameState](https://developer.android.com/reference/android/app/GameState) API is triggered
  * There is also a `Android.AndroidGame.SetGameState` method available in the Unity API to make additional calls to the Android [GameManager](https://developer.android.com/reference/android/app/GameManager).

For information on what's new in the latest version of Adaptive Performance Android, see the [Changelog](../changelog/CHANGELOG.html).
