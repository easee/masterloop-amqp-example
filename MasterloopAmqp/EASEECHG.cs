// Masterloop auto-generated template export.
// Created at: Mon, 23 Aug 2021 09:08:57 GMT
// https://portal.masterloop.net/#/templates/details/view/EASEECHG

namespace Masterloop.EASEECHG.Constants
{
	public class Observations
	{
		/// OK or error codes [String]
		public const int SelfTestResult = 1;
		/// JSON with details from self-test [String]
		public const int SelfTestDetails = 2;
		/// Enum with WiFi event codes. Requires telemetry debug mode. Will be updated on WiFi events when using cellular, will otherwise be reported in ChargerOfflineReason [Integer]
		public const int WifiEvent = 10;
		/// Enum describing why charger is offline [Integer]
		public const int ChargerOfflineReason = 11;
		/// Response on a EaseeLink command sent to another devic [Integer]
		public const int EaseeLinkCommandResponse = 13;
		/// Data received on EaseeLink from another device [String]
		public const int EaseeLinkDataReceived = 14;
		/// Preauthorize with whitelist enabled. Readback on setting [event] [Boolean]
		public const int LocalPreAuthorizeEnabled = 15;
		/// Allow offline charging for whitelisted RFID token. Readback on setting [event] [Boolean]
		public const int LocalAuthorizeOfflineEnabled = 16;
		/// Allow offline charging for all RFID tokens. Readback on setting [event] [Boolean]
		public const int AllowOfflineTxForUnknownId = 17;
		/// 0 == erratic checking disabled, otherwise the number of toggles between states Charging and Charging Complate that will trigger an error [Integer]
		public const int ErraticEVMaxToggles = 18;
		/// Readback on backplate type [Integer]
		public const int BackplateType = 19;
		/// Site Structure [boot] [String]
		public const int SiteStructure = 20;
		/// Detected power grid type according to PowerGridType table [boot] [Integer]
		public const int DetectedPowerGridType = 21;
		/// Set circuit maximum current [Amperes] [Double]
		public const int CircuitMaxCurrentP1 = 22;
		/// Set circuit maximum current [Amperes] [Double]
		public const int CircuitMaxCurrentP2 = 23;
		/// Set circuit maximum current [Amperes] [Double]
		public const int CircuitMaxCurrentP3 = 24;
		/// Location coordinate [event] [Position]
		public const int Location = 25;
		/// Site ID string [event] [String]
		public const int SiteIDString = 26;
		/// Site ID numeric value [event] [Integer]
		public const int SiteIDNumeric = 27;
		/// Timeout for backend to send authorization reply. After timeout offline rules apply. [Integer]
		public const int RfidAuthTimeoutSec = 28;
		/// Lock type2 cable permanently [Boolean]
		public const int LockCablePermanently = 30;
		/// Set true to enable charger, false disables charger [Boolean]
		public const int IsEnabled = 31;
		/// State of the monitor: OFF=0, MONITORING=-1, ACTIVE=1 [Integer]
		public const int TemperatureMonitorState = 32;
		/// Charger sequence number on circuit [Integer]
		public const int CircuitSequenceNumber = 33;
		/// Phase to use in 1-phase charging [Integer]
		public const int SinglePhaseNumber = 34;
		/// Allow charging using 3-phases [Boolean]
		public const int Enable3Phases_DEPRECATED = 35;
		/// WiFi SSID name [String]
		public const int WiFiSSID = 36;
		/// Charger signals available current when EV is done charging [user option][event] [Boolean]
		public const int EnableIdleCurrent = 37;
		/// Phase mode on this charger. 1-Locked to 1-Phase, 2-Auto, 3-Locked to 3-phase(only Home) [Integer]
		public const int PhaseMode = 38;
		/// Default disabled. Must be set manually if grid type is indeed three phase IT [Boolean]
		public const int ForcedThreePhaseOnITWithGndFault = 39;
		/// LED strip brightness, 0-100% [Integer]
		public const int LedStripBrightness = 40;
		/// Local RFID authorization is required for charging [user options][event] [Boolean]
		public const int LocalAuthorizationRequired = 41;
		/// Authorization is requried for charging [Boolean]
		public const int AuthorizationRequired = 42;
		/// Remote start required flag [event] [Boolean]
		public const int RemoteStartRequired = 43;
		/// Smart button is enabled [Boolean]
		public const int SmartButtonEnabled = 44;
		/// Charger behavior when offline [Integer]
		public const int OfflineChargingMode = 45;
		/// Charger LED mode [event] [Integer]
		public const int LEDMode = 46;
		/// Max current this charger is allowed to offer to car (A). Non volatile. [Double]
		public const int MaxChargerCurrent = 47;
		/// Max current this charger is allowed to offer to car (A). Volatile [Double]
		public const int DynamicChargerCurrent = 48;
		/// Maximum circuit current P1 when offline [event] [Integer]
		public const int MaxCurrentOfflineFallback_P1 = 50;
		/// Maximum circuit current P2 when offline [event] [Integer]
		public const int MaxCurrentOfflineFallback_P2 = 51;
		/// Maximum circuit current P3 when offline [event] [Integer]
		public const int MaxCurrentOfflineFallback_P3 = 52;
		/// True = charger needs control pulse to consider itself online. Readback on charger setting [event] [Boolean]
		public const int ListenToControlPulse = 56;
		/// Control pulse round-trip time in milliseconds [Integer]
		public const int ControlPulseRTT = 57;
		/// Charging schedule [json] [String]
		public const int ChargingSchedule = 62;
		/// Paired equalizer details [String]
		public const int PairedEqualizer = 65;
		/// True if WiFi Access Point is enabled, otherwise false [Boolean]
		public const int WiFiAPEnabled = 68;
		/// Observed user token when charger put in RFID pairing mode [event] [String]
		public const int PairedUserIDToken = 69;
		/// Total current allocated to L1 by all chargers on the circuit. Sent in by master only [Double]
		public const int CircuitTotalAllocatedPhaseConductorCurrent_L1 = 70;
		/// Total current allocated to L2 by all chargers on the circuit. Sent in by master only [Double]
		public const int CircuitTotalAllocatedPhaseConductorCurrent_L2 = 71;
		/// Total current allocated to L3 by all chargers on the circuit. Sent in by master only [Double]
		public const int CircuitTotalAllocatedPhaseConductorCurrent_L3 = 72;
		/// Total current in L1 (sum of all chargers on the circuit) Sent in by master only [Double]
		public const int CircuitTotalPhaseConductorCurrent_L1 = 73;
		/// Total current in L2 (sum of all chargers on the circuit) Sent in by master only [Double]
		public const int CircuitTotalPhaseConductorCurrent_L2 = 74;
		/// Total current in L3 (sum of all chargers on the circuit) Sent in by master only [Double]
		public const int CircuitTotalPhaseConductorCurrent_L3 = 75;
		/// Number of cars connected to this circuit [Integer]
		public const int NumberOfCarsConnected = 76;
		/// Number of cars currently charging [Integer]
		public const int NumberOfCarsCharging = 77;
		/// Number of cars currently in queue, waiting to be allocated power [Integer]
		public const int NumberOfCarsInQueue = 78;
		/// Number of cars that appear to be fully charged [Integer]
		public const int NumberOfCarsFullyCharged = 79;
		/// Embedded software package release id [boot] [Integer]
		public const int SoftwareRelease = 80;
		/// SIM integrated circuit card identifier [String]
		public const int ICCID = 81;
		/// Modem firmware version [String]
		public const int ModemFwId = 82;
		/// OTA error code, see table [event] [Integer]
		public const int OTAErrorCode = 83;
		/// Current mobile network operator [pollable] [String]
		public const int MobileNetworkOperator = 84;
		/// Reason of reboot. Bitmask of flags. [Integer]
		public const int RebootReason = 89;
		/// Power PCB hardware version [Integer]
		public const int PowerPCBVersion = 90;
		/// Communication PCB hardware version [Integer]
		public const int ComPCBVersion = 91;
		/// Enum describing why a charger with a car connected is not offering current to the car [Integer]
		public const int ReasonForNoCurrent = 96;
		/// Number of connected chargers in the load balancin. Including the master. Sent from Master only. [Integer]
		public const int LoadBalancingNumberOfConnectedChargers = 97;
		/// Number of chargers connected to master through UDP / WIFI [Integer]
		public const int UDPNumOfConnectedNodes = 98;
		/// Slaves only. Current connection to master, 0 = None, 1= Radio, 2 = WIFI UDP, 3 = Radio and WIFI UDP [Integer]
		public const int LocalConnection = 99;
		/// Pilot Mode Letter (A-F) [event] [String]
		public const int PilotMode = 100;
		/// Car connection state [Boolean]
		public const int CarConnected_DEPRECATED = 101;
		/// Smart charging state enabled by capacitive touch button [event] [Boolean]
		public const int SmartCharging = 102;
		/// Cable lock state [event] [Boolean]
		public const int CableLocked = 103;
		/// Cable rating read [Amperes][event] [Double]
		public const int CableRating = 104;
		/// Pilot signal high [Volt][debug] [Double]
		public const int PilotHigh = 105;
		/// Pilot signal low [Volt][debug] [Double]
		public const int PilotLow = 106;
		/// Back Plate RFID of charger [boot] [String]
		public const int BackPlateID = 107;
		/// User ID token string from RFID reading [event](NB! Must reverse these strings) [String]
		public const int UserIDTokenReversed = 108;
		/// Charger operation mode according to charger mode table [event] [Integer]
		public const int ChargerOpMode = 109;
		/// Active output phase(s) to EV according to output phase type table. [event] [Integer]
		public const int OutputPhase = 110;
		/// Dynamically set circuit maximum current for phase 1 [Amperes][event] [Double]
		public const int DynamicCircuitCurrentP1 = 111;
		/// Dynamically set circuit maximum current for phase 2 [Amperes][event] [Double]
		public const int DynamicCircuitCurrentP2 = 112;
		/// Dynamically set circuit maximum current for phase 3 [Amperes][event] [Double]
		public const int DynamicCircuitCurrentP3 = 113;
		/// Available current signaled to car with pilot tone [Double]
		public const int OutputCurrent = 114;
		/// Available current after derating [A] [Double]
		public const int DeratedCurrent = 115;
		/// Available current is limited by the charger due to high temperature [event] [Boolean]
		public const int DeratingActive = 116;
		/// Debug string [String]
		public const int DebugString = 117;
		/// Descriptive error string [event] [String]
		public const int ErrorString = 118;
		/// Error code according to error code table [event] [Integer]
		public const int ErrorCode = 119;
		/// Total power [kW][telemetry] [Double]
		public const int TotalPower = 120;
		/// Session accumulated energy [kWh][telemetry] [Double]
		public const int SessionEnergy = 121;
		/// Accumulated energy per hour [kWh][event] [Double]
		public const int EnergyPerHour = 122;
		/// 0 = not legacy ev, 1 = legacy ev detected, 2 = reviving ev [Integer]
		public const int LegacyEvStatus = 123;
		/// Accumulated energy in the lifetime of the charger [kWh] [Double]
		public const int LifetimeEnergy = 124;
		/// Total number of relay switches in the lifetime of the charger (irrespective of the number of phases used) [Integer]
		public const int LifetimeRelaySwitches = 125;
		/// Total number of hours in operation [Integer]
		public const int LifetimeHours = 126;
		/// Maximum circuit current when offline [event] [Integer]
		public const int DynamicCurrentOfflineFallback_DEPRICATED = 127;
		/// User ID token string from RFID reading [event] [String]
		public const int UserIDToken = 128;
		/// Charging sessions [json][event] [String]
		public const int ChargingSession = 129;
		/// Cellular signal strength [dBm][telemetry] [Integer]
		public const int CellRSSI = 130;
		/// Cellular radio access technology according to RAT table [event] [Integer]
		public const int CellRAT = 131;
		/// WiFi signal strength [dBm][telemetry] [Integer]
		public const int WiFiRSSI = 132;
		/// IP address assigned by cellular network [debug] [String]
		public const int CellAddress = 133;
		/// IP address assigned by WiFi network [debug] [String]
		public const int WiFiAddress = 134;
		/// WiFi network type letters (G, N, AC, etc) [debug] [String]
		public const int WiFiType = 135;
		/// Local radio signal strength [dBm][telemetry] [Integer]
		public const int LocalRSSI = 136;
		/// Back Plate RFID of master [event] [String]
		public const int MasterBackPlateID = 137;
		/// Local radio transmission power [dBm][telemetry] [Integer]
		public const int LocalTxPower = 138;
		/// Local radio state [event] [String]
		public const int LocalState = 139;
		/// List of found WiFi SSID and RSSI values [event] [String]
		public const int FoundWiFi = 140;
		/// Radio access technology in use: 0 = cellular, 1 = wifi [Integer]
		public const int ChargerRAT = 141;
		/// The number of times since boot the system has reported an error on this interface [poll] [Integer]
		public const int CellularInterfaceErrorCount = 142;
		/// The number of times since boot the interface was reset due to high error count [poll] [Integer]
		public const int CellularInterfaceResetCount = 143;
		/// The number of times since boot the system has reported an error on this interface [poll] [Integer]
		public const int WifiInterfaceErrorCount = 144;
		/// The number of times since boot the interface was reset due to high error count [poll] [Integer]
		public const int WifiInterfaceResetCount = 145;
		/// 0-Unconfigured, 1-Master, 2-Extender, 3-End device [Integer]
		public const int LocalNodeType = 146;
		/// Channel nr 0 - 11 [Integer]
		public const int LocalRadioChannel = 147;
		/// Address of charger on local radio network [Integer]
		public const int LocalShortAddress = 148;
		/// If master-Number of slaves connected, If slave- Address parent [Integer]
		public const int LocalParentAddrOrNumOfNodes = 149;
		/// Maximum temperature for all sensors [Celsius][telemetry] [Double]
		public const int TempMax = 150;
		/// Temperature measured by ambient sensor on bottom of power board [Celsius][event] [Double]
		public const int TempAmbientPowerBoard = 151;
		/// Temperature at input T2 [Celsius][event] [Double]
		public const int TempInputT2 = 152;
		/// Temperature at input T3 [Celsius][event] [Double]
		public const int TempInputT3 = 153;
		/// Temperature at input T4 [Celsius][event] [Double]
		public const int TempInputT4 = 154;
		/// Temperature at input T5 [Celsius][event] [Double]
		public const int TempInputT5 = 155;
		/// Temperature at type 2 connector plug for N [Celsius][event] [Double]
		public const int TempOutputN = 160;
		/// Temperature at type 2 connector plug for L1 [Celsius][event] [Double]
		public const int TempOutputL1 = 161;
		/// Temperature at type 2 connector plug for L2 [Celsius][event] [Double]
		public const int TempOutputL2 = 162;
		/// Temperature at type 2 connector plug for L3 [Celsius][event] [Double]
		public const int TempOutputL3 = 163;
		/// Temperature under N relay on ONE [Celsius] [Double]
		public const int TempRelayN = 164;
		/// Temperature under L relay on ONE [Celsius] [Double]
		public const int TempRelayL = 165;
		/// Temperature measured by ambient sensor on top of power board [Celsius] [Double]
		public const int TempAmbientPowerBoardTop = 166;
		/// Ambient temperature on COM board [Celsius][event] [Double]
		public const int TempAmbient = 170;
		/// Ambient light from front side [Percent][debug] [Integer]
		public const int LightAmbient = 171;
		/// Internal relative humidity [Percent][event] [Integer]
		public const int IntRelHumidity = 172;
		/// Back plate confirmed locked [event] [Boolean]
		public const int BackPlateLocked = 173;
		/// Motor current draw [debug] [Double]
		public const int CurrentMotor = 174;
		/// Raw sensor value [mV] [Integer]
		public const int BackPlateHallSensor = 175;
		/// Calculated current RMS for input T2 [Amperes][telemetry] [Double]
		public const int InCurrent_T2 = 182;
		/// Current RMS for input T3 [Amperes][telemetry] [Double]
		public const int InCurrent_T3 = 183;
		/// Current RMS for input T4 [Amperes][telemetry] [Double]
		public const int InCurrent_T4 = 184;
		/// Current RMS for input T5 [Amperes][telemetry] [Double]
		public const int InCurrent_T5 = 185;
		/// Input voltage RMS between T1 and T2 [Volt][telemetry] [Double]
		public const int InVolt_T1_T2 = 190;
		/// Input voltage RMS between T1 and T3 [Volt][telemetry] [Double]
		public const int InVolt_T1_T3 = 191;
		/// Input voltage RMS between T1 and T4 [Volt][telemetry] [Double]
		public const int InVolt_T1_T4 = 192;
		/// Input voltage RMS between T1 and T5 [Volt][telemetry] [Double]
		public const int InVolt_T1_T5 = 193;
		/// Input voltage RMS between T2 and T3 [Volt][telemetry] [Double]
		public const int InVolt_T2_T3 = 194;
		/// Input voltage RMS between T2 and T4 [Volt][telemetry] [Double]
		public const int InVolt_T2_T4 = 195;
		/// Input voltage RMS between T2 and T5 [Volt][telemetry] [Double]
		public const int InVolt_T2_T5 = 196;
		/// Input voltage RMS between T3 and T4 [Volt][telemetry] [Double]
		public const int InVolt_T3_T4 = 197;
		/// Input voltage RMS between T3 and T5 [Volt][telemetry] [Double]
		public const int InVolt_T3_T5 = 198;
		/// Input voltage RMS between T4 and T5 [Volt][telemetry] [Double]
		public const int InVolt_T4_T5 = 199;
		/// Output voltage RMS between type 2 pin 1 and 2 [Volt][telemetry] [Double]
		public const int OutVoltPin1_2 = 202;
		/// Output voltage RMS between type 2 pin 1 and 3 [Volt][telemetry] [Double]
		public const int OutVoltPin1_3 = 203;
		/// Output voltage RMS between type 2 pin 1 and 4 [Volt][telemetry] [Double]
		public const int OutVoltPin1_4 = 204;
		/// Output voltage RMS between type 2 pin 1 and 5 [Volt][telemetry] [Double]
		public const int OutVoltPin1_5 = 205;
		/// Output voltage RMS between type 2 pin 2 and 3 [Volt] [Double]
		public const int OutVoltPin2_3 = 206;
		/// 3.3 Volt Level [Volt][telemetry] [Double]
		public const int VoltLevel33 = 210;
		/// 5 Volt Level [Volt][telemetry] [Double]
		public const int VoltLevel5 = 211;
		/// 12 Volt Level [Volt][telemetry] [Double]
		public const int VoltLevel12 = 212;
		/// Fatal error code according to error code table [event] [Integer]
		public const int FatalErrorCode = 219;
		/// Reference Signal Received Power (LTE) [-144 .. -44 dBm] [Integer]
		public const int LTE_RSRP = 220;
		/// Signal to Interference plus Noise Ratio (LTE) [-20 .. +30 dB] [Integer]
		public const int LTE_SINR = 221;
		/// Reference Signal Received Quality (LTE) [-19 .. -3 dB] [Integer]
		public const int LTE_RSRQ = 222;
		/// Charging session started [event] [String]
		public const int ChargingSessionStart = 223;
		/// Available current for charging on P1 according to Equalizer [Double]
		public const int EqAvailableCurrentP1 = 230;
		/// Available current for charging on P2 according to Equalizer [Double]
		public const int EqAvailableCurrentP2 = 231;
		/// Available current for charging on P3 according to Equalizer [Double]
		public const int EqAvailableCurrentP3 = 232;
		/// Various diagnostic information for testing. Must be enabled by setting DiagnosticsMode == 256 [String]
		public const int DiagnosticsString = 240;
	}

