// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientUserStatsVTable
	{
		public IntPtr GetNumStats0;
		public IntPtr GetStatName1;
		public IntPtr GetStatType2;
		public IntPtr GetNumAchievements3;
		public IntPtr GetAchievementName4;
		public IntPtr RequestCurrentStats5;
		public IntPtr GetStat6;
		public IntPtr GetStat7;
		public IntPtr SetStat8;
		public IntPtr SetStat9;
		public IntPtr UpdateAvgRateStat10;
		public IntPtr GetAchievement11;
		public IntPtr SetAchievement12;
		public IntPtr ClearAchievement13;
		public IntPtr StoreStats14;
		public IntPtr GetAchievementIcon15;
		public IntPtr GetAchievementDisplayAttribute16;
		public IntPtr IndicateAchievementProgress17;
		public IntPtr SetMaxStatsLoaded18;
		public IntPtr RequestUserStats19;
		public IntPtr GetUserStat20;
		public IntPtr GetUserStat21;
		public IntPtr GetUserAchievement22;
		public IntPtr ResetAllStats23;
		public IntPtr FindOrCreateLeaderboard24;
		public IntPtr FindLeaderboard25;
		public IntPtr GetLeaderboardName26;
		public IntPtr GetLeaderboardEntryCount27;
		public IntPtr GetLeaderboardSortMethod28;
		public IntPtr GetLeaderboardDisplayType29;
		public IntPtr DownloadLeaderboardEntries30;
		public IntPtr DownloadLeaderboardEntriesForUsers31;
		public IntPtr GetDownloadedLeaderboardEntry32;
		public IntPtr AttachLeaderboardUGC33;
		public IntPtr UploadLeaderboardScore34;
		public IntPtr GetNumberOfCurrentPlayers35;
		public IntPtr GetNumAchievedAchievements36;
		public IntPtr GetLastAchievementUnlocked37;
		public IntPtr RequestGlobalAchievementPercentages38;
		public IntPtr GetMostAchievedAchievementInfo39;
		public IntPtr GetNextMostAchievedAchievementInfo40;
		public IntPtr GetAchievementAchievedPercent41;
		public IntPtr RequestGlobalStats42;
		public IntPtr GetGlobalStat43;
		public IntPtr GetGlobalStat44;
		public IntPtr GetGlobalStatHistory45;
		public IntPtr GetGlobalStatHistory46;
		private IntPtr DTorIClientUserStats47;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTUSERSTATS_INTERFACE_VERSION002")]
	public class IClientUserStats : InteropHelp.NativeWrapper<IClientUserStatsVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumStatsC( IntPtr thisptr, UInt64 nGameID );
		public UInt32 GetNumStats( CGameID nGameID ) 
		{
			return this.GetFunction<NativeGetNumStatsC>( this.Functions.GetNumStats0 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetStatNameCU( IntPtr thisptr, UInt64 nGameID, UInt32 iStat );
		public string GetStatName( CGameID nGameID, UInt32 iStat ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetStatNameCU>( this.Functions.GetStatName1 )( this.ObjectAddress, nGameID.ConvertToUint64(), iStat ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESteamUserStatType NativeGetStatTypeCS( IntPtr thisptr, UInt64 nGameID, IntPtr pchName );
		public ESteamUserStatType GetStatType( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeGetStatTypeCS>( this.Functions.GetStatType2 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumAchievementsC( IntPtr thisptr, UInt64 nGameID );
		public UInt32 GetNumAchievements( CGameID nGameID ) 
		{
			return this.GetFunction<NativeGetNumAchievementsC>( this.Functions.GetNumAchievements3 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetAchievementNameCU( IntPtr thisptr, UInt64 nGameID, UInt32 iAchievement );
		public string GetAchievementName( CGameID nGameID, UInt32 iAchievement ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetAchievementNameCU>( this.Functions.GetAchievementName4 )( this.ObjectAddress, nGameID.ConvertToUint64(), iAchievement ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestCurrentStatsC( IntPtr thisptr, UInt64 nGameID );
		public bool RequestCurrentStats( CGameID nGameID ) 
		{
			return this.GetFunction<NativeRequestCurrentStatsC>( this.Functions.RequestCurrentStats5 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatCSF( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref float pData );
		public bool GetStat( CGameID nGameID, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetStatCSF>( this.Functions.GetStat6 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatCSI( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref Int32 pData );
		public bool GetStat( CGameID nGameID, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetStatCSI>( this.Functions.GetStat7 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatCSF( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, float fData );
		public bool SetStat( CGameID nGameID, string pchName, float fData ) 
		{
			return this.GetFunction<NativeSetStatCSF>( this.Functions.SetStat8 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), fData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatCSI( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, Int32 nData );
		public bool SetStat( CGameID nGameID, string pchName, Int32 nData ) 
		{
			return this.GetFunction<NativeSetStatCSI>( this.Functions.SetStat9 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), nData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateAvgRateStatCSFD( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, float flCountThisSession, double dSessionLength );
		public bool UpdateAvgRateStat( CGameID nGameID, string pchName, float flCountThisSession, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateAvgRateStatCSFD>( this.Functions.UpdateAvgRateStat10 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), flCountThisSession, dSessionLength ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementCSBU( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref bool pbAchieved, ref UInt32 punUnlockTime );
		public bool GetAchievement( CGameID nGameID, string pchName, ref bool pbAchieved, ref UInt32 punUnlockTime ) 
		{
			return this.GetFunction<NativeGetAchievementCSBU>( this.Functions.GetAchievement11 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pbAchieved, ref punUnlockTime ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAchievementCS( IntPtr thisptr, UInt64 nGameID, IntPtr pchName );
		public bool SetAchievement( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeSetAchievementCS>( this.Functions.SetAchievement12 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearAchievementCS( IntPtr thisptr, UInt64 nGameID, IntPtr pchName );
		public bool ClearAchievement( CGameID nGameID, string pchName ) 
		{
			return this.GetFunction<NativeClearAchievementCS>( this.Functions.ClearAchievement13 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStoreStatsC( IntPtr thisptr, UInt64 nGameID );
		public bool StoreStats( CGameID nGameID ) 
		{
			return this.GetFunction<NativeStoreStatsC>( this.Functions.StoreStats14 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAchievementIconCSE( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, EGetAchievementIcon arg2 );
		public Int32 GetAchievementIcon( CGameID nGameID, string pchName, EGetAchievementIcon arg2 ) 
		{
			return this.GetFunction<NativeGetAchievementIconCSE>( this.Functions.GetAchievementIcon15 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetAchievementDisplayAttributeCSSB( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, IntPtr pchKey, [MarshalAs(UnmanagedType.I1)] bool bUseGameLanguage );
		public string GetAchievementDisplayAttribute( CGameID nGameID, string pchName, string pchKey, bool bUseGameLanguage ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetAchievementDisplayAttributeCSSB>( this.Functions.GetAchievementDisplayAttribute16 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), InteropHelp.Utf8StringToPtr( pchKey ).GetMarshaledBytes(), bUseGameLanguage ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIndicateAchievementProgressCSUU( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, UInt32 nCurProgress, UInt32 nMaxProgress );
		public bool IndicateAchievementProgress( CGameID nGameID, string pchName, UInt32 nCurProgress, UInt32 nMaxProgress ) 
		{
			return this.GetFunction<NativeIndicateAchievementProgressCSUU>( this.Functions.IndicateAchievementProgress17 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), nCurProgress, nMaxProgress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetMaxStatsLoadedU( IntPtr thisptr, UInt32 uMax );
		public void SetMaxStatsLoaded( UInt32 uMax ) 
		{
			this.GetFunction<NativeSetMaxStatsLoadedU>( this.Functions.SetMaxStatsLoaded18 )( this.ObjectAddress, uMax ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsCC( IntPtr thisptr, UInt64 steamIDUser, UInt64 nGameID );
		public UInt64 RequestUserStats( CSteamID steamIDUser, CGameID nGameID ) 
		{
			return this.GetFunction<NativeRequestUserStatsCC>( this.Functions.RequestUserStats19 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), nGameID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCCSF( IntPtr thisptr, UInt64 steamIDUser, UInt64 nGameID, IntPtr pchName, ref float pData );
		public bool GetUserStat( CSteamID steamIDUser, CGameID nGameID, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetUserStatCCSF>( this.Functions.GetUserStat20 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCCSI( IntPtr thisptr, UInt64 steamIDUser, UInt64 nGameID, IntPtr pchName, ref Int32 pData );
		public bool GetUserStat( CSteamID steamIDUser, CGameID nGameID, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetUserStatCCSI>( this.Functions.GetUserStat21 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCCSBU( IntPtr thisptr, UInt64 steamIDUser, UInt64 nGameID, IntPtr pchName, ref bool pbAchieved, ref UInt32 punUnlockTime );
		public bool GetUserAchievement( CSteamID steamIDUser, CGameID nGameID, string pchName, ref bool pbAchieved, ref UInt32 punUnlockTime ) 
		{
			return this.GetFunction<NativeGetUserAchievementCCSBU>( this.Functions.GetUserAchievement22 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pbAchieved, ref punUnlockTime ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeResetAllStatsCB( IntPtr thisptr, UInt64 nGameID, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo );
		public bool ResetAllStats( CGameID nGameID, bool bAchievementsToo ) 
		{
			return this.GetFunction<NativeResetAllStatsCB>( this.Functions.ResetAllStats23 )( this.ObjectAddress, nGameID.ConvertToUint64(), bAchievementsToo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindOrCreateLeaderboardSEE( IntPtr thisptr, IntPtr pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType );
		public UInt64 FindOrCreateLeaderboard( string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType ) 
		{
			return this.GetFunction<NativeFindOrCreateLeaderboardSEE>( this.Functions.FindOrCreateLeaderboard24 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchLeaderboardName ).GetMarshaledBytes(), eLeaderboardSortMethod, eLeaderboardDisplayType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindLeaderboardS( IntPtr thisptr, IntPtr pchLeaderboardName );
		public UInt64 FindLeaderboard( string pchLeaderboardName ) 
		{
			return this.GetFunction<NativeFindLeaderboardS>( this.Functions.FindLeaderboard25 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchLeaderboardName ).GetMarshaledBytes() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLeaderboardNameU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public string GetLeaderboardName( UInt64 hSteamLeaderboard ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetLeaderboardNameU>( this.Functions.GetLeaderboardName26 )( this.ObjectAddress, hSteamLeaderboard ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLeaderboardEntryCountU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public Int32 GetLeaderboardEntryCount( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardEntryCountU>( this.Functions.GetLeaderboardEntryCount27 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardSortMethod NativeGetLeaderboardSortMethodU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardSortMethod GetLeaderboardSortMethod( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardSortMethodU>( this.Functions.GetLeaderboardSortMethod28 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardDisplayType NativeGetLeaderboardDisplayTypeU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardDisplayType GetLeaderboardDisplayType( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardDisplayTypeU>( this.Functions.GetLeaderboardDisplayType29 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesUEII( IntPtr thisptr, UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd );
		public UInt64 DownloadLeaderboardEntries( UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd ) 
		{
			return this.GetFunction<NativeDownloadLeaderboardEntriesUEII>( this.Functions.DownloadLeaderboardEntries30 )( this.ObjectAddress, hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesForUsersUCI( IntPtr thisptr, UInt64 hSteamLeaderboard, ref UInt64 prgUsers, Int32 cUsers );
		public UInt64 DownloadLeaderboardEntriesForUsers( UInt64 hSteamLeaderboard, ref CSteamID prgUsers, Int32 cUsers ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeDownloadLeaderboardEntriesForUsersUCI>( this.Functions.DownloadLeaderboardEntriesForUsers31 )( this.ObjectAddress, hSteamLeaderboard, ref s0, cUsers ); prgUsers = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetDownloadedLeaderboardEntryUILII( IntPtr thisptr, UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry002_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax );
		public bool GetDownloadedLeaderboardEntry( UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry002_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax ) 
		{
			return this.GetFunction<NativeGetDownloadedLeaderboardEntryUILII>( this.Functions.GetDownloadedLeaderboardEntry32 )( this.ObjectAddress, hSteamLeaderboardEntries, index, ref pLeaderboardEntry, ref pDetails, cDetailsMax ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeAttachLeaderboardUGCUU( IntPtr thisptr, UInt64 hSteamLeaderboard, UInt64 hUGC );
		public UInt64 AttachLeaderboardUGC( UInt64 hSteamLeaderboard, UInt64 hUGC ) 
		{
			return this.GetFunction<NativeAttachLeaderboardUGCUU>( this.Functions.AttachLeaderboardUGC33 )( this.ObjectAddress, hSteamLeaderboard, hUGC ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUploadLeaderboardScoreUEIII( IntPtr thisptr, UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount );
		public UInt64 UploadLeaderboardScore( UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount ) 
		{
			return this.GetFunction<NativeUploadLeaderboardScoreUEIII>( this.Functions.UploadLeaderboardScore34 )( this.ObjectAddress, hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, ref pScoreDetails, cScoreDetailsCount ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetNumberOfCurrentPlayers( IntPtr thisptr );
		public UInt64 GetNumberOfCurrentPlayers(  ) 
		{
			return this.GetFunction<NativeGetNumberOfCurrentPlayers>( this.Functions.GetNumberOfCurrentPlayers35 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumAchievedAchievementsC( IntPtr thisptr, UInt64 nGameID );
		public UInt32 GetNumAchievedAchievements( CGameID nGameID ) 
		{
			return this.GetFunction<NativeGetNumAchievedAchievementsC>( this.Functions.GetNumAchievedAchievements36 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLastAchievementUnlockedC( IntPtr thisptr, UInt64 nGameID );
		public string GetLastAchievementUnlocked( CGameID nGameID ) 
		{
			return InteropHelp.Utf8PtrToString( this.GetFunction<NativeGetLastAchievementUnlockedC>( this.Functions.GetLastAchievementUnlocked37 )( this.ObjectAddress, nGameID.ConvertToUint64() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestGlobalAchievementPercentagesC( IntPtr thisptr, UInt64 nGameID );
		public UInt64 RequestGlobalAchievementPercentages( CGameID nGameID ) 
		{
			return this.GetFunction<NativeRequestGlobalAchievementPercentagesC>( this.Functions.RequestGlobalAchievementPercentages38 )( this.ObjectAddress, nGameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMostAchievedAchievementInfoCSUFB( IntPtr thisptr, UInt64 nGameID, StringBuilder pchName, UInt32 unNameBufLen, ref float pflPercent, ref bool pbAchieved );
		public Int32 GetMostAchievedAchievementInfo( CGameID nGameID, StringBuilder pchName, ref float pflPercent, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetMostAchievedAchievementInfoCSUFB>( this.Functions.GetMostAchievedAchievementInfo39 )( this.ObjectAddress, nGameID.ConvertToUint64(), pchName, (UInt32) pchName.Capacity, ref pflPercent, ref pbAchieved ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNextMostAchievedAchievementInfoCISUFB( IntPtr thisptr, UInt64 nGameID, Int32 iIteratorPrevious, StringBuilder pchName, UInt32 unNameBufLen, ref float pflPercent, ref bool pbAchieved );
		public Int32 GetNextMostAchievedAchievementInfo( CGameID nGameID, Int32 iIteratorPrevious, StringBuilder pchName, ref float pflPercent, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetNextMostAchievedAchievementInfoCISUFB>( this.Functions.GetNextMostAchievedAchievementInfo40 )( this.ObjectAddress, nGameID.ConvertToUint64(), iIteratorPrevious, pchName, (UInt32) pchName.Capacity, ref pflPercent, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementAchievedPercentCSF( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref float pflPercent );
		public bool GetAchievementAchievedPercent( CGameID nGameID, string pchName, ref float pflPercent ) 
		{
			return this.GetFunction<NativeGetAchievementAchievedPercentCSF>( this.Functions.GetAchievementAchievedPercent41 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pflPercent ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestGlobalStatsCI( IntPtr thisptr, UInt64 nGameID, Int32 nHistoryDays );
		public UInt64 RequestGlobalStats( CGameID nGameID, Int32 nHistoryDays ) 
		{
			return this.GetFunction<NativeRequestGlobalStatsCI>( this.Functions.RequestGlobalStats42 )( this.ObjectAddress, nGameID.ConvertToUint64(), nHistoryDays ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetGlobalStatCSD( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref double pData );
		public bool GetGlobalStat( CGameID nGameID, string pchName, ref double pData ) 
		{
			return this.GetFunction<NativeGetGlobalStatCSD>( this.Functions.GetGlobalStat43 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetGlobalStatCSI( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref Int64 pData );
		public bool GetGlobalStat( CGameID nGameID, string pchName, ref Int64 pData ) 
		{
			return this.GetFunction<NativeGetGlobalStatCSI>( this.Functions.GetGlobalStat44 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetGlobalStatHistoryCSDU( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref double pData, UInt32 cubData );
		public Int32 GetGlobalStatHistory( CGameID nGameID, string pchName, ref double pData, UInt32 cubData ) 
		{
			return this.GetFunction<NativeGetGlobalStatHistoryCSDU>( this.Functions.GetGlobalStatHistory45 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData, cubData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetGlobalStatHistoryCSIU( IntPtr thisptr, UInt64 nGameID, IntPtr pchName, ref Int64 pData, UInt32 cubData );
		public Int32 GetGlobalStatHistory( CGameID nGameID, string pchName, ref Int64 pData, UInt32 cubData ) 
		{
			return this.GetFunction<NativeGetGlobalStatHistoryCSIU>( this.Functions.GetGlobalStatHistory46 )( this.ObjectAddress, nGameID.ConvertToUint64(), InteropHelp.Utf8StringToPtr( pchName ).GetMarshaledBytes(), ref pData, cubData ); 
		}
		
	};
}
