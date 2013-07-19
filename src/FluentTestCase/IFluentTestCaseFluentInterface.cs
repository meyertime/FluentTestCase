#region License
// Copyright 2013 David Meyer
// 
// This file is part of FluentTestCase.
// 
// FluentTestCase is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// FluentTestCase is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with FluentTestCase.  If not, see <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.ComponentModel;

namespace FluentTestCase
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IFluentTestCaseFluentInterface
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Equals(object obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        int GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        string ToString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        Type GetType();
    }
}
