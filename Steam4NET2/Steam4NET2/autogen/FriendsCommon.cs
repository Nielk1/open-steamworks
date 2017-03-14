// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EAvatarSize : int
	{
		k_EAvatarSize32x32 = 0,
		k_EAvatarSize64x64 = 1,
		k_EAvatarSize184x184 = 2,
		k_EAvatarSizeMAX = 3,
	};
	
	public enum ECallState : int
	{
		k_ECallStateUnknown = 0,
		k_ECallStateWaiting = 1,
		k_ECallStateDialing = 2,
		k_ECallStateRinging = 3,
		k_ECallStateInCall = 4,
	};
	
	public enum EChatEntryType : int
	{
		k_EChatEntryTypeInvalid = 0,
		k_EChatEntryTypeChatMsg = 1,
		k_EChatEntryTypeTyping = 2,
		k_EChatEntryTypeInviteGame = 3,
		k_EChatEntryTypeEmote = 4,
		k_EChatEntryTypeLeftConversation = 6,
		k_EChatEntryTypeEntered = 7,
		k_EChatEntryTypeWasKicked = 8,
		k_EChatEntryTypeWasBanned = 9,
		k_EChatEntryTypeDisconnected = 10,
		k_EChatEntryTypeHistoricalChat = 11,
		k_EChatEntryTypeReserved1 = 12,
		k_EChatEntryTypeReserved2 = 13,
		k_EChatEntryTypeLinkBlocked = 14,
	};
	
	public enum EFriendRelationship : int
	{
		k_EFriendRelationshipNone = 0,
		k_EFriendRelationshipBlocked = 1,
		k_EFriendRelationshipRequestRecipient = 2,
		k_EFriendRelationshipFriend = 3,
		k_EFriendRelationshipRequestInitiator = 4,
		k_EFriendRelationshipIgnored = 5,
		k_EFriendRelationshipIgnoredFriend = 6,
		k_EFriendRelationshipSuggested = 7,
		k_EFriendRelationshipMax = 8,
	};
	
	public enum EChatRoomType : int
	{
		k_EChatRoomTypeFriend = 1,
		k_EChatRoomTypeMUC = 2,
		k_EChatRoomTypeLobby = 3,
	};
	
	public enum EChatRoomVoiceStatus : int
	{
		eChatRoomVoiceStatus_Invalid = -1,
		eChatRoomVoiceStatus_Bad = 0,
		eChatRoomVoiceStatus_UnknownRoom = 1,
		eChatRoomVoiceStatus_UnknownUser = 2,
		eChatRoomVoiceStatus_NotSpeaking = 3,
		eChatRoomVoiceStatus_Connected_Speaking = 4,
		eChatRoomVoiceStatus_Connected_SpeakingData = 5,
		eChatRoomVoiceStatus_NotConnected_Speaking = 6,
		eChatRoomVoiceStatus_Connecting = 7,
		eChatRoomVoiceStatus_Unreachable = 8,
		eChatRoomVoiceStatus_Disconnected = 9,
		eChatRoomVoiceStatus_Count = 10,
	};
	
	public enum EClanRank : int
	{
		k_EClanRankNone = 0,
		k_EClanRankOwner = 1,
		k_EClanRankOfficer = 2,
		k_EClanRankMember = 3,
	};
	
	public enum EClanRelationship : int
	{
		eClanRelationshipNone = 0,
		eClanRelationshipBlocked = 1,
		eClanRelationshipInvited = 2,
		eClanRelationshipMember = 3,
		eClanRelationshipKicked = 4,
	};
	
	public enum EFriendFlags : int
	{
		k_EFriendFlagNone = 0,
		k_EFriendFlagBlocked = 1,
		k_EFriendFlagFriendshipRequested = 2,
		k_EFriendFlagImmediate = 4,
		k_EFriendFlagClanMember = 8,
		k_EFriendFlagOnGameServer = 16,
		k_EFriendFlagRequestingFriendship = 128,
		k_EFriendFlagRequestingInfo = 256,
		k_EFriendFlagIgnored = 512,
		k_EFriendFlagIgnoredFriend = 1024,
		k_EFriendFlagSuggested = 2048,
		k_EFriendFlagAll = 65535,
	};
	
	public enum EPersonaState : int
	{
		k_EPersonaStateOffline = 0,
		k_EPersonaStateOnline = 1,
		k_EPersonaStateBusy = 2,
		k_EPersonaStateAway = 3,
		k_EPersonaStateSnooze = 4,
		k_EPersonaStateLookingToTrade = 5,
		k_EPersonaStateLookingToPlay = 6,
		k_EPersonaStateMax = 7,
	};
	
	public enum EPersonaStateFlag : int
	{
		k_EPersonaStateFlagHasRichPresence = 1,
		k_EPersonaStateFlagInJoinableGame = 2,
	};
	
	public enum EPersonaChange : int
	{
		k_EPersonaChangeName = 1,
		k_EPersonaChangeStatus = 2,
		k_EPersonaChangeComeOnline = 4,
		k_EPersonaChangeGoneOffline = 8,
		k_EPersonaChangeGamePlayed = 16,
		k_EPersonaChangeGameServer = 32,
		k_EPersonaChangeAvatar = 64,
		k_EPersonaChangeJoinedSource = 128,
		k_EPersonaChangeLeftSource = 256,
		k_EPersonaChangeRelationshipChanged = 512,
		k_EPersonaChangeNameFirstSet = 1024,
		k_EPersonaChangeFacebookInfo = 2048,
	};
	
	public enum EChatPermission : int
	{
		k_EChatPermissionClose = 1,
		k_EChatPermissionInvite = 2,
		k_EChatPermissionTalk = 8,
		k_EChatPermissionKick = 16,
		k_EChatPermissionMute = 32,
		k_EChatPermissionSetMetadata = 64,
		k_EChatPermissionChangePermissions = 128,
		k_EChatPermissionBan = 256,
		k_EChatPermissionChangeAccess = 512,
		k_EChatPermissionEveryoneNotInClanDefault = 8,
		k_EChatPermissionEveryoneDefault = 10,
		k_EChatPermissionMemberDefault = 282,
		k_EChatPermissionOfficerDefault = 282,
		k_EChatPermissionOwnerDefault = 891,
		k_EChatPermissionMask = 1019,
	};
	
	public enum EChatRoomEnterResponse : int
	{
		k_EChatRoomEnterResponseSuccess = 1,
		k_EChatRoomEnterResponseDoesntExist = 2,
		k_EChatRoomEnterResponseNotAllowed = 3,
		k_EChatRoomEnterResponseFull = 4,
		k_EChatRoomEnterResponseError = 5,
		k_EChatRoomEnterResponseBanned = 6,
		k_EChatRoomEnterResponseLimited = 7,
		k_EChatRoomEnterResponseClanDisabled = 8,
		k_EChatRoomEnterResponseCommunityBan = 9,
		k_EChatRoomEnterResponseMemberBlockedYou = 10,
		k_EChatRoomEnterResponseYouBlockedMember = 11,
		k_EChatRoomEnterResponseNoRankingDataLobby = 12,
		k_EChatRoomEnterResponseNoRankingDataUser = 13,
		k_EChatRoomEnterResponseRankOutOfRange = 14,
	};
	
	public enum EChatAction : int
	{
		k_EChatActionInviteChat = 1,
		k_EChatActionKick = 2,
		k_EChatActionBan = 3,
		k_EChatActionUnBan = 4,
		k_EChatActionStartVoiceSpeak = 5,
		k_EChatActionEndVoiceSpeak = 6,
		k_EChatActionLockChat = 7,
		k_EChatActionUnlockChat = 8,
		k_EChatActionCloseChat = 9,
		k_EChatActionSetJoinable = 10,
		k_EChatActionSetUnjoinable = 11,
		k_EChatActionSetOwner = 12,
		k_EChatActionSetInvisibleToFriends = 13,
		k_EChatActionSetVisibleToFriends = 14,
		k_EChatActionSetModerated = 15,
		k_EChatActionSetUnmoderated = 16,
	};
	
	public enum EChatActionResult : int
	{
		k_EChatActionResultSuccess = 1,
		k_EChatActionResultError = 2,
		k_EChatActionResultNotPermitted = 3,
		k_EChatActionResultNotAllowedOnClanMember = 4,
		k_EChatActionResultNotAllowedOnBannedUser = 5,
		k_EChatActionResultNotAllowedOnChatOwner = 6,
		k_EChatActionResultNotAllowedOnSelf = 7,
		k_EChatActionResultChatDoesntExist = 8,
		k_EChatActionResultChatFull = 9,
		k_EChatActionResultVoiceSlotsFull = 10,
	};
	
	public enum EUserRestriction : int
	{
		k_nUserRestrictionNone = 0,
		k_nUserRestrictionUnknown = 1,
		k_nUserRestrictionAnyChat = 2,
		k_nUserRestrictionVoiceChat = 4,
		k_nUserRestrictionGroupChat = 8,
		k_nUserRestrictionRating = 16,
		k_nUserRestrictionGameInvites = 32,
		k_nUserRestrictionTrading = 64,
	};
	
	public enum EOverlayToStoreFlag : int
	{
		k_EOverlayToStoreFlagNone = 0,
		k_EOverlayToStoreFlagAddToCart = 1,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct FriendSessionStateInfo_t
	{
		public UInt32 m_uiOnlineSessionInstances;
		public Byte m_uiPublishedToFriendsSessionInstance;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(304)]
	public struct PersonaStateChange_t
	{
		public const int k_iCallback = 304;
		public SteamID_t m_ulSteamID;
		public EPersonaChange m_nChangeFlags;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(331)]
	public struct GameOverlayActivated_t
	{
		public const int k_iCallback = 331;
		public Byte m_bActive;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(332)]
	public struct GameServerChangeRequested_t
	{
		public const int k_iCallback = 332;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchServer;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchPassword;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(333)]
	public struct GameLobbyJoinRequested_t
	{
		public const int k_iCallback = 333;
		public SteamID_t m_steamIDLobby;
		public SteamID_t m_steamIDFriend;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(334)]
	public struct AvatarImageLoaded_t
	{
		public const int k_iCallback = 334;
		public SteamID_t m_steamID;
		public Int32 m_iImage;
		public Int32 m_iWide;
		public Int32 m_iTall;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(335)]
	public struct ClanOfficerListResponse_t
	{
		public const int k_iCallback = 335;
		public SteamID_t m_steamIDClan;
		public Int32 m_cOfficers;
		public Byte m_bSuccess;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(336)]
	public struct FriendRichPresenceUpdate_t
	{
		public const int k_iCallback = 336;
		public SteamID_t m_steamIDFriend;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(337)]
	public struct GameRichPresenceJoinRequested_t
	{
		public const int k_iCallback = 337;
		public SteamID_t m_steamIDFriend;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchConnect;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(338)]
	public struct GameConnectedClanChatMsg_t
	{
		public const int k_iCallback = 338;
		public SteamID_t m_steamIDClanChat;
		public SteamID_t m_steamIDUser;
		public Int32 m_iMessageID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(339)]
	public struct GameConnectedChatJoin_t
	{
		public const int k_iCallback = 339;
		public SteamID_t m_steamIDClanChat;
		public SteamID_t m_steamIDUser;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(340)]
	public struct GameConnectedChatLeave_t
	{
		public const int k_iCallback = 340;
		public SteamID_t m_steamIDClanChat;
		public SteamID_t m_steamIDUser;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bKicked;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDropped;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(341)]
	public struct DownloadClanActivityCountsResult_t
	{
		public const int k_iCallback = 341;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccess;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(342)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		public const int k_iCallback = 342;
		public SteamID_t m_steamIDClanChat;
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(343)]
	public struct GameConnectedFriendChatMsg_t
	{
		public const int k_iCallback = 343;
		public SteamID_t m_steamIDUser;
		public Int32 m_iMessageID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(344)]
	public struct FriendsGetFollowerCount_t
	{
		public const int k_iCallback = 344;
		public EResult m_eResult;
		public SteamID_t m_steamID;
		public Int32 m_cCount;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(345)]
	public struct FriendsIsFollowing_t
	{
		public const int k_iCallback = 345;
		public EResult m_eResult;
		public SteamID_t m_steamID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsFollowing;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(346)]
	public struct FriendsEnumerateFollowingList_t
	{
		public const int k_iCallback = 346;
		public EResult m_eResult;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public SteamID_t[] m_steamIDs;
		public Int32 m_cSteamIDs;
		public Int32 m_cTotalResults;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(347)]
	public struct SetPersonaNameResponse_t
	{
		public const int k_iCallback = 347;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccess;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocalSuccess;
		public EResult m_result;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(801)]
	public struct GameOverlayActivateRequested_t
	{
		public const int k_iCallback = 801;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchDialog;
		public SteamID_t m_steamIDTarget;
		public UInt32 m_nAppID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bWebPage;
		public EOverlayToStoreFlag m_eFlag;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(802)]
	public struct ClanEventReceived_t
	{
		public const int k_iCallback = 802;
		public UInt64 m_gidEvent;
		public UInt64 m_ulSteamIDClan;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchTitle;
		public UInt32 m_nStartTime;
		public GameID_t m_GameID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(803)]
	public struct FriendAdded_t
	{
		public const int k_iCallback = 803;
		public EResult m_eResult;
		public UInt64 m_ulSteamID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(804)]
	public struct UserRequestingFriendship_t
	{
		public const int k_iCallback = 804;
		public SteamID_t m_ulSteamID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(805)]
	public struct FriendChatMsg_t
	{
		public const int k_iCallback = 805;
		public SteamID_t m_ulFriendID;
		public SteamID_t m_ulSenderID;
		public Byte m_eChatEntryType;
		public Byte m_bLimitedAccount;
		public UInt32 m_iChatID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(806)]
	public struct FriendInvited_t
	{
		public const int k_iCallback = 806;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(807)]
	public struct ChatRoomInvite_t
	{
		public const int k_iCallback = 807;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDPatron;
		public SteamID_t m_ulSteamIDFriendChat;
		public EChatRoomType m_EChatRoomType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchChatRoomName;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(808)]
	public struct ChatRoomEnter_t
	{
		public const int k_iCallback = 808;
		public SteamID_t m_ulSteamIDChat;
		public EChatRoomType m_EChatRoomType;
		public UInt64 m_ulSteamIDOwner;
		public SteamID_t m_ulSteamIDClan;
		public SteamID_t m_ulSteamIDFriendChat;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocked;
		public UInt32 m_rgfChatPermissions;
		public EChatRoomEnterResponse m_EChatRoomEnterResponse;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchChatRoomName;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(809)]
	public struct ChatMemberStateChange_t
	{
		public const int k_iCallback = 809;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDUserChanged;
		public EChatMemberStateChange m_rgfChatMemberStateChange;
		public UInt64 m_ulSteamIDMakingChange;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(810)]
	public struct ChatRoomMsg_t
	{
		public const int k_iCallback = 810;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDUser;
		public Byte m_eChatEntryType;
		public UInt32 m_iChatID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(811)]
	public struct ChatRoomDlgClose_t
	{
		public const int k_iCallback = 811;
		public SteamID_t m_ulSteamIDChat;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(812)]
	public struct ChatRoomClosing_t
	{
		public const int k_iCallback = 812;
		public SteamID_t m_ulSteamIDChat;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(813)]
	public struct ChatRoomKicking_t
	{
		public const int k_iCallback = 813;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDAdmin;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(814)]
	public struct ChatRoomBanning_t
	{
		public const int k_iCallback = 814;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDAdmin;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(815)]
	public struct ChatRoomCreate_t
	{
		public const int k_iCallback = 815;
		public EResult m_eResult;
		public UInt64 m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDFriendChat;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(816)]
	public struct OpenChatDialog_t
	{
		public const int k_iCallback = 816;
		public SteamID_t m_ulSteamID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(817)]
	public struct ChatRoomActionResult_t
	{
		public const int k_iCallback = 817;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDUserActedOn;
		public EChatAction m_EChatAction;
		public EChatActionResult m_EChatActionResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(818)]
	public struct ChatRoomDlgSerialized_t
	{
		public const int k_iCallback = 818;
		public SteamID_t m_ulSteamID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(819)]
	public struct ClanInfoChanged_t
	{
		public const int k_iCallback = 819;
		public SteamID_t m_ulSteamID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bNameChanged;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAvatarChanged;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAccountInfoChanged;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(820)]
	public struct ChatMemberInfoChanged_t
	{
		public const int k_iCallback = 820;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDUser;
		public UInt32 m_rgfChatMemberPermissions;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(821)]
	public struct ChatRoomInfoChanged_t
	{
		public const int k_iCallback = 821;
		public SteamID_t m_ulSteamIDChat;
		public UInt32 m_rgfChatRoomDetails;
		public UInt64 m_ulSteamIDMakingChange;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(822)]
	public struct SteamRackBouncing_t
	{
		public const int k_iCallback = 822;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(823)]
	public struct ChatRoomSpeakChanged_t
	{
		public const int k_iCallback = 823;
		public SteamID_t m_ulSteamIDChat;
		public SteamID_t m_ulSteamIDUser;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSpeaking;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(824)]
	public struct NotifyIncomingCall_t
	{
		public const int k_iCallback = 824;
		public Int32 m_Handle;
		public UInt64 m_ulSteamID;
		public SteamID_t m_ulSteamIDChat;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIncoming;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(825)]
	public struct NotifyHangup_t
	{
		public const int k_iCallback = 825;
		public Int32 m_Handle;
		public EVoiceResult m_eVoiceResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(826)]
	public struct NotifyRequestResume_t
	{
		public const int k_iCallback = 826;
		public Int32 m_Handle;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(827)]
	public struct NotifyChatRoomVoiceStateChanged_t
	{
		public const int k_iCallback = 827;
		public SteamID_t m_steamChatRoom;
		public SteamID_t m_steamUser;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(828)]
	public struct ChatRoomDlgUIChange_t
	{
		public const int k_iCallback = 828;
		public SteamID_t m_SteamIDChat;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShowAvatars;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBeepOnNewMsg;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShowSteamIDs;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShowTimestampOnNewMsg;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(829)]
	public struct VoiceCallInitiated_t
	{
		public const int k_iCallback = 829;
		public UInt64 m_ulSteamIDUser;
		public UInt64 m_ulSteamIDFriend;
		public Int32 m_hVoiceCall;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(830)]
	public struct FriendIgnored_t
	{
		public const int k_iCallback = 830;
		public EResult m_eResult;
		public UInt64 m_ulSteamID;
		public SteamID_t m_ulSteamIDFriend;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIgnored;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(831)]
	public struct VoiceInputDeviceChanged_t
	{
		public const int k_iCallback = 831;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(832)]
	public struct VoiceEnabledStateChanged_t
	{
		public const int k_iCallback = 832;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVoiceEnabled;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(833)]
	public struct FriendsWhoPlayGameUpdate_t
	{
		public const int k_iCallback = 833;
		public GameID_t m_gameID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(834)]
	public struct FriendProfileInfoResponse_t
	{
		public const int k_iCallback = 834;
		public SteamID_t m_steamIDFriend;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(835)]
	public struct RichInviteReceived_t
	{
		public const int k_iCallback = 835;
		public SteamID_t m_steamIDFriend;
		public UInt32 m_nAppID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchConnect;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(836)]
	public struct FriendsMenuChange_t
	{
		public const int k_iCallback = 836;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShowAvatars;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSortByName;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShowOnlineFriendsOnly;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShowUntaggedFriends;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(837)]
	public struct TradeInviteReceived_t
	{
		public const int k_iCallback = 837;
		public SteamID_t m_steamIDPartner;
		public UInt32 m_unTradeRequestID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(838)]
	public struct TradeInviteResponse_t
	{
		public const int k_iCallback = 838;
		public SteamID_t m_steamIDPartner;
		public UInt32 m_eResponse;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(839)]
	public struct TradeStartSession_t
	{
		public const int k_iCallback = 839;
		public SteamID_t m_steamIDPartner;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(840)]
	public struct TradeInviteCanceled_t
	{
		public const int k_iCallback = 840;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(841)]
	public struct GameUsingVoice_t
	{
		public const int k_iCallback = 841;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(842)]
	public struct FriendsGroupCreated_t
	{
		public const int k_iCallback = 842;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(843)]
	public struct FriendsGroupDeleted_t
	{
		public const int k_iCallback = 843;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(844)]
	public struct FriendsGroupRenamed_t
	{
		public const int k_iCallback = 844;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(845)]
	public struct FriendsGroupMemberAdded_t
	{
		public const int k_iCallback = 845;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(846)]
	public struct FriendsGroupMemberRemoved_t
	{
		public const int k_iCallback = 846;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(847)]
	public struct NameHistoryResponse_t
	{
		public const int k_iCallback = 847;
		public Int32 m_cSuccessfulLookups;
		public Int32 m_cFailedLookups;
	};
	
}
