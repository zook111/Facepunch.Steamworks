using System;
using System.Runtime.InteropServices;

namespace SteamNative
{
	//
	// EUniverse
	//
	public enum Universe : int
	{
		Invalid = 0,
		Public = 1,
		Beta = 2,
		Internal = 3,
		Dev = 4,
		Max = 5,
	}
	
	//
	// EResult
	//
	public enum Result : int
	{
		OK = 1,
		Fail = 2,
		NoConnection = 3,
		InvalidPassword = 5,
		LoggedInElsewhere = 6,
		InvalidProtocolVer = 7,
		InvalidParam = 8,
		FileNotFound = 9,
		Busy = 10,
		InvalidState = 11,
		InvalidName = 12,
		InvalidEmail = 13,
		DuplicateName = 14,
		AccessDenied = 15,
		Timeout = 16,
		Banned = 17,
		AccountNotFound = 18,
		InvalidSteamID = 19,
		ServiceUnavailable = 20,
		NotLoggedOn = 21,
		Pending = 22,
		EncryptionFailure = 23,
		InsufficientPrivilege = 24,
		LimitExceeded = 25,
		Revoked = 26,
		Expired = 27,
		AlreadyRedeemed = 28,
		DuplicateRequest = 29,
		AlreadyOwned = 30,
		IPNotFound = 31,
		PersistFailed = 32,
		LockingFailed = 33,
		LogonSessionReplaced = 34,
		ConnectFailed = 35,
		HandshakeFailed = 36,
		IOFailure = 37,
		RemoteDisconnect = 38,
		ShoppingCartNotFound = 39,
		Blocked = 40,
		Ignored = 41,
		NoMatch = 42,
		AccountDisabled = 43,
		ServiceReadOnly = 44,
		AccountNotFeatured = 45,
		AdministratorOK = 46,
		ContentVersion = 47,
		TryAnotherCM = 48,
		PasswordRequiredToKickSession = 49,
		AlreadyLoggedInElsewhere = 50,
		Suspended = 51,
		Cancelled = 52,
		DataCorruption = 53,
		DiskFull = 54,
		RemoteCallFailed = 55,
		PasswordUnset = 56,
		ExternalAccountUnlinked = 57,
		PSNTicketInvalid = 58,
		ExternalAccountAlreadyLinked = 59,
		RemoteFileConflict = 60,
		IllegalPassword = 61,
		SameAsPreviousValue = 62,
		AccountLogonDenied = 63,
		CannotUseOldPassword = 64,
		InvalidLoginAuthCode = 65,
		AccountLogonDeniedNoMail = 66,
		HardwareNotCapableOfIPT = 67,
		IPTInitError = 68,
		ParentalControlRestricted = 69,
		FacebookQueryError = 70,
		ExpiredLoginAuthCode = 71,
		IPLoginRestrictionFailed = 72,
		AccountLockedDown = 73,
		AccountLogonDeniedVerifiedEmailRequired = 74,
		NoMatchingURL = 75,
		BadResponse = 76,
		RequirePasswordReEntry = 77,
		ValueOutOfRange = 78,
		UnexpectedError = 79,
		Disabled = 80,
		InvalidCEGSubmission = 81,
		RestrictedDevice = 82,
		RegionLocked = 83,
		RateLimitExceeded = 84,
		AccountLoginDeniedNeedTwoFactor = 85,
		ItemDeleted = 86,
		AccountLoginDeniedThrottle = 87,
		TwoFactorCodeMismatch = 88,
		TwoFactorActivationCodeMismatch = 89,
		AccountAssociatedToMultiplePartners = 90,
		NotModified = 91,
		NoMobileDevice = 92,
		TimeNotSynced = 93,
		SmsCodeFailed = 94,
		AccountLimitExceeded = 95,
		AccountActivityLimitExceeded = 96,
		PhoneActivityLimitExceeded = 97,
		RefundToWallet = 98,
		EmailSendFailure = 99,
		NotSettled = 100,
		NeedCaptcha = 101,
		GSLTDenied = 102,
		GSOwnerDenied = 103,
		InvalidItemType = 104,
		IPBanned = 105,
		GSLTExpired = 106,
	}
	
