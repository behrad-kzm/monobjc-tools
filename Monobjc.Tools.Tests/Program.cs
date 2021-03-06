//
// This file is part of Monobjc, a .NET/Objective-C bridge
// Copyright (C) 2007-2013 - Laurent Etiemble
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
using System;

namespace Monobjc.Tools
{
	public class Program
	{
		public static void Main (String[] args)
		{
			//KeyChainAccessTests keyChainAccessTests = new KeyChainAccessTests();
			//keyChainAccessTests.TestKeyChainAccess();

			//NativeVersionExtractorTests nativeVersionExtractorTests = new NativeVersionExtractorTests();
			//nativeVersionExtractorTests.TestNativeVersionExtractor();

			//PBXProjectGenerationTests pBXProjectGenerationTests = new PBXProjectGenerationTests ();
			//pBXProjectGenerationTests.TestProjectGeneration001 ();
			//pBXProjectGenerationTests.TestProjectGeneration002 ();

			//XcodeProjectGenerationTests xcodeProjectGenerationTests = new XcodeProjectGenerationTests();
			//xcodeProjectGenerationTests.TestProjectGeneration001();
			//xcodeProjectGenerationTests.TestProjectGeneration002();
			//xcodeProjectGenerationTests.TestProjectGeneration003();
			//xcodeProjectGenerationTests.TestProjectGeneration004();

			//XIBLoadTests xibLoadTests = new XIBLoadTests();
			//xibLoadTests.TestMainMenuReading001();
			//xibLoadTests.TestMainMenuReading002();
			//xibLoadTests.TestMainMenuReading003();
			//xibLoadTests.TestMainMenuReading004();
			//xibLoadTests.TestMainMenuReading005();
			//xibLoadTests.TestMainMenuReading006();
			//xibLoadTests.TestMainMenuReading007();
			//xibLoadTests.TestMainMenuReading008();
			//xibLoadTests.TestMainMenuReading010();
			//xibLoadTests.TestMainMenuReading011();
			//xibLoadTests.TestMainMenuReading012();
			//xibLoadTests.TestMyDocumentReading005();

			//PListLoadTests pListLoadTests = new PListLoadTests();
			//pListLoadTests.TestPListReading001();
			//pListLoadTests.TestPListReading002();
			//pListLoadTests.TestPListReading004();
			//pListLoadTests.TestPListReading005();
			//pListLoadTests.TestPListReading010();

			//ArtworkCombinerTests artworkCombinerTests = new ArtworkCombinerTests();
			//artworkCombinerTests.TestImageCombination();

			FileEncrypterTests artworkEncrypterTests = new FileEncrypterTests ();
			artworkEncrypterTests.TestImageEncryption ();
			artworkEncrypterTests.TestImageDecryption ();
		}
	}
}