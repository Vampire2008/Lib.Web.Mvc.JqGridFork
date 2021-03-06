﻿namespace Lib.Web.Mvc.JqGridFork
{
	/// <summary>
	/// Defines available refresh modes for jqGrid
	/// </summary>
	public enum JqGridRefreshModes
	{
		/// <summary>
		/// Use grid default value
		/// </summary>
		Default,
		/// <summary>
		/// The grid refreshes to the first page
		/// </summary>
		FirstPage,
		/// <summary>
		/// The grid refreshes to the current page with current selection
		/// </summary>
		Current
	}
}
