﻿//
// This file is part of Monobjc, a .NET/Objective-C bridge
// Copyright (C) 2007-2014 - Laurent Etiemble
//
// Monobjc is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// Monobjc is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Monobjc.  If not, see <http://www.gnu.org/licenses/>.
//
using System.ComponentModel;

namespace Monobjc.Tools.Xcode
{
	/// <summary>
	/// </summary>
	public enum PBXSourceTree
	{
		/// <summary>
		/// </summary>
		None = 0,
		/// <summary>
		/// </summary>
		[Description("<absolute>")]
		Absolute,
		/// <summary>
		/// </summary>
		[Description("<group>")]
		Group,
		/// <summary>
		/// </summary>
		[Description("SOURCE_ROOT")]
		SourceRoot,
		/// <summary>
		/// </summary>
		[Description("BUILT_PRODUCTS_DIR")]
		BuildProductDir,
		/// <summary>
		/// </summary>
		[Description("SDKROOT")]
		SdkRoot,
	}
}