﻿using System;

namespace Searchlight
{
    /// <summary>
    /// Represents a failure in the SQL validation
    /// </summary>
    public class SearchlightException : Exception
    {
        public SearchlightException(string originalFilter)
        {
            OriginalFilter = originalFilter;
        }

        public string OriginalFilter { get; set; }
    }
}
