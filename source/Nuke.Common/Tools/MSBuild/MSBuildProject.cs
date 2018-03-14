// Copyright Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Common.Tools.MSBuild
{
    [PublicAPI]
    public class MSBuildProject : DynamicObject
    {
        internal MSBuildProject(
            bool isSdkProject,
            IReadOnlyDictionary<string, string> properties,
            ILookup<string, string> itemGroups)
        {
            IsSdkProject = isSdkProject;
            Properties = properties;
            ItemGroups = itemGroups;
        }

        public bool IsSdkProject { get; }
        public bool IsLegacyProject => !IsSdkProject;
        public IReadOnlyDictionary<string, string> Properties { get; }
        public ILookup<string, string> ItemGroups { get; }
    }
}