	public class Settings
	{
		/// ProductCode [Integer] 
		public const int ProductCode = 1;
		/// DiagnosticsMode [Integer] 
		public const int DiagnosticsMode = 2;
		/// PulseIntervalSec [Integer] 
		public const int PulseIntervalSec = 3;
		/// ReportIntervalCellSec [Integer] 
		public const int ReportIntervalCellSec = 4;
		/// ReportIntervalWiFiSec [Integer] 
		public const int ReportIntervalWiFiSec = 5;
		/// SmartButtonEnabled [Boolean] 
		public const int SmartButtonEnabled = 6;
		/// AllowUnencryptedWifiConnections [Boolean] 
		public const int AllowUnencryptedWifiConnections = 7;
		/// PinCode [String] 
		public const int PinCode = 10;
		/// LocalPreAuthorizeEnabled [Boolean] 
		public const int LocalPreAuthorizeEnabled = 15;
		/// LocalAuthorizeOfflineEnabled [Boolean] 
		public const int LocalAuthorizeOfflineEnabled = 16;
		/// AllowOfflineTxForUnknownId [Boolean] 
		public const int AllowOfflineTxForUnknownId = 17;
		/// OfflineChargingMode [Integer] 
		public const int OfflineChargingMode = 30;
		/// AuthorizationRequired [Boolean] 
		public const int AuthorizationRequired = 31;
		/// RemoteStartRequired [Boolean] 
		public const int RemoteStartRequired = 32;
		/// NetworkSequence [Integer] 
		public const int NetworkSequence = 39;
		/// MQHost [String] 
		public const int MQHost = 40;
		/// MQHostEaseeIoT [String] 
		public const int MQHostEaseeIoT = 41;
		/// IoTSystem [Integer] 
		public const int IoTSystem = 42;
		/// LifeTimeEnergyReportInterval [Integer] 
		public const int LifeTimeEnergyReportInterval = 43;
		/// LifeTimeEnergyReportMode [Integer] 
		public const int LifeTimeEnergyReportMode = 44;
	}

