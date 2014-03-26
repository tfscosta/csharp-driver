//
//      Copyright (C) 2012 DataStax Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
﻿using System;
using System.Numerics;

#if MYTEST
using MyTest;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace Cassandra.MSTest
{
    public partial class PreparedStatementsCCMTests
    {        
                        
        [TestMethod]        
		[WorksForMe]
        public void reprepareOnNewlyUpNodeTestCCM()
        {
            reprepareOnNewlyUpNodeTest(true);
        }
        
        [TestMethod]
 		[WorksForMe]
       public void reprepareOnNewlyUpNodeNoKeyspaceTestCCM()
        {
            // This is the same test than reprepareOnNewlyUpNodeTest, except that the
            // prepared statement is prepared while no current keyspace is used
            reprepareOnNewlyUpNodeTest(false);
        }

    }
}