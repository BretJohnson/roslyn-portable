﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysisP.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysisP.UnitTests
{
    public class DiffUtilTests
    {
        [Fact]
        public void TestDiffTester()
        {
            // Make sure the diff tester is working!
            Assert.Equal(DiffUtil.DiffReport(
@"A
B
C
D
E
F",
@"A
1
B
C
E
2"),
@"    A
++> 1
    B
    C
--> D
    E
++> 2
--> F");
        }
    }
}