	public class Pulses
	{
		/// Device Pulse
		public const int DevicePulse = 0;
		/// Masterloop Pulse
		public const int Masterloop = 1;
		/// Control Pulse
		public const int Control = 2;
	}

	public class Commands
	{
		/// Reboot charger
		public const int Reboot = 1;

		/// Poll single observation
		public const int PollSingle = 2;

		public static class PollSingleArguments
		{
			///ObsId [Integer]
			public const int ObsId = 1;
		}

		/// Poll all observations
		public const int PollAll = 3;

		/// Upgrade firmware to the latest version using delta OTA
		public const int UpgradeFirmware = 4;

		/// Download settings
		public const int DownloadSettings = 5;

		/// Set specific OTA firmware release
		public const int SetFirmware = 6;

		public static class SetFirmwareArguments
		{
			///ReleaseId [Integer]
			public const int ReleaseId = 1;
		}

		/// Returns WiFi SSIDs with RSSI value
		public const int ScanWiFi = 7;

		public static class ScanWiFiArguments
		{
			///Timeout [s] [Integer]
			public const int Timeout_S = 1;
		}

		/// Configure WiFi connection
		public const int SetWiFiConfig_UNSUPPORTED = 8;

		public static class SetWiFiConfig_UNSUPPORTEDArguments
		{
			///SSID [String]
			public const int SSID = 1;
			///Password [String]
			public const int Password = 2;
		}

