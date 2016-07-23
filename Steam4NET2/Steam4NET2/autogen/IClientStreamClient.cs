// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientStreamClientVTable
	{
		public IntPtr Launched0;
		public IntPtr FocusGained1;
		public IntPtr FocusLost2;
		public IntPtr Finished3;
		public IntPtr SaveStreamingClientConfig4;
		public IntPtr GetFocusInfo5;
		public IntPtr GetSystemInfo6;
		public IntPtr StartStreamingSession7;
		public IntPtr ReportStreamingSessionEvent8;
		public IntPtr FinishStreamingSession9;
		private IntPtr DTorIClientStreamClient10;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTSTREAMCLIENT_INTERFACE_VERSION001")]
	public class IClientStreamClient : InteropHelp.NativeWrapper<IClientStreamClientVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLaunchedC( IntPtr thisptr, UInt64 gameID );
		public void Launched( CGameID gameID ) 
		{
			this.GetFunction<NativeLaunchedC>( this.Functions.Launched0 )( this.ObjectAddress, gameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeFocusGainedCB( IntPtr thisptr, UInt64 gameID, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		public void FocusGained( CGameID gameID, bool arg1 ) 
		{
			this.GetFunction<NativeFocusGainedCB>( this.Functions.FocusGained1 )( this.ObjectAddress, gameID.ConvertToUint64(), arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeFocusLostC( IntPtr thisptr, UInt64 gameID );
		public void FocusLost( CGameID gameID ) 
		{
			this.GetFunction<NativeFocusLostC>( this.Functions.FocusLost2 )( this.ObjectAddress, gameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeFinishedCE( IntPtr thisptr, UInt64 gameID, EResult eResult );
		public void Finished( CGameID gameID, EResult eResult ) 
		{
			this.GetFunction<NativeFinishedCE>( this.Functions.Finished3 )( this.ObjectAddress, gameID.ConvertToUint64(), eResult ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSaveStreamingClientConfigS( IntPtr thisptr, string arg0 );
		public void SaveStreamingClientConfig( string arg0 ) 
		{
			this.GetFunction<NativeSaveStreamingClientConfigS>( this.Functions.SaveStreamingClientConfig4 )( this.ObjectAddress, arg0 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFocusInfoCU( IntPtr thisptr, ref UInt64 arg0, ref UInt64 arg1 );
		public bool GetFocusInfo( ref CGameID arg0, ref UInt64 arg1 ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetFocusInfoCU>( this.Functions.GetFocusInfo5 )( this.ObjectAddress, ref s0, ref arg1 ); arg0 = new CGameID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetSystemInfo( IntPtr thisptr );
		public string GetSystemInfo(  ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetSystemInfo>( this.Functions.GetSystemInfo6 )( this.ObjectAddress ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeStartStreamingSessionC( IntPtr thisptr, UInt64 gameID );
		public void StartStreamingSession( CGameID gameID ) 
		{
			this.GetFunction<NativeStartStreamingSessionC>( this.Functions.StartStreamingSession7 )( this.ObjectAddress, gameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeReportStreamingSessionEventCS( IntPtr thisptr, UInt64 gameID, string arg1 );
		public void ReportStreamingSessionEvent( CGameID gameID, string arg1 ) 
		{
			this.GetFunction<NativeReportStreamingSessionEventCS>( this.Functions.ReportStreamingSessionEvent8 )( this.ObjectAddress, gameID.ConvertToUint64(), arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeFinishStreamingSessionCSS( IntPtr thisptr, UInt64 gameID, string arg1, string arg2 );
		public void FinishStreamingSession( CGameID gameID, string arg1, string arg2 ) 
		{
			this.GetFunction<NativeFinishStreamingSessionCSS>( this.Functions.FinishStreamingSession9 )( this.ObjectAddress, gameID.ConvertToUint64(), arg1, arg2 ); 
		}
		
	};
}
