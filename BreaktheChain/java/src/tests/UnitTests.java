package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import breakthechain.Solution;

public class UnitTests {

	@Test
	public void testSolution_ReturnsTheLowestCostToBreakTheChainIntoThreeParts() {
		int[] chain = {5,2,4,6,3,7};
		
        int result = Solution.solution(chain);

        assertEquals(5, result);
	}

}
