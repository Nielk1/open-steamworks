//==========================  Open Steamworks  ================================
//
// This file is part of the Open Steamworks project. All individuals associated
// with this project do not claim ownership of the contents
// 
// The code, comments, and all related files, projects, resources,
// redistributables included with this project are Copyright Valve Corporation.
// Additionally, Valve, the Valve logo, Half-Life, the Half-Life logo, the
// Lambda logo, Steam, the Steam logo, Team Fortress, the Team Fortress logo,
// Opposing Force, Day of Defeat, the Day of Defeat logo, Counter-Strike, the
// Counter-Strike logo, Source, the Source logo, and Counter-Strike Condition
// Zero are trademarks and or registered trademarks of Valve Corporation.
// All other trademarks are property of their respective owners.
//
//=============================================================================

#ifndef ICLIENTSHORTCUTS_H
#define ICLIENTSHORTCUTS_H
#ifdef _WIN32
#pragma once
#endif

#include "SteamTypes.h"

#define CLIENTSHORTCUTS_INTERFACE_VERSION "CLIENTSHORTCUTS_INTERFACE_VERSION001"

abstract_class UNSAFE_INTERFACE IClientShortcuts
{
public:
	virtual uint32 GetUniqueLocalAppId() = 0;
	virtual CGameID GetGameIDForAppID( AppId_t unAppID ) = 0;
	virtual uint32 GetAppIDForGameID( CGameID gameID ) = 0;
	virtual uint32 GetShortcutCount() = 0;
	virtual uint32 GetShortcutAppIDByIndex( uint32 uIndex ) = 0;
	virtual const char * GetShortcutAppNameByIndex( uint32 uIndex ) = 0;
	virtual const char * GetShortcutExeByIndex( uint32 uIndex ) = 0;
	virtual uint32 GetShortcutUserTagCountByIndex( uint32 uIndex ) = 0;
	virtual const char * GetShortcutUserTagByIndex( uint32 uIndex, uint32 ) = 0;
	virtual bool BIsShortcutRemoteByIndex( uint32 uIndex ) = 0;
	virtual bool BIsTemporaryShortcutByIndex( uint32 uIndex ) = 0;
	virtual bool BIsOpenVRShortcutByIndex( uint32 uIndex ) = 0;
	virtual const char * GetShortcutAppNameByAppID( AppId_t unAppID ) = 0;
	virtual const char * GetShortcutExeByAppID( AppId_t unAppID ) = 0;
	virtual const char * GetShortcutStartDirByAppID( AppId_t unAppID ) = 0;
	virtual const char * GetShortcutIconByAppID( AppId_t unAppID ) = 0;
	virtual const char * GetShortcutPathByAppID( AppId_t unAppID ) = 0;
	virtual const char * GetShortcutCommandLine( AppId_t unAppID ) = 0;
	virtual uint32 GetShortcutUserTagCountByAppID( AppId_t unAppID ) = 0;
	virtual const char * GetShortcutUserTagByAppID( AppId_t unAppID, uint32 ) = 0;
	virtual bool BIsShortcutRemoteByAppID( AppId_t unAppID ) = 0;
	virtual bool BIsShortcutHiddenByAppID( AppId_t unAppID ) = 0;
	virtual bool BIsTemporaryShortcutByAppID( AppId_t unAppID ) = 0;
	virtual bool BIsOpenVRShortcutByAppID( AppId_t unAppID ) = 0;
	virtual bool BAllowDesktopConfigByAppID( AppId_t unAppID ) = 0;
	virtual AppId_t GetShortcutLastPlayedTime( AppId_t unAppID ) = 0;
	virtual AppId_t AddShortcut( const char * appName, const char * exe, const char * icon, const char * startDir ) = 0;
	virtual AppId_t AddTemporaryShortcut( const char * appName, const char * exe, const char * icon, const char * startDir ) = 0;
	virtual AppId_t AddOpenVRShortcut( const char * appName, const char * exe, const char * icon, const char * startDir ) = 0;
	virtual void SetShortcutFromFullpath( AppId_t unAppID, const char * ) = 0;
	virtual void SetShortcutAppName( AppId_t unAppID, const char * ) = 0;
	virtual void SetShortcutExe( AppId_t unAppID, const char * ) = 0;
	virtual void SetShortcutStartDir( AppId_t unAppID, const char * ) = 0;
	virtual void SetShortcutIcon( AppId_t unAppID, const char * ) = 0;
	virtual void SetShortcutCommandLine( AppId_t unAppID, const char * ) = 0;
	virtual void ClearShortcutUserTags( AppId_t unAppID ) = 0;
	virtual void AddShortcutUserTag( AppId_t unAppID, const char * ) = 0;
	virtual void SetShortcutHidden( AppId_t unAppID, bool ) = 0;
	virtual void SetAllowDesktopConfig( AppId_t unAppID, bool ) = 0;
	virtual void SetOpenVRShortcut( AppId_t unAppID, bool ) = 0;
	virtual void RemoveShortcut( AppId_t unAppID ) = 0;
	virtual void RemoveAllTemporaryShortcuts() = 0;
	virtual bool LaunchShortcut( AppId_t unAppID ) = 0;
};

#endif // ICLIENTSHORTCUTS_H
