package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import countrycount.Solution;

public class UnitTests {

	@Test
	public void testSolution_CanCountCountries() {
		int[][] A = new int[7][3];
		
        A[0][0] = 5;    A[0][1] = 4;    A[0][2] = 4;
        A[1][0] = 4;    A[1][1] = 3;    A[1][2] = 4;
        A[2][0] = 3;    A[2][1] = 2;    A[2][2] = 4;
        A[3][0] = 2;    A[3][1] = 2;    A[3][2] = 2;
        A[4][0] = 3;    A[4][1] = 3;    A[4][2] = 4;
        A[5][0] = 1;    A[5][1] = 4;    A[5][2] = 4;
        A[6][0] = 4;    A[6][1] = 1;    A[6][2] = 1;
        
        int result = Solution.solution(A);
        
        assertEquals(11, result);
	}

}
