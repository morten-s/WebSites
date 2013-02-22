import javax.swing.JOptionPane;

/**
 * @author nml
 * @version 2013-01-29
 * 
 */
public class Accumulate {

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
		while ( i < terms) {
			accumulated = accumulated * (1 + rate / 100);
			i++;
		}
		s += "\nAfter " + terms;
		String s1 = " terms the principal amounts to " + accumulated;
		s += s1;
		JOptionPane.showMessageDialog(null, s); // display variable
	}

}