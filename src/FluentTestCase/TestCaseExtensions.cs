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

namespace FluentTestCase
{
    public static class TestCaseExtensions
    {
        public static Arranging<T> Arrange<T>(this TestCaseStart<T> start)
            where T : TestCase
        {
            if (start == null) throw new ArgumentNullException("start");

            return new Arranging<T>()
            {
                TestCase = start.TestCase
            };
        }

        public static Acting<T> Act<T>(this Arranged<T> a)
            where T : TestCase
        {
            if (a == null) throw new ArgumentNullException("a");

            return new Acting<T>()
            {
                TestCase = a.TestCase
            };
        }

        public static Asserting<T> Assert<T>(this Acted<T> a)
            where T : TestCase
        {
            if (a == null) throw new ArgumentNullException("a");

            return new Asserting<T>()
            {
                TestCase = a.TestCase
            };
        }
    }
}
