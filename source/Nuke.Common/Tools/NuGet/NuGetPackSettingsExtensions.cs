// Copyright Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Common.Tools.NuGet
{
    public static partial class NuGetPackSettingsExtensions
    {
        /// <summary><p><em>Extension method for setting 'configuration' in <see cref="NuGetPackSettings.Properties"/>.</em></p></summary>
        [Pure]
        public static NuGetPackSettings SetConfiguration(this NuGetPackSettings toolSettings, string configuration)
        {
            return toolSettings.SetProperty("configuration", configuration);
        }
    }
}
