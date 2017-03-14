// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamFriends015VTable
	{
		public IntPtr GetPersonaName0;
		public IntPtr SetPersonaName1;
		public IntPtr GetPersonaState2;
		public IntPtr GetFriendCount3;
		public IntPtr GetFriendByIndex4;
		public IntPtr GetFriendRelationship5;
		public IntPtr GetFriendPersonaState6;
		public IntPtr GetFriendPersonaName7;
		public IntPtr GetFriendGamePlayed8;
		public IntPtr GetFriendPersonaNameHistory9;
		public IntPtr GetFriendSteamLevel10;
		public IntPtr GetPlayerNickname11;
		public IntPtr GetFriendsGroupCount12;
		public IntPtr GetFriendsGroupIDByIndex13;
		public IntPtr GetFriendsGroupName14;
		public IntPtr GetFriendsGroupMembersCount15;
		public IntPtr GetFriendsGroupMembersList16;
		public IntPtr HasFriend17;
		public IntPtr GetClanCount18;
		public IntPtr GetClanByIndex19;
		public IntPtr GetClanName20;
		public IntPtr GetClanTag21;
		public IntPtr GetClanActivityCounts22;
		public IntPtr DownloadClanActivityCounts23;
		public IntPtr GetFriendCountFromSource24;
		public IntPtr GetFriendFromSourceByIndex25;
		public IntPtr IsUserInSource26;
		public IntPtr SetInGameVoiceSpeaking27;
		public IntPtr ActivateGameOverlay28;
		public IntPtr ActivateGameOverlayToUser29;
		public IntPtr ActivateGameOverlayToWebPage30;
		public IntPtr ActivateGameOverlayToStore31;
		public IntPtr SetPlayedWith32;
		public IntPtr ActivateGameOverlayInviteDialog33;
		public IntPtr GetSmallFriendAvatar34;
		public IntPtr GetMediumFriendAvatar35;
		public IntPtr GetLargeFriendAvatar36;
		public IntPtr RequestUserInformation37;
		public IntPtr RequestClanOfficerList38;
		public IntPtr GetClanOwner39;
		public IntPtr GetClanOfficerCount40;
		public IntPtr GetClanOfficerByIndex41;
		public IntPtr GetUserRestrictions42;
		public IntPtr SetRichPresence43;
		public IntPtr ClearRichPresence44;
		public IntPtr GetFriendRichPresence45;
		public IntPtr GetFriendRichPresenceKeyCount46;
		public IntPtr GetFriendRichPresenceKeyByIndex47;
		public IntPtr RequestFriendRichPresence48;
		public IntPtr InviteUserToGame49;
		public IntPtr GetCoplayFriendCount50;
		public IntPtr GetCoplayFriend51;
		public IntPtr GetFriendCoplayTime52;
		public IntPtr GetFriendCoplayGame53;
		public IntPtr JoinClanChatRoom54;
		public IntPtr LeaveClanChatRoom55;
		public IntPtr GetClanChatMemberCount56;
		public IntPtr GetChatMemberByIndex57;
		public IntPtr SendClanChatMessage58;
		public IntPtr GetClanChatMessage59;
		public IntPtr IsClanChatAdmin60;
		public IntPtr IsClanChatWindowOpenInSteam61;
		public IntPtr OpenClanChatWindowInSteam62;
		public IntPtr CloseClanChatWindowInSteam63;
		public IntPtr SetListenForFriendsMessages64;
		public IntPtr ReplyToFriendMessage65;
		public IntPtr GetFriendMessage66;
		public IntPtr GetFollowerCount67;
		public IntPtr IsFollowing68;
		public IntPtr EnumerateFollowingList69;
		private IntPtr DTorISteamFriends01570;
	};
	
	[InteropHelp.InterfaceVersion("SteamFriends015")]
	public class ISteamFriends015 : InteropHelp.NativeWrapper<ISteamFriends015VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetPersonaName( IntPtr thisptr );
		public string GetPersonaName(  ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetPersonaName>( this.Functions.GetPersonaName0 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSetPersonaNameS( IntPtr thisptr, IntPtr pchPersonaName );
		public UInt64 SetPersonaName( string pchPersonaName ) 
		{
			return this.GetFunction<NativeSetPersonaNameS>( this.Functions.SetPersonaName1 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchPersonaName ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetPersonaState( IntPtr thisptr );
		public EPersonaState GetPersonaState(  ) 
		{
			return this.GetFunction<NativeGetPersonaState>( this.Functions.GetPersonaState2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountI( IntPtr thisptr, Int32 iFriendFlags );
		public Int32 GetFriendCount( Int32 iFriendFlags ) 
		{
			return this.GetFunction<NativeGetFriendCountI>( this.Functions.GetFriendCount3 )( this.ObjectAddress, iFriendFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendByIndexII( IntPtr thisptr, ref UInt64 retarg, Int32 iFriend, Int32 iFriendFlags );
		public CSteamID GetFriendByIndex( Int32 iFriend, Int32 iFriendFlags ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendByIndexII>( this.Functions.GetFriendByIndex4 )( this.ObjectAddress, ref ret, iFriend, iFriendFlags ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EFriendRelationship NativeGetFriendRelationshipC( IntPtr thisptr, UInt64 steamIDFriend );
		public EFriendRelationship GetFriendRelationship( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendRelationshipC>( this.Functions.GetFriendRelationship5 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetFriendPersonaStateC( IntPtr thisptr, UInt64 steamIDFriend );
		public EPersonaState GetFriendPersonaState( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendPersonaStateC>( this.Functions.GetFriendPersonaState6 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameC( IntPtr thisptr, UInt64 steamIDFriend );
		public string GetFriendPersonaName( CSteamID steamIDFriend ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetFriendPersonaNameC>( this.Functions.GetFriendPersonaName7 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFriendGamePlayedCF( IntPtr thisptr, UInt64 steamID, ref FriendGameInfo_t pGamePlayInfo );
		public bool GetFriendGamePlayed( CSteamID steamID, ref FriendGameInfo_t pGamePlayInfo ) 
		{
			return this.GetFunction<NativeGetFriendGamePlayedCF>( this.Functions.GetFriendGamePlayed8 )( this.ObjectAddress, steamID.ConvertToUint64(), ref pGamePlayInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameHistoryCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iPersonaName );
		public string GetFriendPersonaNameHistory( CSteamID steamIDFriend, Int32 iPersonaName ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetFriendPersonaNameHistoryCI>( this.Functions.GetFriendPersonaNameHistory9 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iPersonaName ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendSteamLevelC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetFriendSteamLevel( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendSteamLevelC>( this.Functions.GetFriendSteamLevel10 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetPlayerNicknameC( IntPtr thisptr, UInt64 steamIDPlayer );
		public string GetPlayerNickname( CSteamID steamIDPlayer ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetPlayerNicknameC>( this.Functions.GetPlayerNickname11 )( this.ObjectAddress, steamIDPlayer.ConvertToUint64() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int16 NativeGetFriendsGroupCount( IntPtr thisptr );
		public Int16 GetFriendsGroupCount(  ) 
		{
			return this.GetFunction<NativeGetFriendsGroupCount>( this.Functions.GetFriendsGroupCount12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int16 NativeGetFriendsGroupIDByIndexI( IntPtr thisptr, Int32 arg0 );
		public Int16 GetFriendsGroupIDByIndex( Int32 arg0 ) 
		{
			return this.GetFunction<NativeGetFriendsGroupIDByIndexI>( this.Functions.GetFriendsGroupIDByIndex13 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendsGroupNameI( IntPtr thisptr, Int16 arg0 );
		public string GetFriendsGroupName( Int16 arg0 ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetFriendsGroupNameI>( this.Functions.GetFriendsGroupName14 )( this.ObjectAddress, arg0 ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendsGroupMembersCountI( IntPtr thisptr, Int16 arg0 );
		public Int32 GetFriendsGroupMembersCount( Int16 arg0 ) 
		{
			return this.GetFunction<NativeGetFriendsGroupMembersCountI>( this.Functions.GetFriendsGroupMembersCount15 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendsGroupMembersListICI( IntPtr thisptr, Int16 arg0, ref UInt64 arg1, Int32 arg2 );
		public Int32 GetFriendsGroupMembersList( Int16 arg0, ref CSteamID arg1, Int32 arg2 ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetFriendsGroupMembersListICI>( this.Functions.GetFriendsGroupMembersList16 )( this.ObjectAddress, arg0, ref s0, arg2 ); arg1 = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHasFriendCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iFriendFlags );
		public bool HasFriend( CSteamID steamIDFriend, Int32 iFriendFlags ) 
		{
			return this.GetFunction<NativeHasFriendCI>( this.Functions.HasFriend17 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iFriendFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanCount( IntPtr thisptr );
		public Int32 GetClanCount(  ) 
		{
			return this.GetFunction<NativeGetClanCount>( this.Functions.GetClanCount18 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iClan );
		public CSteamID GetClanByIndex( Int32 iClan ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanByIndexI>( this.Functions.GetClanByIndex19 )( this.ObjectAddress, ref ret, iClan ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetClanNameC( IntPtr thisptr, UInt64 steamIDClan );
		public string GetClanName( CSteamID steamIDClan ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetClanNameC>( this.Functions.GetClanName20 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetClanTagC( IntPtr thisptr, UInt64 steamIDClan );
		public string GetClanTag( CSteamID steamIDClan ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetClanTagC>( this.Functions.GetClanTag21 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetClanActivityCountsCIII( IntPtr thisptr, UInt64 steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting );
		public bool GetClanActivityCounts( CSteamID steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting ) 
		{
			return this.GetFunction<NativeGetClanActivityCountsCIII>( this.Functions.GetClanActivityCounts22 )( this.ObjectAddress, steamID.ConvertToUint64(), ref pnOnline, ref pnInGame, ref pnChatting ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadClanActivityCountsCI( IntPtr thisptr, ref UInt64 groupIDs, Int32 nIds );
		public UInt64 DownloadClanActivityCounts( ref CSteamID groupIDs, Int32 nIds ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeDownloadClanActivityCountsCI>( this.Functions.DownloadClanActivityCounts23 )( this.ObjectAddress, ref s0, nIds ); groupIDs = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountFromSourceC( IntPtr thisptr, UInt64 steamIDSource );
		public Int32 GetFriendCountFromSource( CSteamID steamIDSource ) 
		{
			return this.GetFunction<NativeGetFriendCountFromSourceC>( this.Functions.GetFriendCountFromSource24 )( this.ObjectAddress, steamIDSource.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendFromSourceByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDSource, Int32 iFriend );
		public CSteamID GetFriendFromSourceByIndex( CSteamID steamIDSource, Int32 iFriend ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendFromSourceByIndexCI>( this.Functions.GetFriendFromSourceByIndex25 )( this.ObjectAddress, ref ret, steamIDSource.ConvertToUint64(), iFriend ); return new CSteamID(ret);
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsUserInSourceCC( IntPtr thisptr, UInt64 steamIDUser, UInt64 steamIDSource );
		public bool IsUserInSource( CSteamID steamIDUser, CSteamID steamIDSource ) 
		{
			return this.GetFunction<NativeIsUserInSourceCC>( this.Functions.IsUserInSource26 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), steamIDSource.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetInGameVoiceSpeakingCB( IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking );
		public void SetInGameVoiceSpeaking( CSteamID steamIDUser, bool bSpeaking ) 
		{
			this.GetFunction<NativeSetInGameVoiceSpeakingCB>( this.Functions.SetInGameVoiceSpeaking27 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), bSpeaking ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayS( IntPtr thisptr, IntPtr pchDialog );
		public void ActivateGameOverlay( string pchDialog ) 
		{
			this.GetFunction<NativeActivateGameOverlayS>( this.Functions.ActivateGameOverlay28 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchDialog ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToUserSC( IntPtr thisptr, IntPtr pchDialog, UInt64 steamID );
		public void ActivateGameOverlayToUser( string pchDialog, CSteamID steamID ) 
		{
			this.GetFunction<NativeActivateGameOverlayToUserSC>( this.Functions.ActivateGameOverlayToUser29 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchDialog ).GetMarshaledBytes(), steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToWebPageS( IntPtr thisptr, IntPtr pchURL );
		public void ActivateGameOverlayToWebPage( string pchURL ) 
		{
			this.GetFunction<NativeActivateGameOverlayToWebPageS>( this.Functions.ActivateGameOverlayToWebPage30 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchURL ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToStoreUE( IntPtr thisptr, UInt32 nAppID, EOverlayToStoreFlag eFlag );
		public void ActivateGameOverlayToStore( UInt32 nAppID, EOverlayToStoreFlag eFlag ) 
		{
			this.GetFunction<NativeActivateGameOverlayToStoreUE>( this.Functions.ActivateGameOverlayToStore31 )( this.ObjectAddress, nAppID, eFlag ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPlayedWithC( IntPtr thisptr, UInt64 steamIDUserPlayedWith );
		public void SetPlayedWith( CSteamID steamIDUserPlayedWith ) 
		{
			this.GetFunction<NativeSetPlayedWithC>( this.Functions.SetPlayedWith32 )( this.ObjectAddress, steamIDUserPlayedWith.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayInviteDialogC( IntPtr thisptr, UInt64 steamIDLobby );
		public void ActivateGameOverlayInviteDialog( CSteamID steamIDLobby ) 
		{
			this.GetFunction<NativeActivateGameOverlayInviteDialogC>( this.Functions.ActivateGameOverlayInviteDialog33 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetSmallFriendAvatarC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetSmallFriendAvatar( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetSmallFriendAvatarC>( this.Functions.GetSmallFriendAvatar34 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMediumFriendAvatarC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetMediumFriendAvatar( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetMediumFriendAvatarC>( this.Functions.GetMediumFriendAvatar35 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLargeFriendAvatarC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetLargeFriendAvatar( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetLargeFriendAvatarC>( this.Functions.GetLargeFriendAvatar36 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestUserInformationCB( IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly );
		public bool RequestUserInformation( CSteamID steamIDUser, bool bRequireNameOnly ) 
		{
			return this.GetFunction<NativeRequestUserInformationCB>( this.Functions.RequestUserInformation37 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), bRequireNameOnly ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestClanOfficerListC( IntPtr thisptr, UInt64 steamIDClan );
		public UInt64 RequestClanOfficerList( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeRequestClanOfficerListC>( this.Functions.RequestClanOfficerList38 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanOwnerC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan );
		public CSteamID GetClanOwner( CSteamID steamIDClan ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanOwnerC>( this.Functions.GetClanOwner39 )( this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64() ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanOfficerCountC( IntPtr thisptr, UInt64 steamIDClan );
		public Int32 GetClanOfficerCount( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeGetClanOfficerCountC>( this.Functions.GetClanOfficerCount40 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanOfficerByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan, Int32 iOfficer );
		public CSteamID GetClanOfficerByIndex( CSteamID steamIDClan, Int32 iOfficer ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanOfficerByIndexCI>( this.Functions.GetClanOfficerByIndex41 )( this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64(), iOfficer ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserRestriction NativeGetUserRestrictions( IntPtr thisptr );
		public EUserRestriction GetUserRestrictions(  ) 
		{
			return this.GetFunction<NativeGetUserRestrictions>( this.Functions.GetUserRestrictions42 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetRichPresenceSS( IntPtr thisptr, IntPtr pchKey, IntPtr pchValue );
		public bool SetRichPresence( string pchKey, string pchValue ) 
		{
			return this.GetFunction<NativeSetRichPresenceSS>( this.Functions.SetRichPresence43 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchKey ).GetMarshaledBytes(), InteropHelp.Utf8StringToPtr( pchValue ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearRichPresence( IntPtr thisptr );
		public void ClearRichPresence(  ) 
		{
			this.GetFunction<NativeClearRichPresence>( this.Functions.ClearRichPresence44 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRichPresenceCS( IntPtr thisptr, UInt64 steamIDFriend, IntPtr pchKey );
		public string GetFriendRichPresence( CSteamID steamIDFriend, string pchKey ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetFriendRichPresenceCS>( this.Functions.GetFriendRichPresence45 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchKey ).GetMarshaledBytes() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendRichPresenceKeyCountC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetFriendRichPresenceKeyCount( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendRichPresenceKeyCountC>( this.Functions.GetFriendRichPresenceKeyCount46 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRichPresenceKeyByIndexCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iKey );
		public string GetFriendRichPresenceKeyByIndex( CSteamID steamIDFriend, Int32 iKey ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetFriendRichPresenceKeyByIndexCI>( this.Functions.GetFriendRichPresenceKeyByIndex47 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestFriendRichPresenceC( IntPtr thisptr, UInt64 steamIDFriend );
		public void RequestFriendRichPresence( CSteamID steamIDFriend ) 
		{
			this.GetFunction<NativeRequestFriendRichPresenceC>( this.Functions.RequestFriendRichPresence48 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToGameCS( IntPtr thisptr, UInt64 steamIDFriend, IntPtr pchConnectString );
		public bool InviteUserToGame( CSteamID steamIDFriend, string pchConnectString ) 
		{
			return this.GetFunction<NativeInviteUserToGameCS>( this.Functions.InviteUserToGame49 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchConnectString ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCoplayFriendCount( IntPtr thisptr );
		public Int32 GetCoplayFriendCount(  ) 
		{
			return this.GetFunction<NativeGetCoplayFriendCount>( this.Functions.GetCoplayFriendCount50 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetCoplayFriendI( IntPtr thisptr, ref UInt64 retarg, Int32 iCoplayFriend );
		public CSteamID GetCoplayFriend( Int32 iCoplayFriend ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetCoplayFriendI>( this.Functions.GetCoplayFriend51 )( this.ObjectAddress, ref ret, iCoplayFriend ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCoplayTimeC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetFriendCoplayTime( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendCoplayTimeC>( this.Functions.GetFriendCoplayTime52 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetFriendCoplayGameC( IntPtr thisptr, UInt64 steamIDFriend );
		public UInt32 GetFriendCoplayGame( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendCoplayGameC>( this.Functions.GetFriendCoplayGame53 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeJoinClanChatRoomC( IntPtr thisptr, UInt64 steamIDClan );
		public UInt64 JoinClanChatRoom( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeJoinClanChatRoomC>( this.Functions.JoinClanChatRoom54 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLeaveClanChatRoomC( IntPtr thisptr, UInt64 steamIDClan );
		public bool LeaveClanChatRoom( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeLeaveClanChatRoomC>( this.Functions.LeaveClanChatRoom55 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanChatMemberCountC( IntPtr thisptr, UInt64 steamIDClan );
		public Int32 GetClanChatMemberCount( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeGetClanChatMemberCountC>( this.Functions.GetClanChatMemberCount56 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetChatMemberByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan, Int32 iUser );
		public CSteamID GetChatMemberByIndex( CSteamID steamIDClan, Int32 iUser ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetChatMemberByIndexCI>( this.Functions.GetChatMemberByIndex57 )( this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64(), iUser ); return new CSteamID(ret);
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendClanChatMessageCS( IntPtr thisptr, UInt64 steamIDClanChat, IntPtr pchText );
		public bool SendClanChatMessage( CSteamID steamIDClanChat, string pchText ) 
		{
			return this.GetFunction<NativeSendClanChatMessageCS>( this.Functions.SendClanChatMessage58 )( this.ObjectAddress, steamIDClanChat.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchText ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanChatMessageCIBIEC( IntPtr thisptr, UInt64 steamIDClanChat, Int32 iMessage, Byte[] prgchText, Int32 cchTextMax, ref EChatEntryType peChatEntryType, ref UInt64 pSteamIDChatter );
		public Int32 GetClanChatMessage( CSteamID steamIDClanChat, Int32 iMessage, Byte[] prgchText, ref EChatEntryType peChatEntryType, ref CSteamID pSteamIDChatter ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetClanChatMessageCIBIEC>( this.Functions.GetClanChatMessage59 )( this.ObjectAddress, steamIDClanChat.ConvertToUint64(), iMessage, prgchText, (Int32) prgchText.Length, ref peChatEntryType, ref s0 ); pSteamIDChatter = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsClanChatAdminCC( IntPtr thisptr, UInt64 steamIDClanChat, UInt64 steamIDUser );
		public bool IsClanChatAdmin( CSteamID steamIDClanChat, CSteamID steamIDUser ) 
		{
			return this.GetFunction<NativeIsClanChatAdminCC>( this.Functions.IsClanChatAdmin60 )( this.ObjectAddress, steamIDClanChat.ConvertToUint64(), steamIDUser.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsClanChatWindowOpenInSteamC( IntPtr thisptr, UInt64 steamIDClanChat );
		public bool IsClanChatWindowOpenInSteam( CSteamID steamIDClanChat ) 
		{
			return this.GetFunction<NativeIsClanChatWindowOpenInSteamC>( this.Functions.IsClanChatWindowOpenInSteam61 )( this.ObjectAddress, steamIDClanChat.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeOpenClanChatWindowInSteamC( IntPtr thisptr, UInt64 steamIDClanChat );
		public bool OpenClanChatWindowInSteam( CSteamID steamIDClanChat ) 
		{
			return this.GetFunction<NativeOpenClanChatWindowInSteamC>( this.Functions.OpenClanChatWindowInSteam62 )( this.ObjectAddress, steamIDClanChat.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseClanChatWindowInSteamC( IntPtr thisptr, UInt64 steamIDClanChat );
		public bool CloseClanChatWindowInSteam( CSteamID steamIDClanChat ) 
		{
			return this.GetFunction<NativeCloseClanChatWindowInSteamC>( this.Functions.CloseClanChatWindowInSteam63 )( this.ObjectAddress, steamIDClanChat.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetListenForFriendsMessagesB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bInterceptEnabled );
		public bool SetListenForFriendsMessages( bool bInterceptEnabled ) 
		{
			return this.GetFunction<NativeSetListenForFriendsMessagesB>( this.Functions.SetListenForFriendsMessages64 )( this.ObjectAddress, bInterceptEnabled ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeReplyToFriendMessageCS( IntPtr thisptr, UInt64 steamIDFriend, IntPtr pchMsgToSend );
		public bool ReplyToFriendMessage( CSteamID steamIDFriend, string pchMsgToSend ) 
		{
			return this.GetFunction<NativeReplyToFriendMessageCS>( this.Functions.ReplyToFriendMessage65 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchMsgToSend ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendMessageCIBIE( IntPtr thisptr, UInt64 steamIDFriend, Int32 iMessageID, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType );
		public Int32 GetFriendMessage( CSteamID steamIDFriend, Int32 iMessageID, Byte[] pvData, ref EChatEntryType peChatEntryType ) 
		{
			return this.GetFunction<NativeGetFriendMessageCIBIE>( this.Functions.GetFriendMessage66 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iMessageID, pvData, (Int32) pvData.Length, ref peChatEntryType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetFollowerCountC( IntPtr thisptr, UInt64 steamID );
		public UInt64 GetFollowerCount( CSteamID steamID ) 
		{
			return this.GetFunction<NativeGetFollowerCountC>( this.Functions.GetFollowerCount67 )( this.ObjectAddress, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeIsFollowingC( IntPtr thisptr, UInt64 steamID );
		public UInt64 IsFollowing( CSteamID steamID ) 
		{
			return this.GetFunction<NativeIsFollowingC>( this.Functions.IsFollowing68 )( this.ObjectAddress, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateFollowingListU( IntPtr thisptr, UInt32 unStartIndex );
		public UInt64 EnumerateFollowingList( UInt32 unStartIndex ) 
		{
			return this.GetFunction<NativeEnumerateFollowingListU>( this.Functions.EnumerateFollowingList69 )( this.ObjectAddress, unStartIndex ); 
		}
		
	};
}
