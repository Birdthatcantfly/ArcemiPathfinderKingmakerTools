﻿#region License
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
#endregion
using System;
using System.Collections.Generic;

namespace Arcemi.Pathfinder.Kingmaker
{
    public class ClassModel : RefModel
    {
        public ClassModel(ModelDataAccessor accessor) : base(accessor)
        {
        }

        public string TypeName => Mappings.GetClassTypeName(CharacterClass);
        public string ArchetypeName => Mappings.GetClassArchetypeName(Archetypes);
        public string Name => Mappings.GetClassName(CharacterClass, Archetypes);

        public int Level { get => A.Value<int>(); set => A.Value(value); }
        public string CharacterClass => A.Value<string>();
        public IReadOnlyList<string> Archetypes => A.ListValue<string>();

        public bool IsMythic => string.Equals(CharacterClass, "247aa787806d5da4f89cfc3dff0b217f", StringComparison.Ordinal)
            || string.Equals(CharacterClass, "530b6a79cb691c24ba99e1577b4beb6d", StringComparison.Ordinal);
    }
}