package fizzbuzz;

public class Program {

	public static void main(String[] args) {
		
		int n = 15;
		       
        Solution sln = new Solution();
		String[] result = sln.solution(n);
        
        for(int i = 0; i < result.length; i++) {
            System.out.println(result[i]);
        }
	}

}