		/// Remotely set back plate info
		public const int SetSiteInfo_UNSUPPORTED = 9;

		public static class SetSiteInfo_UNSUPPORTEDArguments
		{
			///SiteStructure [String]
			public const int SiteStructure = 1;
			///CircuitSequenceNumber [Integer]
			public const int CircuitSequenceNumber = 2;
		}

		/// Sets remote start required flag
		public const int SetRemoteStartRequired_DEPRECATED = 10;

		public static class SetRemoteStartRequired_DEPRECATEDArguments
		{
			///RemoteStart [Boolean]
			public const int RemoteStart = 1;
		}

		/// Set smart charging mode
		public const int SetSmartCharging = 11;

		public static class SetSmartChargingArguments
		{
			///SmartCharging [Boolean]
			public const int SmartCharging = 1;
		}

		/// Set smart button enabled (can toggle smart mode/normal mode)
		public const int SetSmartButtonEnabled_DEPRECATED = 12;

		public static class SetSmartButtonEnabled_DEPRECATEDArguments
		{
			///SmartButtonEnable [Boolean]
			public const int SmartButtonEnable = 1;
		}

		/// Enables advanced options for setting firmware
		public const int SetFirmwareAdvanced = 13;

		public static class SetFirmwareAdvancedArguments
		{
			///ReleaseId [Integer]
			public const int ReleaseId = 1;
			///ForceNoDelta [Boolean]
			public const int ForceNoDelta = 2;
			///UseBackupOTASystem [Boolean]
			public const int UseBackupOTASystem = 3;
		}

