// (c) Copyright HutongGames, LLC 2010-2011. All rights reserved.

using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Begin a centered GUILayout block. NOTE: Block must end with a corresponding GUILayoutEndCentered.")]
	public class GUILayoutBeginCentered : FsmStateAction
	{
		public override void Reset()
		{
		}

		public override void OnGUI()
		{
			GUILayout.BeginVertical();
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginVertical();
		}
	}
}