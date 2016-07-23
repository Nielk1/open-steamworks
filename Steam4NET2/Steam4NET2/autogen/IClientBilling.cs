// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EPackageStatus : int
	{
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientBillingVTable
	{
		public IntPtr PurchaseWithActivationCode0;
		public IntPtr HasActiveLicense1;
		public IntPtr GetLicenseInfo2;
		public IntPtr EnableTestLicense3;
		public IntPtr DisableTestLicense4;
		public IntPtr GetAppsInPackage5;
		public IntPtr RequestFreeLicenseForApps6;
		private IntPtr DTorIClientBilling7;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTBILLING_INTERFACE_VERSION001")]
	public class IClientBilling : InteropHelp.NativeWrapper<IClientBillingVTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativePurchaseWithActivationCodeS( IntPtr thisptr, string pchActivationCode );
		public bool PurchaseWithActivationCode( string pchActivationCode ) 
		{
			return this.GetFunction<NativePurchaseWithActivationCodeS>( this.Functions.PurchaseWithActivationCode0 )( this.ObjectAddress, pchActivationCode ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHasActiveLicenseU( IntPtr thisptr, UInt32 arg0 );
		public bool HasActiveLicense( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeHasActiveLicenseU>( this.Functions.HasActiveLicense1 )( this.ObjectAddress, arg0 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLicenseInfoUUUIIEUIS( IntPtr thisptr, UInt32 nLicenseIndex, ref UInt32 pRTime32Created, ref UInt32 pRTime32NextProcess, ref Int32 pnMinuteLimit, ref Int32 pnMinutesUsed, ref EPaymentMethod pePaymentMethod, ref UInt32 punFlags, ref Int32 pnTerritoryCode, StringBuilder prgchPurchaseCountryCode );
		public bool GetLicenseInfo( UInt32 nLicenseIndex, ref UInt32 pRTime32Created, ref UInt32 pRTime32NextProcess, ref Int32 pnMinuteLimit, ref Int32 pnMinutesUsed, ref EPaymentMethod pePaymentMethod, ref UInt32 punFlags, ref Int32 pnTerritoryCode, StringBuilder prgchPurchaseCountryCode ) 
		{
			return this.GetFunction<NativeGetLicenseInfoUUUIIEUIS>( this.Functions.GetLicenseInfo2 )( this.ObjectAddress, nLicenseIndex, ref pRTime32Created, ref pRTime32NextProcess, ref pnMinuteLimit, ref pnMinutesUsed, ref pePaymentMethod, ref punFlags, ref pnTerritoryCode, prgchPurchaseCountryCode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEnableTestLicenseU( IntPtr thisptr, UInt32 unPackageID );
		public void EnableTestLicense( UInt32 unPackageID ) 
		{
			this.GetFunction<NativeEnableTestLicenseU>( this.Functions.EnableTestLicense3 )( this.ObjectAddress, unPackageID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeDisableTestLicenseU( IntPtr thisptr, UInt32 unPackageID );
		public void DisableTestLicense( UInt32 unPackageID ) 
		{
			this.GetFunction<NativeDisableTestLicenseU>( this.Functions.DisableTestLicense4 )( this.ObjectAddress, unPackageID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppsInPackageUUU( IntPtr thisptr, UInt32 unPackageID, ref UInt32 puIds, UInt32 uMaxIds );
		public UInt32 GetAppsInPackage( UInt32 unPackageID, ref UInt32 puIds, UInt32 uMaxIds ) 
		{
			return this.GetFunction<NativeGetAppsInPackageUUU>( this.Functions.GetAppsInPackage5 )( this.ObjectAddress, unPackageID, ref puIds, uMaxIds ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestFreeLicenseForAppsUU( IntPtr thisptr, ref UInt32 puIds, UInt32 smth );
		public UInt64 RequestFreeLicenseForApps( ref UInt32 puIds, UInt32 smth ) 
		{
			return this.GetFunction<NativeRequestFreeLicenseForAppsUU>( this.Functions.RequestFreeLicenseForApps6 )( this.ObjectAddress, ref puIds, smth ); 
		}
		
	};
}