		/// Send a command to another device on same circuit using EaseeLink RF/WiFi
		public const int SendEaseeLinkCommand = 14;

		public static class SendEaseeLinkCommandArguments
		{
			///TargetID [String]
			public const int TargetID = 1;
			///Command [Integer]
			public const int Command = 2;
			///Data [String]
			public const int Data = 3;
			///Data_2 [String]
			public const int Data_2 = 4;
		}

		/// Start OTA of cellular module
		public const int StartCellularOTA = 15;

		public static class StartCellularOTAArguments
		{
			///FirmwareURL [String]
			public const int FirmwareURL = 1;
			///ManualMode [Boolean]
			public const int ManualMode = 2;
		}

		/// Start self-test program. Might take a minue or two to complete, depends on network connectivity etc.
		public const int StartSelfTest = 16;

		public static class StartSelfTestArguments
		{
			///RequireUserRFIDAndTouch [Boolean]
			public const int RequireUserRFIDAndTouch = 1;
		}

		/// Set backplate type, e.g. to 'production'
		public const int SetBackplateType = 17;

		public static class SetBackplateTypeArguments
		{
			///BackplateType [Integer]
			public const int BackplateType = 1;
			///Arg0 [Integer]
			public const int Arg0 = 2;
			///Arg1 [Integer]
			public const int Arg1 = 3;
		}

