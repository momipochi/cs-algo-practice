using CsAlgoPractice.Leetcode.L11_ContainerWithMostWater;
using JetBrains.Annotations;

namespace CsAlgoPractice.Tests.Leetcode.L11_ContainerWithMostWater;

[TestSubject(typeof(ContainerWithMostWater))]
public class ContainerWithMostWaterTest
{

    [Fact]
    public void METHOD()
    {
        ContainerWithMostWater _container = new ContainerWithMostWater();
        int[] input = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        int output = 49;
        Assert.Equal(output,_container.MaxArea(input));
    }
}