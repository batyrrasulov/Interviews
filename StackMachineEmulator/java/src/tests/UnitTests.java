package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import stackmachineemulator.Solution;

public class UnitTests {

	@Test
	public void testSolution_CanParseReversePolishNotation() {
		String str = "13+62*7+*";
		
        int result = Solution.solution(str);

        assertEquals(76, result);
	}

}