	//
	// EVoiceResult
	//
	public enum VoiceResult : int
	{
		OK = 0,
		NotInitialized = 1,
		NotRecording = 2,
		NoData = 3,
		BufferTooSmall = 4,
		DataCorrupted = 5,
		Restricted = 6,
		UnsupportedCodec = 7,
		ReceiverOutOfDate = 8,
		ReceiverDidNotAnswer = 9,
	}
	
	//
	// EDenyReason
	//
	public enum DenyReason : int
	{
		Invalid = 0,
		InvalidVersion = 1,
		Generic = 2,
		NotLoggedOn = 3,
		NoLicense = 4,
		Cheater = 5,
		LoggedInElseWhere = 6,
		UnknownText = 7,
		IncompatibleAnticheat = 8,
		MemoryCorruption = 9,
		IncompatibleSoftware = 10,
		SteamConnectionLost = 11,
		SteamConnectionError = 12,
		SteamResponseTimedOut = 13,
		SteamValidationStalled = 14,
		SteamOwnerLeftGuestUser = 15,
	}
	
	//
	// EBeginAuthSessionResult
	//
	public enum BeginAuthSessionResult : int
	{
		OK = 0,
		InvalidTicket = 1,
		DuplicateRequest = 2,
		InvalidVersion = 3,
		GameMismatch = 4,
		ExpiredTicket = 5,
	}
	
	//
	// EAuthSessionResponse
	//
	public enum AuthSessionResponse : int
	{
		OK = 0,
		UserNotConnectedToSteam = 1,
		NoLicenseOrExpired = 2,
		VACBanned = 3,
		LoggedInElseWhere = 4,
		VACCheckTimedOut = 5,
		AuthTicketCanceled = 6,
		AuthTicketInvalidAlreadyUsed = 7,
		AuthTicketInvalid = 8,
		PublisherIssuedBan = 9,
	}
	
	//
	// EUserHasLicenseForAppResult
	//
	public enum UserHasLicenseForAppResult : int
	{
		HasLicense = 0,
		DoesNotHaveLicense = 1,
		NoAuth = 2,
	}
	
	//
	// EAccountType
	//
	public enum AccountType : int
	{
		Invalid = 0,
		Individual = 1,
		Multiseat = 2,
		GameServer = 3,
		AnonGameServer = 4,
		Pending = 5,
		ContentServer = 6,
		Clan = 7,
		Chat = 8,
		ConsoleUser = 9,
		AnonUser = 10,
		Max = 11,
	}
	
	//
	// EAppReleaseState
	//
	public enum AppReleaseState : int
	{
		Unknown = 0,
		Unavailable = 1,
		Prerelease = 2,
		PreloadOnly = 3,
		Released = 4,
	}
	
	//
	// EAppOwnershipFlags
	//
	public enum AppOwnershipFlags : int
	{
		None = 0,
		OwnsLicense = 1,
		FreeLicense = 2,
		RegionRestricted = 4,
		LowViolence = 8,
		InvalidPlatform = 16,
		SharedLicense = 32,
		FreeWeekend = 64,
		RetailLicense = 128,
		LicenseLocked = 256,
		LicensePending = 512,
		LicenseExpired = 1024,
		LicensePermanent = 2048,
		LicenseRecurring = 4096,
		LicenseCanceled = 8192,
		AutoGrant = 16384,
		PendingGift = 32768,
		RentalNotActivated = 65536,
		Rental = 131072,
	}
	
	//
	// EAppType
	//
	public enum AppType : int
	{
		Invalid = 0,
		Game = 1,
		Application = 2,
		Tool = 4,
		Demo = 8,
		Media_DEPRECATED = 16,
		DLC = 32,
		Guide = 64,
		Driver = 128,
		Config = 256,
		Hardware = 512,
		Franchise = 1024,
		Video = 2048,
		Plugin = 4096,
		Music = 8192,
		Series = 16384,
		Shortcut = 1073741824,
		DepotOnly = -2147483648,
	}
	
	//
	// ESteamUserStatType
	//
	public enum SteamUserStatType : int
	{
		INVALID = 0,
		INT = 1,
		FLOAT = 2,
		AVGRATE = 3,
		ACHIEVEMENTS = 4,
		GROUPACHIEVEMENTS = 5,
		MAX = 6,
	}
	