		/// Set 0 to disable feature. Otherwise set the number of toggles that will trigger an error when state toggles between Charging and Charging Complete
		public const int SetErraticEVMaxToggles = 18;

		public static class SetErraticEVMaxTogglesArguments
		{
			///MaxTogglesOrDisableFeature [Integer]
			public const int MaxTogglesOrDisableFeature = 1;
		}

		/// Tell device to disconnect MQTT and specify when it should reconnect again
		public const int Disconnect = 20;

		public static class DisconnectArguments
		{
			///SecondsUntilReconnect [Integer]
			public const int SecondsUntilReconnect = 1;
		}

		/// Sets the maximum circuit current to be used by the loadbalancer in case the charger goes offline [Amperes]
		public const int SetDynamicCurrentOfflineFallback = 21;

		public static class SetDynamicCurrentOfflineFallbackArguments
		{
			///MaxDynamicCurrentP1 [Integer]
			public const int MaxDynamicCurrentP1 = 1;
			///MaxDynamicCurrentP2 [Integer]
			public const int MaxDynamicCurrentP2 = 2;
			///MaxDynamicCurrentP3 [Integer]
			public const int MaxDynamicCurrentP3 = 3;
		}

		/// Set charge current for each phase [Amperes], use 0 for all phases to pause charging (for smart charging / volatile setting)
		public const int SetDynamicCircuitCurrent = 22;

		public static class SetDynamicCircuitCurrentArguments
		{
			///Current P1 [Double]
			public const int CurrentP1 = 1;
			///Current P2 [Double]
			public const int CurrentP2 = 2;
			///Current P3 [Double]
			public const int CurrentP3 = 3;
			///TTL (minutes) [Integer]
			public const int TTL_Minutes = 4;
		}

		/// Open relays immediately
		public const int AbortCharging_DEPRECATED = 23;

		/// Non-volatile max current for circuit [Amperes]
		public const int SetMaxCircuitCurrent = 24;

