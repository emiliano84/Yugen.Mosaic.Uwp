﻿using Windows.ApplicationModel.Resources;

namespace Yugen.Mosaic.Uwp.Helpers
{
    public static class ResourceHelper
    {
        private static readonly ResourceLoader _resourceLoader = _resourceLoader ?? new ResourceLoader();

        public static string GetText(string key)
        {
            return _resourceLoader.GetString(key);
        }
    }
}