	//
	// EChatEntryType
	//
	public enum ChatEntryType : int
	{
		Invalid = 0,
		ChatMsg = 1,
		Typing = 2,
		InviteGame = 3,
		Emote = 4,
		LeftConversation = 6,
		Entered = 7,
		WasKicked = 8,
		WasBanned = 9,
		Disconnected = 10,
		HistoricalChat = 11,
		LinkBlocked = 14,
	}
	
	//
	// EChatRoomEnterResponse
	//
	public enum ChatRoomEnterResponse : int
	{
		Success = 1,
		DoesntExist = 2,
		NotAllowed = 3,
		Full = 4,
		Error = 5,
		Banned = 6,
		Limited = 7,
		ClanDisabled = 8,
		CommunityBan = 9,
		MemberBlockedYou = 10,
		YouBlockedMember = 11,
	}
	
	//
	// EChatSteamIDInstanceFlags
	//
	public enum ChatSteamIDInstanceFlags : int
	{
		AccountInstanceMask = 4095,
		InstanceFlagClan = 524288,
		InstanceFlagLobby = 262144,
		InstanceFlagMMSLobby = 131072,
	}
	
	//
	// EMarketingMessageFlags
	//
	public enum MarketingMessageFlags : int
	{
		None = 0,
		HighPriority = 1,
		PlatformWindows = 2,
		PlatformMac = 4,
		PlatformLinux = 8,
		PlatformRestrictions = 14,
	}
	
	//
	// ENotificationPosition
	//
	public enum NotificationPosition : int
	{
		TopLeft = 0,
		TopRight = 1,
		BottomLeft = 2,
		BottomRight = 3,
	}
	
	//
	// EBroadcastUploadResult
	//
	public enum BroadcastUploadResult : int
	{
		None = 0,
		OK = 1,
		InitFailed = 2,
		FrameFailed = 3,
		Timeout = 4,
		BandwidthExceeded = 5,
		LowFPS = 6,
		MissingKeyFrames = 7,
		NoConnection = 8,
		RelayFailed = 9,
		SettingsChanged = 10,
		MissingAudio = 11,
		TooFarBehind = 12,
		TranscodeBehind = 13,
	}
	
	//
	// ELaunchOptionType
	//
	public enum LaunchOptionType : int
	{
		None = 0,
		Default = 1,
		SafeMode = 2,
		Multiplayer = 3,
		Config = 4,
		OpenVR = 5,
		Server = 6,
		Editor = 7,
		Manual = 8,
		Benchmark = 9,
		Option1 = 10,
		Option2 = 11,
		Option3 = 12,
		OculusVR = 13,
		OpenVROverlay = 14,
		OSVR = 15,
		Dialog = 1000,
	}
	
	//
	// EVRHMDType
	//
	public enum VRHMDType : int
	{
		None = -1,
		Unknown = 0,
		HTC_Dev = 1,
		HTC_VivePre = 2,
		HTC_Vive = 3,
		HTC_Unknown = 20,
		Oculus_DK1 = 21,
		Oculus_DK2 = 22,
		Oculus_Rift = 23,
		Oculus_Unknown = 40,
	}
	
	//
	// EControllerType
	//
	public enum ControllerType : int
	{
		None = -1,
		Unknown = 0,
		UnknownSteamController = 1,
		SteamController = 2,
		UnknownNonSteamController = 30,
		XBox360Controller = 31,
		XBoxOneController = 32,
		PS3Controller = 33,
		PS4Controller = 34,
		WiiController = 35,
		AppleController = 36,
	}
	
	//
	// CGameID::EGameIDType
	//
	public enum GameIDType : int
	{
		App = 0,
		GameMod = 1,
		Shortcut = 2,
		P2P = 3,
	}
	
	//
	// IPCFailure_t::EFailureType
	//
	public enum FailureType : int
	{
		FlushedCallbackQueue = 0,
		PipeFail = 1,
	}
	
	//
	// EFriendRelationship
	//
	public enum FriendRelationship : int
	{
		None = 0,
		Blocked = 1,
		RequestRecipient = 2,
		Friend = 3,
		RequestInitiator = 4,
		Ignored = 5,
		IgnoredFriend = 6,
		Suggested_DEPRECATED = 7,
		Max = 8,
	}
	
