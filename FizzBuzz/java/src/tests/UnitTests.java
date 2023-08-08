package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import fizzbuzz.Solution;

public class UnitTests {

	@Test
	public void testSolution() {
		int n = 15;
        
        Solution sln = new Solution();
        String[] result = sln.solution(n);
        
        assertEquals("1", result[0]);
        assertEquals("2", result[1]);
        assertEquals("Fizz", result[2]);
        assertEquals("4", result[3]);
        assertEquals("Buzz", result[4]);
        // ...
        assertEquals("FizzBuzz", result[14]);
	}

}
