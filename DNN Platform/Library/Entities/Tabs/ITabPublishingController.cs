﻿#region Copyright
// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2014
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;

namespace DotNetNuke.Entities.Tabs
{
    public interface ITabPublishingController
    {
        /// <summary>
        /// Publish a page.
        /// </summary>
        /// <param name="tabID">Tab Id from the tab to be published</param>
        /// <param name="portalID">Portal Id from the portal where the tab exists</param>        
        [Obsolete("Deprecated in DNN 7.3.0.")]
        void PublishTab(int tabID, int portalID);

        /// <summary>
        /// Check if a page is published or not.
        /// </summary>
        /// <param name="tabID">Tha tab Id</param>
        /// <param name="portalID">The portal ID where the tab is</param>        
        bool IsTabPublished(int tabID, int portalID);

        /// <summary>
        /// Set a page as published or unpublished
        /// </summary>
        /// <param name="tabID">The tab ID</param>
        /// <param name="portalID">The portal ID where the tab is</param>
        /// <param name="publish">A boolean value where True means the page is going to be published and otherwise unpublished</param>
        void SetTabPublishing(int tabID, int portalID, bool publish);

        /// <summary>
        /// Check if Publish/Unpublish page actions can be performed
        /// </summary>
        /// <param name="tabID">The tab ID</param>
        /// <param name="portalID">The portal ID where the tab is</param>
        bool CanPublishingBePerformed(int tabID, int portalID);
    }
}