	//
	// EPersonaState
	//
	public enum PersonaState : int
	{
		Offline = 0,
		Online = 1,
		Busy = 2,
		Away = 3,
		Snooze = 4,
		LookingToTrade = 5,
		LookingToPlay = 6,
		Max = 7,
	}
	
	//
	// EFriendFlags
	//
	public enum FriendFlags : int
	{
		None = 0,
		Blocked = 1,
		FriendshipRequested = 2,
		Immediate = 4,
		ClanMember = 8,
		OnGameServer = 16,
		RequestingFriendship = 128,
		RequestingInfo = 256,
		Ignored = 512,
		IgnoredFriend = 1024,
		Suggested = 2048,
		ChatMember = 4096,
		All = 65535,
	}
	
	//
	// EUserRestriction
	//
	public enum UserRestriction : int
	{
		None = 0,
		Unknown = 1,
		AnyChat = 2,
		VoiceChat = 4,
		GroupChat = 8,
		Rating = 16,
		GameInvites = 32,
		Trading = 64,
	}
	
	//
	// EOverlayToStoreFlag
	//
	public enum OverlayToStoreFlag : int
	{
		None = 0,
		AddToCart = 1,
		AddToCartAndShow = 2,
	}
	
	//
	// EPersonaChange
	//
	public enum PersonaChange : int
	{
		Name = 1,
		Status = 2,
		ComeOnline = 4,
		GoneOffline = 8,
		GamePlayed = 16,
		GameServer = 32,
		Avatar = 64,
		JoinedSource = 128,
		LeftSource = 256,
		RelationshipChanged = 512,
		NameFirstSet = 1024,
		FacebookInfo = 2048,
		Nickname = 4096,
		SteamLevel = 8192,
	}
	
	//
	// ESteamAPICallFailure
	//
	public enum SteamAPICallFailure : int
	{
		None = -1,
		SteamGone = 0,
		NetworkFailure = 1,
		InvalidHandle = 2,
		MismatchedCallback = 3,
	}
	
	//
	// EGamepadTextInputMode
	//
	public enum GamepadTextInputMode : int
	{
		Normal = 0,
		Password = 1,
	}
	
	//
	// EGamepadTextInputLineMode
	//
	public enum GamepadTextInputLineMode : int
	{
		SingleLine = 0,
		MultipleLines = 1,
	}
	
	//
	// ECheckFileSignature
	//
	public enum CheckFileSignature : int
	{
		InvalidSignature = 0,
		ValidSignature = 1,
		FileNotFound = 2,
		NoSignaturesFoundForThisApp = 3,
		NoSignaturesFoundForThisFile = 4,
	}
	
	//
	// EMatchMakingServerResponse
	//
	public enum MatchMakingServerResponse : int
	{
		ServerResponded = 0,
		ServerFailedToRespond = 1,
		NoServersListedOnMasterServer = 2,
	}
	
	//
	// ELobbyType
	//
	public enum LobbyType : int
	{
		Private = 0,
		FriendsOnly = 1,
		Public = 2,
		Invisible = 3,
	}
	
	//
	// ELobbyComparison
	//
	public enum LobbyComparison : int
	{
		EqualToOrLessThan = -2,
		LessThan = -1,
		Equal = 0,
		GreaterThan = 1,
		EqualToOrGreaterThan = 2,
		NotEqual = 3,
	}
	
	//
	// ELobbyDistanceFilter
	//
	public enum LobbyDistanceFilter : int
	{
		Close = 0,
		Default = 1,
		Far = 2,
		Worldwide = 3,
	}
	
	//
	// EChatMemberStateChange
	//
	public enum ChatMemberStateChange : int
	{
		Entered = 1,
		Left = 2,
		Disconnected = 4,
		Kicked = 8,
		Banned = 16,
	}
	
	//
	// ERemoteStoragePlatform
	//
	public enum RemoteStoragePlatform : int
	{
		None = 0,
		Windows = 1,
		OSX = 2,
		PS3 = 4,
		Linux = 8,
		Reserved2 = 16,
		All = -1,
	}
	
	//
	// ERemoteStoragePublishedFileVisibility
	//
	public enum RemoteStoragePublishedFileVisibility : int
	{
		Public = 0,
		FriendsOnly = 1,
		Private = 2,
	}
	
