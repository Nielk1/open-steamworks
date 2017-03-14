// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamScreenshots001VTable
	{
		public IntPtr WriteScreenshot0;
		public IntPtr AddScreenshotToLibrary1;
		public IntPtr TriggerScreenshot2;
		public IntPtr HookScreenshots3;
		public IntPtr SetLocation4;
		public IntPtr TagUser5;
		private IntPtr DTorISteamScreenshots0016;
	};
	
	[InteropHelp.InterfaceVersion("STEAMSCREENSHOTS_INTERFACE_VERSION001")]
	public class ISteamScreenshots001 : InteropHelp.NativeWrapper<ISteamScreenshots001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeWriteScreenshotBUII( IntPtr thisptr, Byte[] pubRGB, UInt32 cubRGB, Int32 nWidth, Int32 nHeight );
		public UInt32 WriteScreenshot( Byte[] pubRGB, Int32 nWidth, Int32 nHeight ) 
		{
			return this.GetFunction<NativeWriteScreenshotBUII>( this.Functions.WriteScreenshot0 )( this.ObjectAddress, pubRGB, (UInt32) pubRGB.Length, nWidth, nHeight ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddScreenshotToLibrarySSII( IntPtr thisptr, IntPtr pchJpegOrTGAFilename, IntPtr pchJpegOrTGAThumbFilename, Int32 nWidth, Int32 nHeight );
		public UInt32 AddScreenshotToLibrary( string pchJpegOrTGAFilename, string pchJpegOrTGAThumbFilename, Int32 nWidth, Int32 nHeight ) 
		{
			return this.GetFunction<NativeAddScreenshotToLibrarySSII>( this.Functions.AddScreenshotToLibrary1 )( this.ObjectAddress, InteropHelp.Utf8StringToPtr( pchJpegOrTGAFilename ).GetMarshaledBytes(), InteropHelp.Utf8StringToPtr( pchJpegOrTGAThumbFilename ).GetMarshaledBytes(), nWidth, nHeight ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTriggerScreenshot( IntPtr thisptr );
		public void TriggerScreenshot(  ) 
		{
			this.GetFunction<NativeTriggerScreenshot>( this.Functions.TriggerScreenshot2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeHookScreenshotsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bHook );
		public void HookScreenshots( bool bHook ) 
		{
			this.GetFunction<NativeHookScreenshotsB>( this.Functions.HookScreenshots3 )( this.ObjectAddress, bHook ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLocationUS( IntPtr thisptr, UInt32 hScreenshot, IntPtr pchLocation );
		public bool SetLocation( UInt32 hScreenshot, string pchLocation ) 
		{
			return this.GetFunction<NativeSetLocationUS>( this.Functions.SetLocation4 )( this.ObjectAddress, hScreenshot, InteropHelp.Utf8StringToPtr( pchLocation ).GetMarshaledBytes() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTagUserUC( IntPtr thisptr, UInt32 hScreenshot, UInt64 steamID );
		public bool TagUser( UInt32 hScreenshot, CSteamID steamID ) 
		{
			return this.GetFunction<NativeTagUserUC>( this.Functions.TagUser5 )( this.ObjectAddress, hScreenshot, steamID.ConvertToUint64() ); 
		}
		
	};
}