		public static class SetMaxCircuitCurrentArguments
		{
			///CurrentP1 [Integer]
			public const int CurrentP1 = 1;
			///CurrentP2 [Integer]
			public const int CurrentP2 = 2;
			///CurrentP3 [Integer]
			public const int CurrentP3 = 3;
		}

		/// Provide authorization result
		public const int AuthorizeCharging = 25;

		public static class AuthorizeChargingArguments
		{
			///IDToken [String]
			public const int IDToken = 1;
			///Status [Integer]
			public const int Status = 2;
		}

		/// Deauthorizes charging
		public const int DeauthorizeCharging = 26;

		public static class DeauthorizeChargingArguments
		{
			///IDToken [String]
			public const int IDToken = 1;
			///Status [Integer]
			public const int Status = 2;
		}

		/// Set the number of seconds the charger should waits for an authorize command after user scans RFID
		public const int SetRfidAuthTimeoutSec = 28;

		public static class SetRfidAuthTimeoutSecArguments
		{
			///TimeoutSec [Integer]
			public const int TimeoutSec = 1;
		}

		/// Set true to enable charger
		public const int SetEnabled = 29;

		public static class SetEnabledArguments
		{
			///IsEnabled [Boolean]
			public const int IsEnabled = 1;
		}

		/// Set cable lock state
		public const int SetLockCablePermanently = 30;

		public static class SetLockCablePermanentlyArguments
		{
			///Locked [Boolean]
			public const int Locked = 1;
		}

		/// Play sound effect
		public const int PlaySound_UNSUPPORTED = 31;

		public static class PlaySound_UNSUPPORTEDArguments
		{
			///SoundId [Integer]
			public const int SoundId = 1;
		}

		/// Play light effect
		public const int PlayLights = 32;

		public static class PlayLightsArguments
		{
			///LightId [Integer]
			public const int LightId = 1;
			///DurationSec [Integer]
			public const int DurationSec = 2;
		}

		/// Require local RFID authorization for charging
		public const int SetLocalAuthorizationRequired = 33;

		public static class SetLocalAuthorizationRequiredArguments
		{
			///Enable [Boolean]
			public const int Enable = 1;
		}

		/// Charger signals available current when EV is done charging
		public const int EnableIdleCurrent = 34;

		public static class EnableIdleCurrentArguments
		{
			///Enable [Boolean]
			public const int Enable = 1;
		}

		/// Charger will only charge on 1 phase even if connected to 3 phase grid
		public const int SetLimitToSinglePhaseCharging_DEPRECATED = 35;

		public static class SetLimitToSinglePhaseCharging_DEPRECATEDArguments
		{
			///LimitToSinglePhase [Boolean]
			public const int LimitToSinglePhase = 1;
		}

		/// Set Phase mode on this charger. 1-Locked to 1-Phase, 2-Auto, 3-Locked to 3-phase(only Home)
		public const int SetPhaseMode = 38;

		public static class SetPhaseModeArguments
		{
			///PhaseMode [Integer]
			public const int PhaseMode = 1;
		}

		/// Only set to true if grid is actually three phase IT when charger cannot detect due to ground fault.
		public const int SetForceThreePhaseOnITWithGndFault = 39;

		public static class SetForceThreePhaseOnITWithGndFaultArguments
		{
			///Enable [Boolean]
			public const int Enable = 1;
		}

		/// Set LED strip brightness, 0-100%
		public const int SetLedStripBrightness = 40;

		public static class SetLedStripBrightnessArguments
		{
			///Brightness [Integer]
			public const int Brightness = 1;
		}

		/// Require authentication to start charging
		public const int SetAuthenticationRequried_DEPRECATED = 42;

		public static class SetAuthenticationRequried_DEPRECATEDArguments
		{
			///Authentication Required [Boolean]
			public const int AuthenticationRequired = 1;
		}

		/// Add authentication keys to the charger's whitelist
		public const int AddKeys = 43;

		public static class AddKeysArguments
		{
			///Keys [String]
			public const int Keys = 1;
		}

		/// Remove all keys from the charger's whitelist
		public const int ClearKeys = 44;

		/// Set max charge current for this charger [Amperes]. Non-volatile setting, stored in flash. Should only be used for permanent change to current
		public const int SetMaxChargerCurrent = 47;

		public static class SetMaxChargerCurrentArguments
		{
			///Current(Amp) [Integer]
			public const int Current_Amp = 1;
		}

		/// Set max charge current for this charger [Amperes], use 0 to pause charging (for smart charging / volatile setting)
		public const int SetDynamicChargerCurrent = 48;

		public static class SetDynamicChargerCurrentArguments
		{
			///Current(Amp) [Integer]
			public const int Current_Amp = 1;
			///TTL (minutes) [Integer]
			public const int TTL_Minutes = 2;
		}

