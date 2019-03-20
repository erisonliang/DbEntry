﻿using System;
using Leafing.Core.Text;

namespace Leafing.Data.Definition
{
	[Serializable]
	public enum CompareOpration {
		[ShowString(">")]		GreatThan,
		[ShowString("<")]		LessThan,
		[ShowString("=")]		Equal,
		[ShowString(">=")]		GreatOrEqual,
		[ShowString("<=")]		LessOrEqual,
		[ShowString("<>")]		NotEqual,
		[ShowString("LIKE")]	Like,
		[ShowString("IS")]		Is,
        [ShowString("IS NOT")]  IsNot
	}
}
