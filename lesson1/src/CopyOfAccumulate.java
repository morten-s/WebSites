import javax.swing.JOptionPane;

/**
 * @author nml
 * @version 2013-01-29
 * 
 */
public class CopyOfAccumulate {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int terms;
		double rate, principal, accumulated;

		terms = 10;
		rate = 3.5;
		// accumulated = principal = 1000; // equivalent of lines 19 and 20
		principal = 1000;
		accumulated = principal;
		String s = "Initial principal " + principal;
		s += "\nInterest rate " + rate + "%";
		int i = 0;
		do {
			accumulated = accumulated * (1 + rate / 100);
			i++;
		}while ( i < terms);
		s += "\nAfter " + terms;
		System.out.print(s);
		String s1 = " terms the principal amounts to " + accumulated;
		System.out.println(s1);
	}

}