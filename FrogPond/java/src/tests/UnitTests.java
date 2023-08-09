package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import frogpond.Solution;

public class UnitTests {

	@Test
	public void testSolution_ReturnsTheCorrectTiming() {
		int[] A = {1,3,1,4,2,5};
		int X = 7;
		int D = 3;
		
        int result = Solution.solution(A,X,D);

        assertEquals(3, result);
	}

}