	//
	// EWorkshopFileType
	//
	public enum WorkshopFileType : int
	{
		First = 0,
		Community = 0,
		Microtransaction = 1,
		Collection = 2,
		Art = 3,
		Video = 4,
		Screenshot = 5,
		Game = 6,
		Software = 7,
		Concept = 8,
		WebGuide = 9,
		IntegratedGuide = 10,
		Merch = 11,
		ControllerBinding = 12,
		SteamworksAccessInvite = 13,
		SteamVideo = 14,
		GameManagedItem = 15,
		Max = 16,
	}
	
	//
	// EWorkshopVote
	//
	public enum WorkshopVote : int
	{
		Unvoted = 0,
		For = 1,
		Against = 2,
		Later = 3,
	}
	
	//
	// EWorkshopFileAction
	//
	public enum WorkshopFileAction : int
	{
		Played = 0,
		Completed = 1,
	}
	
	//
	// EWorkshopEnumerationType
	//
	public enum WorkshopEnumerationType : int
	{
		RankedByVote = 0,
		Recent = 1,
		Trending = 2,
		FavoritesOfFriends = 3,
		VotedByFriends = 4,
		ContentByFriends = 5,
		RecentFromFollowedUsers = 6,
	}
	
	//
	// EWorkshopVideoProvider
	//
	public enum WorkshopVideoProvider : int
	{
		None = 0,
		Youtube = 1,
	}
	
	//
	// EUGCReadAction
	//
	public enum UGCReadAction : int
	{
		ontinueReadingUntilFinished = 0,
		ontinueReading = 1,
		lose = 2,
	}
	
	//
	// ELeaderboardDataRequest
	//
	public enum LeaderboardDataRequest : int
	{
		Global = 0,
		GlobalAroundUser = 1,
		Friends = 2,
		Users = 3,
	}
	
	//
	// ELeaderboardSortMethod
	//
	public enum LeaderboardSortMethod : int
	{
		None = 0,
		Ascending = 1,
		Descending = 2,
	}
	
	//
	// ELeaderboardDisplayType
	//
	public enum LeaderboardDisplayType : int
	{
		None = 0,
		Numeric = 1,
		TimeSeconds = 2,
		TimeMilliSeconds = 3,
	}
	
	//
	// ELeaderboardUploadScoreMethod
	//
	public enum LeaderboardUploadScoreMethod : int
	{
		None = 0,
		KeepBest = 1,
		ForceUpdate = 2,
	}
	
	//
	// ERegisterActivationCodeResult
	//
	public enum RegisterActivationCodeResult : int
	{
		ResultOK = 0,
		ResultFail = 1,
		ResultAlreadyRegistered = 2,
		ResultTimeout = 3,
		AlreadyOwned = 4,
	}
	
	//
	// EP2PSessionError
	//
	public enum P2PSessionError : int
	{
		None = 0,
		NotRunningApp = 1,
		NoRightsToApp = 2,
		DestinationNotLoggedIn = 3,
		Timeout = 4,
		Max = 5,
	}
	
	//
	// EP2PSend
	//
	public enum P2PSend : int
	{
		Unreliable = 0,
		UnreliableNoDelay = 1,
		Reliable = 2,
		ReliableWithBuffering = 3,
	}
	
	//
	// ESNetSocketState
	//
	public enum SNetSocketState : int
	{
		Invalid = 0,
		Connected = 1,
		Initiated = 10,
		LocalCandidatesFound = 11,
		ReceivedRemoteCandidates = 12,
		ChallengeHandshake = 15,
		Disconnecting = 21,
		LocalDisconnect = 22,
		TimeoutDuringConnect = 23,
		RemoteEndDisconnected = 24,
		ConnectionBroken = 25,
	}
	
	//
	// ESNetSocketConnectionType
	//
	public enum SNetSocketConnectionType : int
	{
		NotConnected = 0,
		UDP = 1,
		UDPRelay = 2,
	}
	
	//
	// EVRScreenshotType
	//
	public enum VRScreenshotType : int
	{
		None = 0,
		Mono = 1,
		Stereo = 2,
		MonoCubemap = 3,
		MonoPanorama = 4,
		StereoPanorama = 5,
	}
	
