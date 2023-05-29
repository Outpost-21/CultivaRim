﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace CultivaRim
{
    public class CropColumnWorker_StatColdResist : CropColumnWorker_Text
	{
		protected override TextAnchor Anchor => TextAnchor.MiddleCenter;

		public override int GetMinWidth(CropTable table)
		{
			return Mathf.Max(base.GetMinWidth(table), 50);
		}

		public override int Compare(ThingDef a, ThingDef b)
		{
			return GameCompUtil.gameComp_cropData.GetCropData(a).coldBoosts.CompareTo(GameCompUtil.gameComp_cropData.GetCropData(b).coldBoosts);
		}

		protected override string GetTextFor(ThingDef crop)
		{
			return GameCompUtil.gameComp_cropData.GetCropData(crop).StatColdResist;
		}
	}
}