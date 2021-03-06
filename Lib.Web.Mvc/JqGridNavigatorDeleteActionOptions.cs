﻿namespace Lib.Web.Mvc.JqGridFork
{
    /// <summary>
    /// Class which represents options for jqGrid Navigator delete action.
    /// </summary>
    public class JqGridNavigatorDeleteActionOptions : JqGridNavigatorModifyActionOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the icon for the submit button.
        /// </summary>
        public JqGridFormButtonIcon DeleteButtonIcon { get; set; }

        /// <summary>
        /// Gets or sets the icon for the cancel button.
        /// </summary>
        public JqGridFormButtonIcon CancelButtonIcon { get; set; }
        #endregion
    }
}
