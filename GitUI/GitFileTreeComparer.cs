﻿using System.Collections.Generic;
using GitCommands;

namespace GitUI
{
    public class GitFileTreeComparer : IComparer<IGitItem>
    {
        public int Compare(IGitItem x, IGitItem y)
        {
            var xGitItem = (GitItem)x;
            var yGitItem = (GitItem)y;

            if ((xGitItem.IsTree || xGitItem.IsCommit) && yGitItem.IsBlob)
                return -1;
            if (xGitItem.IsBlob && (yGitItem.IsTree || yGitItem.IsCommit))
                return 1;
            return xGitItem.Name.CompareTo(yGitItem.Name);
        }
    }
}
