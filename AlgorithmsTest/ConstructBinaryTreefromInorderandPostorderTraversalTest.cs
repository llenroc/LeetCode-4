using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ConstructBinaryTreefromInorderandPostorderTraversalTest
    {
        [Theory]
        [InlineData()]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] inorder, int[] postorder, TreeNode output)
        {
            Assert.Equal(output, Solution106.BuildTree(inorder, postorder));
        }
        
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                 var driverData = new List<object[]>();
                 return driverData;
            }
        }
    }
}