	//
	// AudioPlayback_Status
	//
	public enum AudioPlayback_Status : int
	{
		Undefined = 0,
		Playing = 1,
		Paused = 2,
		Idle = 3,
	}
	
	//
	// EHTTPMethod
	//
	public enum HTTPMethod : int
	{
		Invalid = 0,
		GET = 1,
		HEAD = 2,
		POST = 3,
		PUT = 4,
		DELETE = 5,
		OPTIONS = 6,
		PATCH = 7,
	}
	
	//
	// EHTTPStatusCode
	//
	public enum HTTPStatusCode : int
	{
		Invalid = 0,
		HTTPStatusCode100Continue = 100,
		HTTPStatusCode101SwitchingProtocols = 101,
		HTTPStatusCode200OK = 200,
		HTTPStatusCode201Created = 201,
		HTTPStatusCode202Accepted = 202,
		HTTPStatusCode203NonAuthoritative = 203,
		HTTPStatusCode204NoContent = 204,
		HTTPStatusCode205ResetContent = 205,
		HTTPStatusCode206PartialContent = 206,
		HTTPStatusCode300MultipleChoices = 300,
		HTTPStatusCode301MovedPermanently = 301,
		HTTPStatusCode302Found = 302,
		HTTPStatusCode303SeeOther = 303,
		HTTPStatusCode304NotModified = 304,
		HTTPStatusCode305UseProxy = 305,
		HTTPStatusCode307TemporaryRedirect = 307,
		HTTPStatusCode400BadRequest = 400,
		HTTPStatusCode401Unauthorized = 401,
		HTTPStatusCode402PaymentRequired = 402,
		HTTPStatusCode403Forbidden = 403,
		HTTPStatusCode404NotFound = 404,
		HTTPStatusCode405MethodNotAllowed = 405,
		HTTPStatusCode406NotAcceptable = 406,
		HTTPStatusCode407ProxyAuthRequired = 407,
		HTTPStatusCode408RequestTimeout = 408,
		HTTPStatusCode409Conflict = 409,
		HTTPStatusCode410Gone = 410,
		HTTPStatusCode411LengthRequired = 411,
		HTTPStatusCode412PreconditionFailed = 412,
		HTTPStatusCode413RequestEntityTooLarge = 413,
		HTTPStatusCode414RequestURITooLong = 414,
		HTTPStatusCode415UnsupportedMediaType = 415,
		HTTPStatusCode416RequestedRangeNotSatisfiable = 416,
		HTTPStatusCode417ExpectationFailed = 417,
		HTTPStatusCode4xxUnknown = 418,
		HTTPStatusCode429TooManyRequests = 429,
		HTTPStatusCode500InternalServerError = 500,
		HTTPStatusCode501NotImplemented = 501,
		HTTPStatusCode502BadGateway = 502,
		HTTPStatusCode503ServiceUnavailable = 503,
		HTTPStatusCode504GatewayTimeout = 504,
		HTTPStatusCode505HTTPVersionNotSupported = 505,
		HTTPStatusCode5xxUnknown = 599,
	}
	
	//
	// ESteamControllerPad
	//
	public enum SteamControllerPad : int
	{
		Left = 0,
		Right = 1,
	}
	
	//
	// EControllerSource
	//
	public enum ControllerSource : int
	{
		None = 0,
		LeftTrackpad = 1,
		RightTrackpad = 2,
		Joystick = 3,
		ABXY = 4,
		Switch = 5,
		LeftTrigger = 6,
		RightTrigger = 7,
		Gyro = 8,
		Count = 9,
	}
	
	//
	// EControllerSourceMode
	//
	public enum ControllerSourceMode : int
	{
		None = 0,
		Dpad = 1,
		Buttons = 2,
		FourButtons = 3,
		AbsoluteMouse = 4,
		RelativeMouse = 5,
		JoystickMove = 6,
		JoystickCamera = 7,
		ScrollWheel = 8,
		Trigger = 9,
		TouchMenu = 10,
		MouseJoystick = 11,
		MouseRegion = 12,
		RadialMenu = 13,
		Switches = 14,
	}
	
