﻿using System;
using AlphaOmega.Debug.Native;

namespace AlphaOmega.Debug.Smb
{
	/// <summary>System Information (Type 1)</summary>
	public class SystemType : TypeBaseT<SmBios.Type1>
	{
		/// <summary>Manufacturer</summary>
		public String Manufacturer { get { return base.GetString(base.Type.Manufacturer); } }
		/// <summary>Product name</summary>
		public String ProductName { get { return base.GetString(base.Type.ProductName); } }
		/// <summary>Version</summary>
		public String Version { get { return base.GetString(base.Type.Version); } }
		/// <summary>Serial number</summary>
		public String SerialNumber { get { return base.GetString(base.Type.SerialNumber); } }
		/// <summary>SKU Number</summary>
		public String SKUNumber { get { return base.GetString(base.Type.SKUNumber); } }
		/// <summary>Family</summary>
		public String Family { get { return base.GetString(base.Type.Family); } }

		internal SystemType(SmBios.Type1 data)
			: base(data.Header, data)
		{
			
		}
	}
}