// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamController003VTable
	{
		public IntPtr Init0;
		public IntPtr Shutdown1;
		public IntPtr RunFrame2;
		public IntPtr GetConnectedControllers3;
		public IntPtr ShowBindingPanel4;
		public IntPtr GetActionSetHandle5;
		public IntPtr ActivateActionSet6;
		public IntPtr GetCurrentActionSet7;
		public IntPtr GetDigitalActionHandle8;
		public IntPtr GetDigitalActionData9;
		public IntPtr GetDigitalActionOrigins10;
		public IntPtr GetAnalogActionHandle11;
		public IntPtr GetAnalogActionData12;
		public IntPtr GetAnalogActionOrigins13;
		public IntPtr StopAnalogActionMomentum14;
		public IntPtr TriggerHapticPulse15;
		public IntPtr TriggerRepeatedHapticPulse16;
		private IntPtr DTorISteamController00317;
	};
	
	public class ISteamController003 : InteropHelp.NativeWrapper<ISteamController003VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInit( IntPtr thisptr );
		public bool Init(  ) 
		{
			return this.GetFunction<NativeInit>( this.Functions.Init0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeShutdown( IntPtr thisptr );
		public bool Shutdown(  ) 
		{
			return this.GetFunction<NativeShutdown>( this.Functions.Shutdown1 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRunFrame( IntPtr thisptr );
		public void RunFrame(  ) 
		{
			this.GetFunction<NativeRunFrame>( this.Functions.RunFrame2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetConnectedControllersU( IntPtr thisptr, ref UInt64 arg0 );
		public Int32 GetConnectedControllers( ref UInt64 arg0 ) 
		{
			return this.GetFunction<NativeGetConnectedControllersU>( this.Functions.GetConnectedControllers3 )( this.ObjectAddress, ref arg0 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeShowBindingPanelU( IntPtr thisptr, UInt64 arg0 );
		public bool ShowBindingPanel( UInt64 arg0 ) 
		{
			return this.GetFunction<NativeShowBindingPanelU>( this.Functions.ShowBindingPanel4 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetActionSetHandleS( IntPtr thisptr, string arg0 );
		public Int32 GetActionSetHandle( string arg0 ) 
		{
			return this.GetFunction<NativeGetActionSetHandleS>( this.Functions.GetActionSetHandle5 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateActionSetUU( IntPtr thisptr, UInt64 arg0, UInt64 arg1 );
		public void ActivateActionSet( UInt64 arg0, UInt64 arg1 ) 
		{
			this.GetFunction<NativeActivateActionSetUU>( this.Functions.ActivateActionSet6 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCurrentActionSetU( IntPtr thisptr, UInt64 arg0 );
		public Int32 GetCurrentActionSet( UInt64 arg0 ) 
		{
			return this.GetFunction<NativeGetCurrentActionSetU>( this.Functions.GetCurrentActionSet7 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetDigitalActionHandleS( IntPtr thisptr, string arg0 );
		public Int32 GetDigitalActionHandle( string arg0 ) 
		{
			return this.GetFunction<NativeGetDigitalActionHandleS>( this.Functions.GetDigitalActionHandle8 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetDigitalActionDataUU( IntPtr thisptr, UInt64 arg0, UInt64 arg1 );
		public Int32 GetDigitalActionData( UInt64 arg0, UInt64 arg1 ) 
		{
			return this.GetFunction<NativeGetDigitalActionDataUU>( this.Functions.GetDigitalActionData9 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetDigitalActionOriginsUUUE( IntPtr thisptr, UInt64 arg0, UInt64 arg1, UInt64 arg2, ref EControllerActionOrigin arg3 );
		public Int32 GetDigitalActionOrigins( UInt64 arg0, UInt64 arg1, UInt64 arg2, ref EControllerActionOrigin arg3 ) 
		{
			return this.GetFunction<NativeGetDigitalActionOriginsUUUE>( this.Functions.GetDigitalActionOrigins10 )( this.ObjectAddress, arg0, arg1, arg2, ref arg3 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAnalogActionHandleS( IntPtr thisptr, string arg0 );
		public Int32 GetAnalogActionHandle( string arg0 ) 
		{
			return this.GetFunction<NativeGetAnalogActionHandleS>( this.Functions.GetAnalogActionHandle11 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAnalogActionDataUU( IntPtr thisptr, UInt64 arg0, UInt64 arg1 );
		public Int32 GetAnalogActionData( UInt64 arg0, UInt64 arg1 ) 
		{
			return this.GetFunction<NativeGetAnalogActionDataUU>( this.Functions.GetAnalogActionData12 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAnalogActionOriginsUUUE( IntPtr thisptr, UInt64 arg0, UInt64 arg1, UInt64 arg2, ref EControllerActionOrigin arg3 );
		public Int32 GetAnalogActionOrigins( UInt64 arg0, UInt64 arg1, UInt64 arg2, ref EControllerActionOrigin arg3 ) 
		{
			return this.GetFunction<NativeGetAnalogActionOriginsUUUE>( this.Functions.GetAnalogActionOrigins13 )( this.ObjectAddress, arg0, arg1, arg2, ref arg3 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeStopAnalogActionMomentumUU( IntPtr thisptr, UInt64 arg0, UInt64 arg1 );
		public Int32 StopAnalogActionMomentum( UInt64 arg0, UInt64 arg1 ) 
		{
			return this.GetFunction<NativeStopAnalogActionMomentumUU>( this.Functions.StopAnalogActionMomentum14 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTriggerHapticPulseUEU( IntPtr thisptr, UInt64 arg0, ESteamControllerPad eTargetPad, UInt16 usDurationMicroSec );
		public void TriggerHapticPulse( UInt64 arg0, ESteamControllerPad eTargetPad, UInt16 usDurationMicroSec ) 
		{
			this.GetFunction<NativeTriggerHapticPulseUEU>( this.Functions.TriggerHapticPulse15 )( this.ObjectAddress, arg0, eTargetPad, usDurationMicroSec ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTriggerRepeatedHapticPulseUEUUUU( IntPtr thisptr, UInt64 arg0, ESteamControllerPad arg1, UInt16 arg2, UInt16 arg3, UInt16 arg4, UInt32 arg5 );
		public void TriggerRepeatedHapticPulse( UInt64 arg0, ESteamControllerPad arg1, UInt16 arg2, UInt16 arg3, UInt16 arg4, UInt32 arg5 ) 
		{
			this.GetFunction<NativeTriggerRepeatedHapticPulseUEUUUU>( this.Functions.TriggerRepeatedHapticPulse16 )( this.ObjectAddress, arg0, arg1, arg2, arg3, arg4, arg5 ); 
		}
		
	};
}