	//
	// EControllerActionOrigin
	//
	public enum ControllerActionOrigin : int
	{
		None = 0,
		A = 1,
		B = 2,
		X = 3,
		Y = 4,
		LeftBumper = 5,
		RightBumper = 6,
		LeftGrip = 7,
		RightGrip = 8,
		Start = 9,
		Back = 10,
		LeftPad_Touch = 11,
		LeftPad_Swipe = 12,
		LeftPad_Click = 13,
		LeftPad_DPadNorth = 14,
		LeftPad_DPadSouth = 15,
		LeftPad_DPadWest = 16,
		LeftPad_DPadEast = 17,
		RightPad_Touch = 18,
		RightPad_Swipe = 19,
		RightPad_Click = 20,
		RightPad_DPadNorth = 21,
		RightPad_DPadSouth = 22,
		RightPad_DPadWest = 23,
		RightPad_DPadEast = 24,
		LeftTrigger_Pull = 25,
		LeftTrigger_Click = 26,
		RightTrigger_Pull = 27,
		RightTrigger_Click = 28,
		LeftStick_Move = 29,
		LeftStick_Click = 30,
		LeftStick_DPadNorth = 31,
		LeftStick_DPadSouth = 32,
		LeftStick_DPadWest = 33,
		LeftStick_DPadEast = 34,
		Gyro_Move = 35,
		Gyro_Pitch = 36,
		Gyro_Yaw = 37,
		Gyro_Roll = 38,
		Count = 39,
	}
	
	//
	// EControllerActivationType
	//
	public enum ControllerActivationType : int
	{
		None = 0,
		FullPress = 1,
		SoftPress = 2,
		StartPress = 3,
		Release = 4,
		LongPress = 5,
		DoublePress = 6,
		Analog = 7,
	}
	
	//
	// EControllerPressureButton
	//
	public enum ControllerPressureButton : int
	{
		LeftTrackPad = 0,
		RightTrackPad = 1,
		LeftBumper = 2,
		RightBumper = 3,
		LeftGripLower = 4,
		RightGripLower = 5,
		LeftGripUpper = 6,
		RightGripUpper = 7,
		Invalid = 8,
	}
	
	//
	// EControllerActivatorOutputAxis
	//
	public enum ControllerActivatorOutputAxis : int
	{
		LeftTrigger = 0,
		RightTrigger = 1,
		LeftThumbXPos = 2,
		LeftThumbXNeg = 3,
		LeftThumbYPos = 4,
		LeftThumbYNeg = 5,
		RightThumbXPos = 6,
		RightThumbXNeg = 7,
		RightThumbYPos = 8,
		RightThumbYNeg = 9,
	}
	
	//
	// EControllerConfigFeature
	//
	public enum ControllerConfigFeature : int
	{
		None = 0,
		Gamepad = 1,
		Keyboard = 2,
		Mouse = 3,
		Gyro = 4,
		TouchMenu = 5,
		ModeShift = 6,
		ActionSet = 7,
		Activator = 8,
	}
	
	//
	// EControllerPopupMenuActivationType
	//
	public enum ControllerPopupMenuActivationType : int
	{
		ButtonPress = 0,
		ButtonRelease = 1,
		TouchRelease = 2,
		TouchAlways = 3,
	}
	
	//
	// EUGCMatchingUGCType
	//
	public enum UGCMatchingUGCType : int
	{
		Items = 0,
		Items_Mtx = 1,
		Items_ReadyToUse = 2,
		Collections = 3,
		Artwork = 4,
		Videos = 5,
		Screenshots = 6,
		AllGuides = 7,
		WebGuides = 8,
		IntegratedGuides = 9,
		UsableInGame = 10,
		ControllerBindings = 11,
		GameManagedItems = 12,
		All = -1,
	}
	
	//
	// EUserUGCList
	//
	public enum UserUGCList : int
	{
		Published = 0,
		VotedOn = 1,
		VotedUp = 2,
		VotedDown = 3,
		WillVoteLater = 4,
		Favorited = 5,
		Subscribed = 6,
		UsedOrPlayed = 7,
		Followed = 8,
	}
	
	//
	// EUserUGCListSortOrder
	//
	public enum UserUGCListSortOrder : int
	{
		CreationOrderDesc = 0,
		CreationOrderAsc = 1,
		TitleAsc = 2,
		LastUpdatedDesc = 3,
		SubscriptionDateDesc = 4,
		VoteScoreDesc = 5,
		ForModeration = 6,
	}
	