		/// Set circuit number
		public const int SetCircuitNumber = 49;

		public static class SetCircuitNumberArguments
		{
			///CircuitNumber [Integer]
			public const int CircuitNumber = 1;
		}

		/// Set value of fuse in front of charger [Amperes]
		public const int SetCircuitRatedCurrent = 50;

		public static class SetCircuitRatedCurrentArguments
		{
			///Fuse value (Amp) [Integer]
			public const int FuseValue_Amp = 1;
		}

		/// Set MasterBackPlateID
		public const int SetMasterBackPlateID = 51;

		public static class SetMasterBackPlateIDArguments
		{
			///MasterBackPlateID [String]
			public const int MasterBackPlateID = 1;
		}

		/// Set site key
		public const int SetSiteKey = 52;

		public static class SetSiteKeyArguments
		{
			///Site Key [String]
			public const int SiteKey = 1;
		}

		/// Set local wifi and password
		public const int SetLocalWifi = 53;

		public static class SetLocalWifiArguments
		{
			///SSID [String]
			public const int SSID = 1;
			///Password [String]
			public const int Password = 2;
		}

		/// True = charger needs control pulse to consider itself online
		public const int SetListenToControlPulse = 56;

		public static class SetListenToControlPulseArguments
		{
			///ListenToControlPulse [Boolean]
			public const int ListenToControlPulse = 1;
		}

		/// Enable realtime data streaming
		public const int EnableRealtimeDataMode = 57;

		public static class EnableRealtimeDataModeArguments
		{
			///TTL (sec) [Integer]
			public const int TTL_Sec = 1;
		}

		/// Add a charging schedule. The schedule must specify stack level.
		public const int AddSchedule = 60;

		public static class AddScheduleArguments
		{
			///Schedule [String]
			public const int Schedule = 1;
		}

		/// Clear charging schedule for given stack level
		public const int ClearSchedule = 61;

		public static class ClearScheduleArguments
		{
			///StackLevel [Integer]
			public const int StackLevel = 1;
		}

		/// Get the charging schedule for the given stack level
		public const int GetSchedule = 62;

		public static class GetScheduleArguments
		{
			///StackLevel [Integer]
			public const int StackLevel = 1;
		}

		/// Overrides the schedule for the current session. Output current will not be limited by the schedule. Schedule is automatically resumed when EV disconnects.
		public const int OverrideSchedule = 63;

		/// Erase all schedule content in flash and reset schedule logic
		public const int PurgeSchedule = 64;

		/// Set charger in RFID pairing mode. Any RFID token read by the charger will be reported on dedicated observation.
		public const int SetRFIDPairingMode = 69;

		public static class SetRFIDPairingModeArguments
		{
			///TimeoutSec [Integer]
			public const int TimeoutSec = 1;
		}

		/// Clear all fatal error that are stored in flash
		public const int ClearFatalError = 70;

		/// Cleanse by switching relays on/off. Charger aborts automatically if EV is detected. Use all possible relays based on grid type
		public const int CleanseRelays = 71;

		public static class CleanseRelaysArguments
		{
			///NumCycles [Integer]
			public const int NumCycles = 1;
			///CycleDelayMs [Integer]
			public const int CycleDelayMs = 2;
		}

		/// Set according to enum
		public const int SetTemperatureMonitorState = 72;

		public static class SetTemperatureMonitorStateArguments
		{
			///State [Integer]
			public const int State = 1;
		}

		/// Simulate cable disconnection
		public const int SimulateDisconnect = 90;

		public static class SimulateDisconnectArguments
		{
			///DurationSec [Integer]
			public const int DurationSec = 1;
		}

		/// Sets a flag telling OTA to restore manifest and patch file index information. Use this to retry OTA without dowloading the file again
		public const int DebugOtaRestoreSession = 91;

		public static class DebugOtaRestoreSessionArguments
		{
			///RestoreSession [Boolean]
			public const int RestoreSession = 1;
		}

		/// Charger will output EVSE state F to signal supply error to car.
		public const int SimulateSupplyError = 92;

		public static class SimulateSupplyErrorArguments
		{
			///DurationSec [Integer]
			public const int DurationSec = 1;
		}

		/// Device specific command line interface
		public const int DeviceCLI = 93;

		public static class DeviceCLIArguments
		{
			///Command [String]
			public const int Command = 1;
		}

		/// Set client certificate for mqtt authentication
		public const int SetClientCertificate = 94;

		public static class SetClientCertificateArguments
		{
			///PrivateKey [String]
			public const int PrivateKey = 1;
			///PrivateKeyChecksum [String]
			public const int PrivateKeyChecksum = 2;
			///Certificate [String]
			public const int Certificate = 3;
			///CertificateChecksum [String]
			public const int CertificateChecksum = 4;
		}

	}

}

