﻿using System.Net.Http.Formatting;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi.Filters;
using Constants = Umbraco.Core.Constants;

namespace Umbraco.Web.Trees
{
    [UmbracoTreeAuthorize(Constants.Trees.LogViewer)]
    [Tree(Constants.Applications.Settings, Constants.Trees.LogViewer, null, sortOrder: 9)]
    [PluginController("UmbracoTrees")]
    [CoreTree(TreeGroup = Constants.Trees.Groups.Settings)]
    public class LogViewerTreeController : TreeController
    {
        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            //We don't have any child nodes & only use the root node to load a custom UI
            return new TreeNodeCollection();
        }

        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            //We don't have any menu item options (such as create/delete/reload) & only use the root node to load a custom UI
            return null;
        }

        /// <summary>
        /// Helper method to create a root model for a tree
        /// </summary>
        /// <returns></returns>
        protected override TreeNode CreateRootNode(FormDataCollection queryStrings)
        {
            var root = base.CreateRootNode(queryStrings);

            //this will load in a custom UI instead of the dashboard for the root node
            root.RoutePath = string.Format("{0}/{1}/{2}", Constants.Applications.Settings, Constants.Trees.LogViewer, "overview");
            root.Icon = "icon-box-alt";
            root.HasChildren = false;
            root.MenuUrl = null;

            return root;
        }
    }
}