	//
	// EUGCQuery
	//
	public enum UGCQuery : int
	{
		RankedByVote = 0,
		RankedByPublicationDate = 1,
		AcceptedForGameRankedByAcceptanceDate = 2,
		RankedByTrend = 3,
		FavoritedByFriendsRankedByPublicationDate = 4,
		CreatedByFriendsRankedByPublicationDate = 5,
		RankedByNumTimesReported = 6,
		CreatedByFollowedUsersRankedByPublicationDate = 7,
		NotYetRated = 8,
		RankedByTotalVotesAsc = 9,
		RankedByVotesUp = 10,
		RankedByTextSearch = 11,
		RankedByTotalUniqueSubscriptions = 12,
		RankedByPlaytimeTrend = 13,
		RankedByTotalPlaytime = 14,
		RankedByAveragePlaytimeTrend = 15,
		RankedByLifetimeAveragePlaytime = 16,
		RankedByPlaytimeSessionsTrend = 17,
		RankedByLifetimePlaytimeSessions = 18,
	}
	
	//
	// EItemUpdateStatus
	//
	public enum ItemUpdateStatus : int
	{
		Invalid = 0,
		PreparingConfig = 1,
		PreparingContent = 2,
		UploadingContent = 3,
		UploadingPreviewFile = 4,
		CommittingChanges = 5,
	}
	
	//
	// EItemState
	//
	public enum ItemState : int
	{
		None = 0,
		Subscribed = 1,
		LegacyItem = 2,
		Installed = 4,
		NeedsUpdate = 8,
		Downloading = 16,
		DownloadPending = 32,
	}
	
	//
	// EItemStatistic
	//
	public enum ItemStatistic : int
	{
		NumSubscriptions = 0,
		NumFavorites = 1,
		NumFollowers = 2,
		NumUniqueSubscriptions = 3,
		NumUniqueFavorites = 4,
		NumUniqueFollowers = 5,
		NumUniqueWebsiteViews = 6,
		ReportScore = 7,
		NumSecondsPlayed = 8,
		NumPlaytimeSessions = 9,
		NumComments = 10,
	}
	
	//
	// EItemPreviewType
	//
	public enum ItemPreviewType : int
	{
		Image = 0,
		YouTubeVideo = 1,
		Sketchfab = 2,
		EnvironmentMap_HorizontalCross = 3,
		EnvironmentMap_LatLong = 4,
		ReservedMax = 255,
	}
	
	//
	// ISteamHTMLSurface::EHTMLMouseButton
	//
	public enum HTMLMouseButton : int
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}
	
	//
	// ISteamHTMLSurface::EMouseCursor
	//
	public enum MouseCursor : int
	{
		user = 0,
		none = 1,
		arrow = 2,
		ibeam = 3,
		hourglass = 4,
		waitarrow = 5,
		crosshair = 6,
		up = 7,
		sizenw = 8,
		sizese = 9,
		sizene = 10,
		sizesw = 11,
		sizew = 12,
		sizee = 13,
		sizen = 14,
		sizes = 15,
		sizewe = 16,
		sizens = 17,
		sizeall = 18,
		no = 19,
		hand = 20,
		blank = 21,
		middle_pan = 22,
		north_pan = 23,
		north_east_pan = 24,
		east_pan = 25,
		south_east_pan = 26,
		south_pan = 27,
		south_west_pan = 28,
		west_pan = 29,
		north_west_pan = 30,
		alias = 31,
		cell = 32,
		colresize = 33,
		copycur = 34,
		verticaltext = 35,
		rowresize = 36,
		zoomin = 37,
		zoomout = 38,
		help = 39,
		custom = 40,
		last = 41,
	}
	
	//
	// ISteamHTMLSurface::EHTMLKeyModifiers
	//
	public enum HTMLKeyModifiers : int
	{
		None = 0,
		AltDown = 1,
		CtrlDown = 2,
		ShiftDown = 4,
	}
	
	//
	// ESteamItemFlags
	//
	public enum SteamItemFlags : int
	{
		NoTrade = 1,
		Removed = 256,
		Consumed = 512,
	}
	
}
