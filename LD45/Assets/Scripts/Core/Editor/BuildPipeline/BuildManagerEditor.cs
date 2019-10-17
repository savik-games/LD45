﻿using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;

public static class BuildManagerEditor {
	[MenuItem("Build/Build All & ZIP")]
	public static void BuildAllZipped() {
		BuildManager.BuildAll(true);
	}

	[MenuItem("Build/Build All")]
	public static void BuildAll() {
		BuildManager.BuildAll(false);
	}

	[MenuItem("Build/Build Windows")]
	public static void BuildWindows() {
		BuildManager.BuildWindows(false, false);
	}

	[MenuItem("Build/Build Windows x64")]
	public static void BuildWindowsX64() {
		BuildManager.BuildWindowsX64(false, false);

	}

	[MenuItem("Build/Build Linux")]
	public static void BuildLinux() {
		BuildManager.BuildLinux(false, false);

	}

	[MenuItem("Build/Build OSX")]
	public static void BuildOSX() {
		BuildManager.BuildOSX(false, false);

	}

	[MenuItem("Build/Build Web")]
	public static void BuildWeb() {
		BuildManager.BuildWeb(false, false);
	}
}
